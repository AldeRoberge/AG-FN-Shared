using AG_FishNet_Shared.Database.Collections.Accounts;
using AG_FishNet_Shared.Utils;
using MongoDB.Driver;

// ReSharper disable UnusedType.Global

namespace AG_FishNet_Shared.Database
{
    public class Database
    {
        private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        private static IMongoDatabase _database;
        private static MongoClient _mongoClient;

        public Accounts Accounts;

        public Database(string databaseName, string connectionString)
        {
            LoggingUtils.SetupLogging();

            LoadDatabase(databaseName, connectionString);
            LoadCollections();
        }

        private void LoadCollections()
        {
            // Setup the DatabaseMediators (collections)
            Accounts = new Accounts(_database, "accounts");
        }

        private void LoadDatabase(string databaseName, string connectionString)
        {
            // The name of the database depends on the setup (testing/production)
            _database = GetDatabase(databaseName, connectionString);
            Log.Info("Success! Connected to database: " + databaseName + "!");
        }

        private IMongoDatabase GetDatabase(string databaseName, string connectionString)
        {
            Log.Info("Getting the " + databaseName + " database...");

            _mongoClient = new MongoClient(connectionString);
            return _mongoClient.GetDatabase(databaseName);
        }
    }
}