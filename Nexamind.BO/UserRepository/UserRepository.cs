using MongoDB.Driver;
using Nexamind.Data;
using Nexamind.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nexamind.BO.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly INexamindDBContext _context;

        public UserRepository(INexamindDBContext context)
        {
            _context = context;
        }

        //to get the list of all users
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.Users.Find(_ => true).ToListAsync();
        }


        //to get the detail of a single user
        public Task<User> GetUser(string uniqueIdentity)
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq(m => $"{m.Email}", uniqueIdentity);

            return _context.Users.Find(filter).FirstOrDefaultAsync();
        }

        //create a new user
        public async Task Create(User user)
        {
            try
            {
                await _context.Users.InsertOneAsync(user);
            }
            catch (Exception ex)
            {
                throw new Exception("New User has not been created successfully", ex);
            }


        }

        //to update a user
        public async Task<bool> Update(User user)
        {
            ReplaceOneResult updateResult = await _context.Users.ReplaceOneAsync(
            filter: g => g.Id == user.Id,
            replacement: user);

            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;

        }

        //to delete a user
        public async Task<bool> Delete(string name)
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq(m => $"{m.FirstName} {m.LastName}", name);

            DeleteResult deleteResult = await _context.Users.DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;

        }


    }
}
