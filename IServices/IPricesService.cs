using System.Collections.Generic;
using CloudPrice.Data;
using MongoDB.Bson;

namespace CloudPrice.IServices
{
    public interface IPricesService
    {
        Prices GetPrice(string SizesID);
        List<Prices> GetPrices();
        List<Prices> GetHistoric(string skuname_input, string region_input);
        List<string> GetRegions();
        List<string> GetSkuname();
        //Task<GridEntity<Prices>> GetPricesAsync(int pageIndex, int pageSize, QueryModel<Prices> queryModel);
    }
}
