using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexamind.Data.Models
{
    public class Question
    {
        [BsonId]
        public ObjectId _id { get; set; }

        public int level { get; set; }

        public DateTime Date { get; set; }

        public string option1 { get; set; }

        public string option2 { get; set; }

        public string option3 { get; set; }

        public string option4 { get; set; }

        public string answer { get; set; }

        public string question { get; set; }
    }
}
