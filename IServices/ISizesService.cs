using CloudPrice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AntDesign;
using AntDesign.TableModels;

namespace CloudPrice.IServices
{
    public interface ISizesService
    {
        Sizes GetSize(string SizesID);
        List<Sizes> GetSizes();
        List<Sizes> GetSizes_limited(int pageIndex, int pageSize);
        Task<GridEntity<Sizes>> GetSizesAsync(int pageIndex, int pageSize, QueryModel<Sizes> queryModel, Sizes[] sizes);
        List<Sizes> GetSizes_spe(Dictionary<string, IEnumerable<string>> tags);
    }
}
