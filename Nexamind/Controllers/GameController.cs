using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Nexamind.BO.QuestionRepository;
using Nexamind.BO.UserRepository;
using Nexamind.ViewModel.QuestionViewModel;

namespace Nexamind.Controllers
{
    public class GameController : Controller
    {

        private readonly IUserRepository _userRepository;
        private readonly IQuestionRepository _questionRepository;
        public GameController(IUserRepository userRepository, IQuestionRepository questionRepository)
        {
            _userRepository = userRepository;
            _questionRepository = questionRepository;
        }


        public IActionResult Index()
        {
            GameQuestionViewModel gameQuestion = new GameQuestionViewModel();
            gameQuestion.Question = _questionRepository.GetQuestion(1);
           
            return View(gameQuestion);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(GameQuestionViewModel gameQuestion)
        {
            return View();
        }
    }
}