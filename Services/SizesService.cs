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
    public class SizesService : ISizesService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<Sizes> _sizesTable = null;

        public SizesService()
        { 
            //mongodb://172.17.0.3:27017/
            _mongoClient = new MongoClient("mongodb://cosmodbcloudprice:YYlYWVG7CSwzOWnHpTMh0DirehXIGc0pN21RIuhfTh0tP5hFleTdIL9sGvOI2PqqHQiYhecXnRMpAvhyqIllNA==@cosmodbcloudprice.mongo.cosmos.azure.com:10255/?ssl=true&retrywrites=false&replicaSet=globaldb&maxIdleTimeMS=120000&appName=@cosmodbcloudprice@");
            _database = _mongoClient.GetDatabase("CloudPrice");
            _sizesTable = _database.GetCollection<Sizes>("sizes");
        }

        public Sizes GetSize(string sizesID)
        {
            return _sizesTable.Find(x => x.Id == sizesID).FirstOrDefault();
        }

        public List<Sizes> GetSizes()
        {
            return _sizesTable.Find(x => true).ToList();
        }

        public List<Sizes> GetSizes_limited(int page_index, int page_size)
        {
            return _sizesTable.Find(x => true).Limit(page_index * page_size * 5).ToList();
        }

        public Task<GridEntity<Sizes>> GetSizesAsync(int pageIndex, int pageSize, QueryModel<Sizes> queryModel, Sizes[] sizes)
        {
            var forcastList = sizes.ToList();
            foreach (var sort in queryModel.SortModel)
            {
                if (sort.Sort != null)
                {
                    if (sort.Sort == "ascend")
                    {
                        forcastList = forcastList.OrderBy(o => this.GetPropValue(o, sort.FieldName)).ToList();
                    }
                    else if (sort.Sort == "descend")
                    {
                        forcastList = forcastList.OrderByDescending(o => this.GetPropValue(o, sort.FieldName)).ToList();
                    }
                }
            }
            var totalcount = forcastList.Count;

            GridEntity<Sizes> list = new();
            list.Items = forcastList;
            list.TotalCount = totalcount;
            return Task.FromResult(list);
        }
        public object GetPropValue(object src, string propName)
        {
            var result = src.GetType().GetProperty(propName).GetValue(src, null);
            return result;
        }

        public List<Sizes> GetSizes_spe(Dictionary<string, IEnumerable<string>> tags)
        {
            var builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> all_filter = builder.Gt("ram", 0);
            Dictionary<string, IEnumerable<string>>.KeyCollection keys = tags.Keys;
            
            foreach (var key in keys)
            {
                foreach (var element in tags[key])
                {
                    all_filter = all_filter & builder.Eq(key, element);
                }
            }
            List<Sizes> data = new();
            List<Sizes> result = new();
            data = _database.GetCollection<Sizes>("sizes").Find(x => true).ToList();
            foreach (var i in data)
            {
                if (filter(tags, i)) {
                    result.Add(i);
                }
            }
            return result;
        }

        private bool filter(Dictionary<string, IEnumerable<string>> tags, Sizes x)
        {
            Dictionary<string, IEnumerable<string>>.KeyCollection keys = tags.Keys;
            int total_pass = 0;
            int total_validation = 0;
            int real_validation = 0;

            foreach (var key in keys)
            {
                if (tags[key].Count() == 0)
                {
                    total_pass += 1;
                    if (total_pass == 7)
                    {
                        return true;
                    }
                    continue;
                }
                total_validation += 1;
                foreach (var element in tags[key])
                {
                    try {
                        if (element == (string)GetPropValue(x, key))
                        {
                            real_validation += 1;
                        }
                    }
                    catch
                    {
                        if (element == GetPropValue(x, key).ToString())
                        {
                            real_validation += 1;
                        }
                    }
                }
            }
            return real_validation >= total_validation;

        }
    }
}
