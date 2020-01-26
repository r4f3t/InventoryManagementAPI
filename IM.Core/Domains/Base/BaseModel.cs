using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace IM.Core.Domains
{
    public abstract class BaseModel
    {
        public string CreatedBy { get; set; }
        public DateTime  Created   { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModified { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string CompanyId { get; set; }
    }


}
