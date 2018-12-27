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