#pragma checksum "C:\Users\Esteban\Source\Repos\CloudPricewebapp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9b79a58e778c933abf3f6bf73feb0ead006c7d9"
// <auto-generated/>
#pragma warning disable 1591
namespace CloudPrice.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using CloudPrice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using CloudPrice.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\_Imports.razor"
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-pzj4o8v2uo");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-pzj4o8v2uo");
            __builder.OpenComponent<CloudPrice.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-pzj4o8v2uo");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content px-4");
            __builder.AddAttribute(13, "b-pzj4o8v2uo");
            __builder.AddContent(14, 
#nullable restore
#line 10 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
