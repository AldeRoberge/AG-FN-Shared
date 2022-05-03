using System;
using System.Threading.Tasks;
using AG_FishNet_Database.Database;
using AG_FishNet_Database.Database.Collections.Accounts;
using AG_FishNet_Database.Database.DTO;
using NUnit.Framework;

namespace AG_FishNet_Database_Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public async Task ConnectToDatabase()
        {
            // Get the database name and connection string from the environment variables
            var databaseName = Environment.GetEnvironmentVariable("DATABASE_NAME");
            var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");


        }
    }
}