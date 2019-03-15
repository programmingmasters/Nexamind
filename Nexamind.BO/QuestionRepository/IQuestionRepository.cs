using Nexamind.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nexamind.BO.QuestionRepository
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<Question>> GetAllQuestions();

        Task<Question> GetQuestion(string uniqueIdentity);

        Task Create(Question question);

        Task<bool> Update(Question question);


        Task<bool> Delete(string name);
        
    }
}
