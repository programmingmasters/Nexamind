using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexamind.Data.Models
{
    public class Result
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public int level { get; set; }
        public string date { get; set; }
        public List<Game> games { get; set; }
    }
}
