using System.Threading.Tasks;
using AG_FishNet_Shared.Database.Collections.Core.Database.Db;
using AG_FishNet_Shared.Database.DTO;
using MongoDB.Driver;

namespace AG_FishNet_Shared.Database.Collections.Accounts
{
    public partial class Accounts : DatabaseMediator<UserAccount>
    {
        private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        public Accounts(IMongoDatabase database, string collectionName) : base(database, collectionName)
        {
        }

        public Task<UserAccount> GetAccountByUsernameAsync(string username)
        {
            return GetCollection().Find(b => b.Username == username).FirstOrDefaultAsync();
        }

        public Task<UserAccount> GetAccountAsync(string phoneNumber)
        {
            return GetCollection().Find(b => b.PhoneNumber == phoneNumber).FirstOrDefaultAsync();
        }

        public async Task<UserAccount> SetIP(string phoneNumber, string IPAddress)
        {
            return await Update(await GetAccountAsync(phoneNumber), Set(nameof(UserAccount.IPAddress), IPAddress));
        }

        public async Task<UserAccount> SetPhoneCode(string phoneNumber, string phoneCode)
        {
            return await Update(await GetAccountAsync(phoneNumber), Set(nameof(UserAccount.PhoneCode), phoneCode));
        }
    }
}