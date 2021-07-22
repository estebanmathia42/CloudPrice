using CloudPrice.Data;
using CloudPrice.IServices;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.IO;
using AntDesign.TableModels;

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

        public List<Prices> GetHistoric(string provider_input,string skuname_input,int ram_input,int cpu_input,string region_input,int disk_input,int maxdiskavailable_input)
        {
            return _sizesTable.Find(x => true).ToList();//rajouter les filtres
        }
        public List<string> GetRegions()
        {
            _sizesTable.Find(x => true).ToList();//rajouter les filtres
            List<string> data = new();
            return  data;
        }
    }
}
