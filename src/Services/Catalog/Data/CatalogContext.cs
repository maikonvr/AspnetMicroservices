using System.Runtime.CompilerServices;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Catalog.Entities;
using MongoDB.Driver;

namespace Catalog.Data
{
    public class CatalogContext : ICatalogContext
    {
        
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));

            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));

            CatalogContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products {get; }
        
    }
}