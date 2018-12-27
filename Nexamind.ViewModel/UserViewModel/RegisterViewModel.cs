using System;
using System.Collections.Generic;
using System.Text;

namespace Nexamind.ViewModel.UserViewModel
{
    public class RegisterViewModel : BaseModel
    {
        //[BsonId]
       // public ObjectId Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string UniqueId { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string CountryDialingCode { get; set; }

        public string PhoneNumber { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        //public DateTime CreatedDate { get; set; }

        //public ObjectId CreatedBy { get; set; }

        //public DateTime ModifiedDate { get; set; }

        //public ObjectId ModifiedBy { get; set; }

        //public bool IsActive { get; set; }
    }
}
