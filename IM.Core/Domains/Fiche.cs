using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace IM.Core.Domains
{
    public class Fiche : BaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime Date{ get; set; }
        public string Description { get; set; }
        public virtual ICollection<FicheLine> FicheLines { get; set; }
    }
}
