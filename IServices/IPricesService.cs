using System.Collections.Generic;
using CloudPrice.Data;
using MongoDB.Bson;

namespace CloudPrice.IServices
{
    public interface IPricesService
    {
        Prices GetPrice(string SizesID);
        List<Prices> GetPrices();
        IEnumerable<BsonDocument> GetHistoric(string skuname_input);
        List<string> GetProvider();
        List<string> GetSkuname(string provider);
        //Task<GridEntity<Prices>> GetPricesAsync(int pageIndex, int pageSize, QueryModel<Prices> queryModel);
    }
}
