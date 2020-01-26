using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IM.Core.Domains
{
    public class User : BaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }


}
