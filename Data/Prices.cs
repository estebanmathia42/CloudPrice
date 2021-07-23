using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CloudPrice.Data
{
    public class Prices
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();
        public string skuname { get; set; } = "";
        public string unit { get; set; } = "";
        public double priceperunit { get; set; }
        public string currency { get; set; } = "";
        public string region { get; set; } = "";
        public string billingtype { get; set; } = "";
        public string effectivedate { get; set; } = "";
        public string scantime { get; set; } = "";
        public string provider { get; set; } = "";
    }
}
