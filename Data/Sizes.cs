using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CloudPrice.Data
{
    public class Sizes
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();
        public string skuname { get; set; } = "";
        public int cpu { get; set; } = 0;
        public int ram { get; set; } = 0;
        public int disk { get; set; } = 0;
        public int maxdiskavailable { get; set; } = 0;
        public string provider { get; set; } = "";
        public string region { get; set; } = "";
    }
    public class GridEntity<T>
    {
        public List<T> Items { get; set; }
        public int TotalCount { get; set; }
    }
}