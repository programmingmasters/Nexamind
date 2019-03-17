using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Nexamind.ViewModel.UserViewModel
{
    public class RegisterViewModel : BaseModel
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string first_name { get; set; }

        [Display(Name = "Last Name")]
        public string last_name { get; set; }

        [Required]
        public string gender { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "ValidateEmail", controller:"Account")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirm_password { get; set; }

        public string country_dialing_code { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string phone_number { get; set; }

        [DataType(DataType.Text)]
        public string address_line1 { get; set; }

        [DataType(DataType.Text)]
        public string address_line2 { get; set; }

        public string city { get; set; }

        [DataType(DataType.PostalCode)]
        public string zip_code { get; set; }

        public string state { get; set; }

        public string country { get; set; }

        public int wallet { get; set; }

        public int total_reward { get; set; }

        public bool is_pro { get; set; }

        public DateTime pro_activated_date { get; set; }

        public DateTime created_date { get; set; }

        public ObjectId created_by { get; set; }

        public DateTime modified_date { get; set; }

        public ObjectId modified_by { get; set; }

        public bool is_active { get; set; } = true;
    }
}
