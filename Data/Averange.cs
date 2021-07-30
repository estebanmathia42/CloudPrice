using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace CloudPrice.Data
{
    public class Averange
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();
        public string skuname { get; set; } = "";
        //public List<List<[string, int]>> price { get; set; }
        public int cpu { get; set; } = 0;
    }

    public class pair
    {
        public string region { get; set; } = "";
        public int average_price { get; set; } = 0;
    }
}
