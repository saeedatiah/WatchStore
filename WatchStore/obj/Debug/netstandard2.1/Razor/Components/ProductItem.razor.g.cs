#pragma checksum "D:\WatchStore\WatchStore\Components\ProductItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b4d8b1ad604f98da8c2d67127b6af3200293526"
// <auto-generated/>
#pragma warning disable 1591
namespace WatchStore.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\WatchStore\WatchStore\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WatchStore\WatchStore\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WatchStore\WatchStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WatchStore\WatchStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WatchStore\WatchStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WatchStore\WatchStore\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WatchStore\WatchStore\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WatchStore\WatchStore\_Imports.razor"
using WatchStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WatchStore\WatchStore\_Imports.razor"
using WatchStore.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\WatchStore\WatchStore\_Imports.razor"
using WatchStore.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\WatchStore\WatchStore\_Imports.razor"
using WatchStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\WatchStore\WatchStore\_Imports.razor"
using WatchStore.Components;

#line default
#line hidden
#nullable disable
    public partial class ProductItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-sm-4 p-2");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex justify-content-center p-2");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "h5");
            __builder.AddAttribute(10, "class", "card-title");
            __builder.AddContent(11, 
#nullable restore
#line 5 "D:\WatchStore\WatchStore\Components\ProductItem.razor"
                                    Product.ImgUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "h5");
            __builder.AddAttribute(18, "class", "card-title");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/product/" + (
#nullable restore
#line 9 "D:\WatchStore\WatchStore\Components\ProductItem.razor"
                                   Product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, 
#nullable restore
#line 9 "D:\WatchStore\WatchStore\Components\ProductItem.razor"
                                                Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "card-text");
            __builder.AddContent(26, 
#nullable restore
#line 10 "D:\WatchStore\WatchStore\Components\ProductItem.razor"
                                  Product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "text-secondary text-center h2 font-weight-bold");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.AddContent(31, 
#nullable restore
#line 12 "D:\WatchStore\WatchStore\Components\ProductItem.razor"
                 Product.Price.ToString("C")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.AddMarkupContent(34, "<a href=\"#\" class=\"btn btn-danger w-100\"><i class></i> Add to card</a>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\WatchStore\WatchStore\Components\ProductItem.razor"
       
    [Parameter]
    public Product Product { get; set; }
  



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
