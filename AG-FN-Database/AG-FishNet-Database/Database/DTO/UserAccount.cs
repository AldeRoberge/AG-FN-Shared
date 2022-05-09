using System;
using System.Collections.Generic;
using AG_FishNet_Database.Database.DTO.Core;
using AG_FishNet_Database.Utils;
using MongoDB.Bson;

namespace AG_FishNet_Database.Database.DTO
{
    public class UserAccount : Identifiable
    {
        public string PhoneNumber { get; set; }

        public string IPAddress { get; set; }

        public string PhoneCode { get; set; }

        public string Username { get; set; }

        public DateTime DateCreated { get; set; }

        public UserAccount(string phoneNumber, string ipAddress)
        {
            PhoneNumber = phoneNumber;
            IPAddress = ipAddress;
            DateCreated = DateTime.Now;
            Username = RandomName.GetRandomName();
        }
    }
}