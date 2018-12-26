using Nexamind.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nexamind.BO.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();

        Task<User> GetUser(string uniqueIdentity);

        Task Create(User user);

        Task<bool> Update(User user);

        Task<bool> Delete(string name);
    }
}
