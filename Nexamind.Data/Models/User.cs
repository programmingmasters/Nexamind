using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nexamind.Data.Models
{
    public class User
    {
        [BsonId] 
        public  ObjectId _id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string gender { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string country_dialing_code { get; set; }

        public string phone_number { get; set; }

        public string address_line1 { get; set; }

        public string address_line2 { get; set; }

        public string city { get; set; }

        public string zip_code { get; set; }

        public string state { get; set; }

        public string country { get; set; }

        public DateTime created_date { get; set; }
       
        public ObjectId created_by { get; set; }

        public DateTime modified_date { get; set; }
       
        public ObjectId modified_by { get; set; }

        public bool is_active { get; set; }
    }
}
