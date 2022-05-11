using System.Collections.Generic;
using System.Threading.Tasks;
using AG_FishNet_Shared.Database.DTO;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AG_FishNet_Shared.Database.Collections.Accounts
{
    public partial class Accounts
    {
        public async Task<FriendRequests> GetFriendRequests(UserAccount userAccount)
        {
            return await GetFriendRequests(userAccount.Id);
        }

        public async Task<FriendRequests> GetFriendRequests(ObjectId userId)
        {
            return (await Get(userId)).FriendRequests;
        }

        public async Task<List<UserAccount>> GetFriends(UserAccount userAccount)
        {
            List<UserAccount> friends = new List<UserAccount>();

            var friendRequests = await GetFriendRequests(userAccount);

            foreach (var objectId in friendRequests.Accepted)
            {
                // Get the other player's friend request
                var otherFriends = await GetFriendRequests(objectId);

                // If this player has also accepted the other player's friend request, then they are friends
                if (otherFriends.Accepted.Contains(userAccount.Id))
                {
                    friends.Add(await Get(objectId));
                }
            }

            return friends;
        }


        public async Task<FriendRequests> AddFriend(UserAccount userAccount, ObjectId friend)
        {
            var friendsRequests = await GetFriendRequests(userAccount);

            // Remove from pending and rejected
            if (friendsRequests.Pending.Contains(friend)) friendsRequests.Pending.Remove(friend);
            if (friendsRequests.Rejected.Contains(friend)) friendsRequests.Rejected.Remove(friend);
            
            // Add to accepted
            if (!friendsRequests.Accepted.Contains(friend)) friendsRequests.Accepted.Add(friend);

            friendsRequests.Accepted.Add(friend);
            userAccount = await Update(await Get(userAccount), Set(nameof(UserAccount.FriendRequests), friendsRequests));

            return userAccount.FriendRequests;
        }


        public async Task<FriendRequests> RemoveFriend(UserAccount userAccount, ObjectId friend)
        {
            var friendRequests = await GetFriendRequests(userAccount);

            // Remove from accepted and pending
            if (friendRequests.Accepted.Contains(friend)) friendRequests.Accepted.Remove(friend);
            if (friendRequests.Pending.Contains(friend)) friendRequests.Pending.Remove(friend);
            
            // Add to rejected
            if (!friendRequests.Rejected.Contains(friend)) friendRequests.Rejected.Add(friend);

            userAccount = await Update(await Get(userAccount), Set(nameof(UserAccount.FriendRequests), friendRequests));

            return userAccount.FriendRequests;
        }
    }
}