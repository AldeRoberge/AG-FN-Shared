using System;
using System.Collections.Generic;
using AG_FishNet_Shared.Database.DTO.Core;
using AG_FishNet_Shared.Utils;
using MongoDB.Bson;

namespace AG_FishNet_Shared.Database.DTO
{
    public class UserAccount : Identifiable
    {
        public string PhoneNumber { get; set; }

        public string IPAddress { get; set; }

        public string PhoneCode { get; set; }

        public string Username { get; set; }

        public DateTime DateCreated { get; set; }
        
        public bool AccountInUse { get; set; }

        public FriendRequests FriendRequests { get; set; }
        
        public UserAccount(string phoneNumber, string ipAddress)
        {
            PhoneNumber = phoneNumber;
            IPAddress = ipAddress;
            DateCreated = DateTime.Now;
            Username = RandomName.GetRandomName();
            AccountInUse = false;
            FriendRequests = new FriendRequests();
        }
    }
}