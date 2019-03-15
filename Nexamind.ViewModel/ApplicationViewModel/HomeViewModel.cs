using Nexamind.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexamind.ViewModel.ApplicationViewModel
{
    public class HomeViewModel : BaseModel
    {
        public List<User> LeaderboardAllUsers { get; set; } = new List<User>();
        public List<Question> Questions { get; set; } = new List<Question>();
        public User Profile { get; set; } = new User();

     
    }
}
