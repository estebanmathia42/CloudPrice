using CloudPrice.Data;
using CloudPrice.IServices;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;
using System.Collections.Generic;

namespace CloudPrice.Services
{
    public class PricesService : IPricesService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<Prices> _sizesTable = null;

        public PricesService()
        {
            //mongodb://172.17.0.3:27017/
            _mongoClient = new MongoClient("mongodb://cosmodbcloudprice:YYlYWVG7CSwzOWnHpTMh0DirehXIGc0pN21RIuhfTh0tP5hFleTdIL9sGvOI2PqqHQiYhecXnRMpAvhyqIllNA==@cosmodbcloudprice.mongo.cosmos.azure.com:10255/?ssl=true&retrywrites=false&replicaSet=globaldb&maxIdleTimeMS=120000&appName=@cosmodbcloudprice@");
            _database = _mongoClient.GetDatabase("CloudPrice");
            _sizesTable = _database.GetCollection<Prices>("sizes");
        }

        public Prices GetPrice(string sizesID)
        {
            return _sizesTable.Find(x => x.Id == sizesID).FirstOrDefault();
        }

        public List<Prices> GetPrices()
        {
            return _sizesTable.Find(x => true).ToList();
        }

        public List<Prices> GetHistoric(string skuname_input,string region_input)
        {
            //var builder = Builders<BsonDocument>.Filter;
            //var filter = 
            
            return _database.GetCollection<Prices>("prices").Find(x => true).ToList();//rajouter les filtres
        }
        public List<string> GetRegions()
        {
            var result =  _sizesTable.Find(new BsonDocument()).Project("{_id: 0, skuname:0,cpu:0,ram:0,effectivedate:0,scantime:0,provider:0}").ToList().Distinct();//rajouter les filtres
            List<string> data = new();
            foreach (var region in result)
            {
                if (!(data.Contains((string)region["region"]))){
                    data.Add((string)region["region"]);
                }
            }
            return  data;
        }

        public List<string> GetSkuname()
        {
            var result = _sizesTable.Find(new BsonDocument()).Project("{_id: 0,cpu:0,ram:0,effectivedate:0,scantime:0,provider:0,region:0}").ToList().Distinct();//rajouter les filtres
            List<string> data = new();
            foreach (var region in result)
            {
                if (!(data.Contains((string)region["skuname"])))
                {
                    data.Add((string)region["skuname"]);
                }
            }
            return data;
        }
    }
}
