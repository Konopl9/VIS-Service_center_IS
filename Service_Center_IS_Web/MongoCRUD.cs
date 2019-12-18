using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Service_Center_IS_Web
{
    public class MongoCRUD
    {
        private IMongoDatabase db;

        public class MongoDevice
        {
            [BsonId]
            public  Guid Id { get; set; }

            public string Type { get; set; }

            public string Company { get; set; }

            public string Model { get; set; }

            public string Defect { get; set; }

            public int Price { get; set; }

        }
        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }
    }
}