﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nexamind.ViewModel.UserViewModel
{
    public class LoginViewModel: BaseModel
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
