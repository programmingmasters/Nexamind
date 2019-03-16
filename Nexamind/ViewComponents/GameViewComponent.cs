using Microsoft.AspNetCore.Mvc;
using Nexamind.BO.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nexamind.ViewComponents
{
    public class GameViewComponent : ViewComponent
    {
        private readonly IUserRepository _userRepository;

        public GameViewComponent(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userRepository.GetAllUsers();
            return View(user);
        }
    }
}
