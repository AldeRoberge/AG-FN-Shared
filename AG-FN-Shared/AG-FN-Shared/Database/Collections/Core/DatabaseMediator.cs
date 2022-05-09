using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AG_FishNet_Shared.Database.DTO.Core;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AG_FishNet_Shared.Database.Collections.Core
{
    namespace Database.Db
    {
        public abstract class DatabaseMediator<T> where T : Identifiable
        {
            private readonly NLog.Logger _log = NLog.LogManager.GetCurrentClassLogger();

            private readonly IMongoDatabase _database;

            private readonly string _collectionName;

            private IMongoCollection<T> _collection;

            public DatabaseMediator(IMongoDatabase database, string collectionName)
            {
                _database = database;
                _collectionName = collectionName;
            }

            protected IMongoCollection<T> GetCollection()
            {
                return _collection ?? (_collection = _database.GetCollection<T>(_collectionName));
            }

            public async Task<T> Create(T toAdd)
            {
                await GetCollection().InsertOneAsync(toAdd);
                return toAdd;
            }

            protected async Task<T> Update(FilterDefinition<T> filter, UpdateDefinition<T> update)
            {
                return await GetCollection().FindOneAndUpdateAsync(
                    filter,
                    update,
                    new FindOneAndUpdateOptions<T>()
                    {
                        ReturnDocument = ReturnDocument.After
                    });
            }

            protected async Task<T> Delete(FilterDefinition<T> filter)
            {
                return await GetCollection().FindOneAndDeleteAsync(filter);
            }

            protected async Task<ReplaceOneResult> Replace(T replace)
            {
                return await GetCollection().ReplaceOneAsync(GetEqualityFilter(replace), replace);
            }

            protected async Task<UpdateResult> UpdateAll(UpdateDefinition<T> update)
            {
                return await GetCollection().UpdateManyAsync(
                    FilterDefinition<T>.Empty,
                    update);
            }

            protected async Task<UpdateResult> UpdateAll(FilterDefinition<T> filter, UpdateDefinition<T> update)
            {
                return await GetCollection().UpdateManyAsync(
                    filter,
                    update);
            }

            protected UpdateDefinition<T> Combine(params UpdateDefinition<T>[] updates)
            {
                return Builders<T>.Update.Combine(updates);
            }

            /**
         * For some reason, this errors from time to time.
         *
         * The error is the following :
         *
         * Unhandled Exception: MongoDB.Driver.MongoConnectionException: An exception occurred while receiving a message from the server.
         * ---> System.IO.IOException: The decryption operation failed, see inner exception.
         * ---> System.ComponentModel.Win32Exception: The specified data could not be decrypted
         *
         * That is why I have decided to wrap in a try catch.
         */
            public async Task<List<T>> GetAll()
            {
                try
                {
                    return await GetCollection().Find(FilterDefinition<T>.Empty).ToListAsync();
                }
                catch (Exception e)
                {
                    _log.Error(e);
                    _log.Error("Error while getting all objects in collection " + _collectionName + " of type " +
                               typeof(T) + ".");
                    return new List<T>();
                }
            }


            /// <summary>
            /// Get by Id
            /// </summary>
            public Task<T> Get(ObjectId id)
            {
                return GetCollection().Find(b => b.Id == id).FirstOrDefaultAsync();
            }

            public Task<T> Get(T id)
            {
                return GetCollection().Find(b => b.Id == id.Id).FirstOrDefaultAsync();
            }

            public async Task<T> Update(T b, UpdateDefinition<T> update)
            {
                var filter = GetEqualityFilter(b);
                return await Update(filter, update);
            }

            public async Task<T> Delete(T b)
            {
                return await Delete(GetEqualityFilter(b));
            }

            /// <summary>
            /// Get an equality filter for the object based on the Id.
            /// </summary>
            public FilterDefinition<T> GetEqualityFilter(T @object)
            {
                return Builders<T>.Filter.Eq(x => x.Id, @object.Id);
            }

            protected UpdateDefinition<T> Set<TValue>(string field, TValue value)
            {
                return Builders<T>.Update.Set(field, value);
            }

            protected UpdateDefinition<T> Inc<TValue>(string field, TValue value)
            {
                return Builders<T>.Update.Inc(field, value);
            }

            protected UpdateDefinition<T> Push<TValue>(string field, TValue value)
            {
                return Builders<T>.Update.Push(field, value);
            }
        }
    }
}