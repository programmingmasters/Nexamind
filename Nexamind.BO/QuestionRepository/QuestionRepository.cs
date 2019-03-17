using MongoDB.Driver;
using Nexamind.Data;
using Nexamind.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nexamind.BO.QuestionRepository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly INexamindDBContext _context;

        public QuestionRepository(INexamindDBContext context)
        {
            _context = context;
        }

        //to get the list of all users
        public async Task<IEnumerable<Question>> GetAllQuestions()
        {
            return await _context.questions.Find(_ => true).ToListAsync();
        }


        //to get the detail of a single user
        public Task<Question> GetQuestion(int uniqueIdentity)
        {
            FilterDefinition<Question> filter = Builders<Question>.Filter.Eq(m => m.order, uniqueIdentity);

            return _context.questions.Find(filter).FirstOrDefaultAsync();
        }

        //create a new question
        public async Task Create(Question question)
        {
            try
            {
                await _context.questions.InsertOneAsync(question);
            }
            catch (Exception ex)
            {
                throw new Exception("New User has not been created successfully", ex);
            }


        }

        //to update a question
        public async Task<bool> Update(Question question)
        {
            ReplaceOneResult updateResult = await _context.questions.ReplaceOneAsync(
            filter: g => g._id == question._id,
            replacement: question);

            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;

        }

        //to delete a user
        public async Task<bool> Delete(string name)
        {
            FilterDefinition<Question> filter = Builders<Question>.Filter.Eq(m => $"{m.question}", name);

            DeleteResult deleteResult = await _context.questions.DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;

        }


    }
}
