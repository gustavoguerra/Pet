using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPet.Repository
{
    public class conection
    {
        public IMongoDatabase startconection()
        {

            var client = new MongoClient("");
            var database = client.GetDatabase("developersdb00");

            return database;
        }
    }
}
