using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudPrice.Data;
using AntDesign;
using AntDesign.TableModels;

namespace CloudPrice.IServices
{
    public interface IPricesService
    {
        Prices GetPrice(string SizesID);
        List<Prices> GetPrices();
        List<Prices> GetHistoric(string provider_input, string skuname_input, int ram_input, int cpu_input, string region_input, int disk_input, int maxdiskavailable_input);
        List<string> GetRegions();
        //Task<GridEntity<Prices>> GetPricesAsync(int pageIndex, int pageSize, QueryModel<Prices> queryModel);
    }
}
