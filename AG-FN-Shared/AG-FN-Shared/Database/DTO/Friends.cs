using System.Collections.Generic;
using MongoDB.Bson;

namespace AG_FishNet_Shared.Database.DTO
{
    public class FriendRequests
    {
        // FriendRequests
        public List<ObjectId> Accepted { get; set; }
       
        // Pending
        public List<ObjectId> Pending { get; set; }
        
        // Rejected
        public List<ObjectId> Rejected { get; set; }

        public FriendRequests()
        {
            Accepted = new List<ObjectId>();
            Pending = new List<ObjectId>();
            Rejected = new List<ObjectId>();
        }
    }
}