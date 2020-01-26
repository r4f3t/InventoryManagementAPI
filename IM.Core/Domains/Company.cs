using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace IM.Core.Domains
{
    public class Company: BaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime FirstJoin { get; set; }
    }

}
