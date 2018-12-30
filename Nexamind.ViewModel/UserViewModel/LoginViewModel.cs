using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nexamind.ViewModel.UserViewModel
{
    public class LoginViewModel: BaseModel
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Display(Name ="Password")]
        public string Password { get; set; }
    }
}
