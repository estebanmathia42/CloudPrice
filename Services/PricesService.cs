using CloudPrice.Data;
using CloudPrice.IServices;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.Linq;
using System.Collections.Generic;
using System;

namespace CloudPrice.Services
{
    public class PricesService : IPricesService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<Sizes> _sizesTable = null;
        private IMongoCollection<Prices> _priceTable = null;

        public PricesService()
        {
            //mongodb://172.17.0.3:27017/
            _mongoClient = new MongoClient("mongodb://cosmodbcloudprice:YYlYWVG7CSwzOWnHpTMh0DirehXIGc0pN21RIuhfTh0tP5hFleTdIL9sGvOI2PqqHQiYhecXnRMpAvhyqIllNA==@cosmodbcloudprice.mongo.cosmos.azure.com:10255/?ssl=true&retrywrites=false&replicaSet=globaldb&maxIdleTimeMS=120000&appName=@cosmodbcloudprice@");
            _database = _mongoClient.GetDatabase("CloudPrice");
            _sizesTable = _database.GetCollection<Sizes>("sizes");
            _priceTable = _database.GetCollection<Prices>("prices");
        }

        public Prices GetPrice(string sizesID)
        {
            return _priceTable.Find(x => x.Id == sizesID).FirstOrDefault();
        }

        public List<Prices> GetPrices()
        {
            return _priceTable.Find(x => true).ToList();
        }

        public IEnumerable<BsonDocument> GetHistoric(string skuname_input)
        {
            return _priceTable.Find(x => x.skuname == skuname_input).Project("{_id: 0,scantime:0,provider:0,region:0, billingtype:0,currency:0,unit:0}").ToList().Distinct();
        }
        public List<string> GetProvider()
        {
            var result =  _sizesTable.Find(x => true).ToList().Distinct();
            List<string> data = new();
            foreach (var provider in result)
            {
                if (!(data.Contains((string)provider.provider))){
                    data.Add((string)provider.provider);
                }
            }
            return  data;
        }

        public List<string> GetSkuname(string provider)
        {
            var result = _priceTable.Find(x => x.provider == provider).Project("{_id: 0,scantime:0,provider:0,region:0, billingtype:0,currency:0,priceperunit:0,unit:0}").ToList().Distinct();//rajouter les filtres
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
