using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace apiTest.Context
{
    public class MongoDBContext
    {
        MongoClient client;
        public IMongoDatabase database;

        public MongoDBContext()
        {
            var mongoClient = new MongoClient("mongodb://utkarsh:admin123123@ds331735.mlab.com:31735/productmanagementdb");
            database = mongoClient.GetDatabase("productmanagementdb");
            
        }
    }
}