using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Nexamind.ViewModel.QuestionViewModel
{
    public class GameQuestionViewModel
    {

        public Task<Data.Models.Question> Question { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public string Option4 { get; set; }

        [Required]
        public string answer { get; set; }
    }
}
