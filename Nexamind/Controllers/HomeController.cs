using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nexamind.BO.QuestionRepository;
using Nexamind.BO.UserRepository;
using Nexamind.Models;
using Nexamind.ViewModel.ApplicationViewModel;

namespace Nexamind.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IQuestionRepository _questionRepository;

        public HomeController(IUserRepository userRepository, IQuestionRepository questionRepository)
        {
            _userRepository = userRepository;
            _questionRepository = questionRepository;
        }

        
        public async Task <IActionResult> Index()
        {   
            HomeViewModel homeModel  = new HomeViewModel();
            if (TempData.ContainsKey("useremail"))
            {
                //homeModel.Questions = await _questionRepository.GetAllQuestions();
                homeModel.Profile = await _userRepository.GetUser(TempData["useremail"].ToString());
                TempData.Keep();
                return View(homeModel);
            }
            return RedirectToAction("Login","Account");
            
        }

        //public IActionResult Category()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //public IActionResult Questions()
        //{
        //    return View();
        //}

        //public IActionResult Settings()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
