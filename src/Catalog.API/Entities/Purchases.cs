using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.API.Entities
{
    public class Purchases
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? PurchaseId { get; set; }
        public string? DateTime { get; set; }

    }
}
