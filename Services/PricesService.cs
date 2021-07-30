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
            _mongoClient = new MongoClient("mongodb://cosmodbcloudprice:KR7ci8pwt9Sbqp8yim5Rejmp0LwInQiAFQGAdWIwL9YzInV5GzihG2NpV1MjW1IkCxDhiQwgMhWpnRiSUrNi6Q==@cosmodbcloudprice.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&retrywrites=false&maxIdleTimeMS=120000&appName=@cosmodbcloudprice@");
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

        public List<Prices> GetHistoric(string skuname, string region, string billingtype)
        {
            return _priceTable.Find(x => x.skuname == skuname & x.region == region & x.billingtype == billingtype).ToList();
        }
        public List<string> GetProvider()
        {
            var result = _priceTable.Find(x => true).ToList().Distinct();
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
            foreach (var skuname in result)
            {
                if (!(data.Contains((string)skuname["skuname"])))
                {
                    data.Add((string)skuname["skuname"]);
                }
            }
            return data;
        }

        public List<string> GetRegion(string skuname)
        {
            var result = _priceTable.Find(x => x.skuname == skuname).Project("{_id: 0,scantime:0,provider:0, billingtype:0,currency:0,priceperunit:0,unit:0}").ToList().Distinct();//rajouter les filtres
            List<string> data = new();
            foreach (var region in result)
            {
                try
                {
                    if (!(data.Contains((string)region["region"])))
                    {
                        data.Add((string)region["region"]);
                    }
                    else
                    {
                        if (!(data.Contains("GLOBAL")))
                        {
                            data.Add("GLOBAL");
                        }
                    }
                }catch{
                    if (!(data.Contains("GLOBAL")))
                    {
                        data.Add("GLOBAL");
                    }
                }
            }
            return data;
        }

        public List<string> GetBillingtype(string region, string skuname)
        {
            var result = _priceTable.Find(x => x.skuname == skuname & x.region == region).Project("{_id: 0,scantime:0,provider:0,effectivedate:0,currency:0,priceperunit:0,unit:0}").ToList().Distinct();
            List<string> data = new();
            foreach (var billingtype in result)
            {
                if (!(data.Contains((string)billingtype["billingtype"])))
                {
                    data.Add((string)billingtype["billingtype"]);
                }
            }
            return data;
        }
    }
}
