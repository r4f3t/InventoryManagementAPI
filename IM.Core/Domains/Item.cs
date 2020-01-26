using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IM.Core.Domains
{
    public class Item : BaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; }
        public string Barcode { get; set; }
        public string StockName { get; set; }
        public string StockCode { get; set; }
        public string Specode { get; set; }
        public string Specode2 { get; set; }
        public string Specode3 { get; set; }
        public string Specode4 { get; set; }
        public string Warehouse { get; set; }
        public int WarehouseId { get; set; }
    }
}
