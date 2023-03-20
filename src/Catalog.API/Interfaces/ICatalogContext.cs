using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Interfaces
{
    public interface ICatalogContext
    {
        public IMongoCollection<Product> Products { get;}
        public IMongoCollection<Purchases> Purchases { get; }

    }
}
