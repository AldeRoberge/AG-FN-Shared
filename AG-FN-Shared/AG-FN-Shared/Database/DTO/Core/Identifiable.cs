using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AG_FishNet_Shared.Database.DTO.Core
{
    public class Identifiable
    {
        [BsonId] [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id;
    }
}