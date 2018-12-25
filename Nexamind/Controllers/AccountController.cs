using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nexamind.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            if (Request.Cookies["Login"] != null)
            {
                //var Email = model.Email = Request.Cookies["Login"].Values["UserEmail"];
                //model.Password = Request.Cookies["Login"].Values["Password"];
                //var en  
            }
            return View();
        }
    }
}