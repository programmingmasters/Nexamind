using MongoDB.Driver;
using Nexamind.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexamind.Data
{
    public interface INexamindDBContext
    {
        IMongoCollection<User> Users{ get; }
    }
}
