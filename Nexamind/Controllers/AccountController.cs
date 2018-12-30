using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexamind.BO.UserRepository;
using Nexamind.Data.Models;
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
        public async Task<IActionResult> Login([Bind("Email", "Password")] LoginViewModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var User = await _userRepository.GetUser(loginModel.Email.Trim());

                    //check if user exists.
                    if (User == null)
                    {
                        loginModel.Message = "Account not found.";
                        return View(loginModel);
                    }

                    //check if user account is active.
                    if (!User.is_active)
                    {
                        loginModel.Message = "Account is not Active, Please Register Again!";
                        return View(loginModel);
                    }

                    //check if password is correct.
                    if (User.password != loginModel.Password)
                    {
                        loginModel.Message = "Incorrect Password!\n Please try again";
                        return View(loginModel);
                    }
                    loginModel.Message = "Login Successful!";
                    TempData["useremail"] = User.email;
                    return RedirectToAction("Index", "Home");
                }

                return View(loginModel);
               
                
            }
            catch (Exception)
            {
                return View( StatusCode(StatusCodes.Status500InternalServerError));
            }
            

            //return View(StatusCode(StatusCodes.Status500InternalServerError));
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerModel)
        {
            if (ModelState.IsValid)
            {
                //var user = await _userRepository.GetUser(registerModel.Email);
                //if (user != null)
                //{
                //    registerModel.Message = $"{registerModel.Email} already exists.\n Please Provide another Email.";
                //    return View(registerModel);
                //}
                
                var user = Mapper.Map<User>(registerModel);
                await _userRepository.Create(user);
                return RedirectToAction("Login","Account");
            }
            return View();
        }
        
        public IActionResult ForgetPassword()
        {
            return View();
        }

    }
}