using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Entities;
using MongoDB.Driver;

namespace Catalog.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Products> Products { get; }
    }
}