using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nexamind.ViewModel.UserViewModel
{
    public class LoginViewModel: BaseModel
    {
        [DataType(DataType.EmailAddress)]
        [StringLength(64,MinimumLength =3)]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\\$%\\^&\\*])(?=.{8,})")]
        [Required]
        public string Password { get; set; }
    }
}
