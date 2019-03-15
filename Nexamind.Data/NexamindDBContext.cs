using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Nexamind.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexamind.Data
{
    public class NexamindDBContext : INexamindDBContext
    {
        private readonly IMongoDatabase _db;

        public NexamindDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);

        }

        //To store the detail of a user
        public IMongoCollection<User> users => _db.GetCollection<User>("users");

        //To store the question and answers
        public IMongoCollection<Question> questions => _db.GetCollection<Question>("questions");

    }
}
