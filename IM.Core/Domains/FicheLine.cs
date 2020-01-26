using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IM.Core.Domains
{
    public class FicheLine : BaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; }
        public string Barcode { get; set; }
        public Item  Item{ get; set; }
        public int IoCode { get; set; }
        public int TrCode { get; set; }
        public string Description { get; set; }
        public virtual Fiche Fiche { get; set; }
    }
}
