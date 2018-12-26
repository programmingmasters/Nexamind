using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexamind.BO.UserRepository;
using Nexamind.ViewModel.UserViewModel;

namespace Nexamind.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginModel)
        {
            try
            {
               
                var User = await _userRepository.GetUser(loginModel.UniqueIdentity);

                //check if user exists.
                if (User == null)
                {
                    loginModel.Message = "Account not found.";
                    return View(loginModel);
                }

                //check if user account is active.
                if (!User.IsActive)
                {
                    loginModel.Message = "Account is not Active, Please Register Again!";
                    return View();
                }

                //check if password is correct.
                if (User.Password == loginModel.Password)
                {
                    loginModel.Message = "Login Successful!";
                    return RedirectToAction("Index", "Home", User);
                }
            }
            catch (Exception)
            {
                return View( StatusCode(StatusCodes.Status500InternalServerError));
            }
            

            return View(StatusCode(StatusCodes.Status500InternalServerError));
        }


        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ForgetPassword()
        {
            return View();
        }

    }
}