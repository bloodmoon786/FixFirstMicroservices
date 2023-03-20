using Catalog.API.Entities;
using Catalog.API.Interfaces;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var mongoClient = new MongoClient(configuration.GetValue<string>("DatabaseSetting:ConnectionString"));
            var database = mongoClient.GetDatabase(configuration.GetValue<string>("DatabaseSetting:DatabaseName"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("Product"));
            Purchases = database.GetCollection<Purchases>(configuration.GetValue<string>("Purchases"));


        }
        public IMongoCollection<Product> Products { get; }

        public IMongoCollection<Purchases> Purchases { get; }
    }
}
