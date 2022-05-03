using System;
using System.Threading.Tasks;
using AG_FishNet_Database.Database;
using AG_FishNet_Database.Database.DTO;
using AG_FishNet_Database.Utils;
using MongoDB.Driver;

namespace AG_FishNet_Tooling
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            // Test the RateLimiter class
            for (int i = 0; i < 10; i++)
            {
                bool rateLimited = RateLimiter.IsRateLimited("hey", 10, TimeSpan.FromMinutes(1));
                Console.WriteLine(rateLimited);
            }

            for (int i = 0; i < 5; i++)
            {
                bool rateLimited = RateLimiter.IsRateLimited("hey", 10, TimeSpan.FromMinutes(1));
                Console.WriteLine(rateLimited);
            }
            
            // Wait for 1 second
            await Task.Delay(500);
            
        }
    }
}