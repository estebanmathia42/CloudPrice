// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CloudPrice.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Esteban\source\repos\CloudPrice\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esteban\source\repos\CloudPrice\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Esteban\source\repos\CloudPrice\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Esteban\source\repos\CloudPrice\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Esteban\source\repos\CloudPrice\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Esteban\source\repos\CloudPrice\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Esteban\source\repos\CloudPrice\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Esteban\source\repos\CloudPrice\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Esteban\source\repos\CloudPrice\_Imports.razor"
using CloudPrice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Esteban\source\repos\CloudPrice\_Imports.razor"
using CloudPrice.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Esteban\source\repos\CloudPrice\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esteban\source\repos\CloudPrice\Pages\Counter.razor"
using AntDesign.TableModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Esteban\source\repos\CloudPrice\Pages\Counter.razor"
using CloudPrice.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/catalogue")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Esteban\source\repos\CloudPrice\Pages\Counter.razor"
       
    IEnumerable<Sizes> selectedRows;
    AntDesign.ITable table;

    int _pageIndex = 1;
    int _pageSize = 10;
    int _total = 0;

    protected override async Task OnInitializedAsync()
    {

    }

    async Task onChange(QueryModel<Sizes> queryModel)
    {
        var data = await forecastService.GetForecastAsync(queryModel.PageIndex, queryModel.PageSize, queryModel);
        forecasts = data.Items.ToArray();

        _pageIndex = queryModel.PageIndex;
        _pageSize = queryModel.PageSize;
        _total = data.TotalCount;

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
