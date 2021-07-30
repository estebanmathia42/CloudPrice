using System.Collections.Generic;
using CloudPrice.Data;
using MongoDB.Bson;

namespace CloudPrice.IServices
{
    public interface IPricesService
    {
        Prices GetPrice(string SizesID);
        List<Prices> GetPrices();
        List<Prices> GetHistoric(string skuname, string region, string billingtype);
        List<string> GetProvider();
        List<string> GetSkuname(string provider);
        List<string> GetRegion(string provider);
        List<string> GetBillingtype(string region, string skuname);
        //Task<GridEntity<Prices>> GetPricesAsync(int pageIndex, int pageSize, QueryModel<Prices> queryModel);
    }
}
