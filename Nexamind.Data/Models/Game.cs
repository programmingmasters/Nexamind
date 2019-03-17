using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexamind.Data.Models
{
    public class Game
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string question_id { get; set; }
        public string question_string { get; set; }
        public string answer_string { get; set; }
        public bool is_correct { get; set; }
    }
}
