using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace IM.Core.Domains
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
    }
}
