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
            _mongoClient = new MongoClient("mongodb://127.0.0.1:27017");
            _database = _mongoClient.GetDatabase("CloudPrice");
            _sizesTable = _database.GetCollection<Sizes>("sizes");
        }

        public Sizes GetSize(string sizesID)
        {
            return _sizesTable.Find(x => x.Id == sizesID).FirstOrDefault();
        }

        public List<Sizes> GetSizes()
        {
            Console.WriteLine("Get Sizes execution");
            return _sizesTable.Find(x => true).ToList();
        }

        public Task<GridEntity<Sizes>> GetSizesAsync(int pageIndex, int pageSize, QueryModel<Sizes> queryModel)
        {
            var forcastList = GetSizes();
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
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }
}
