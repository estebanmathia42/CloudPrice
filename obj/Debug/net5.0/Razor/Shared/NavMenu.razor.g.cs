#pragma checksum "C:\Users\Esteban\Source\Repos\CloudPricewebapp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "339b0e7a7b219df25cf5a1de18b913d657fbe921"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""top-row pl-4 navbar navbar-dark"" b-fqfg7sc5ak><a class=""navbar-brand"" href b-fqfg7sc5ak><img src=""./css/images/LOGO-THECLOUDPRICES.COM.svg"" height=""50px"" b-fqfg7sc5ak></a>
    <button class=""navbar-toggler"" b-fqfg7sc5ak><span class=""navbar-toggler-icon"" b-fqfg7sc5ak></span></button></div>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "b-fqfg7sc5ak");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "nav flex-column");
            __builder.AddAttribute(5, "b-fqfg7sc5ak");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "nav-item px-3");
            __builder.AddAttribute(8, "b-fqfg7sc5ak");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(9);
            __builder.AddAttribute(10, "class", "nav-link");
            __builder.AddAttribute(11, "href", "");
            __builder.AddAttribute(12, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\Esteban\Source\Repos\CloudPricewebapp\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "<img src=\"./css/images/THECLOUDPRICES/BLEU FONCE/RECHERCHE.svg\" height=\"35px\" b-fqfg7sc5ak>");
                __builder2.AddMarkupContent(15, "<p class=\"text-navlink-button\" b-fqfg7sc5ak>Catalogue</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
