#pragma checksum "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "08a99dd9055ff75f9fbe330c1859e8cb64d222df375fb81456080f45a45ee12d"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoBlazor.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#line 1 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using DemoBlazor;

#line default
#line hidden
#line 7 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using DemoBlazor.Shared;

#line default
#line hidden
#line 2 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#line 3 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
using Blazor.Extensions.Storage;

#line default
#line hidden
#line 4 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
using DemoBlazor.Models;

#line default
#line hidden
#line 5 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
using DemoBlazor.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/productlist")]
    public partial class ProductList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ProductList</h3>\r\n");
#line 13 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
 if (products == null)
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Loading...</p>\r\n");
#line 16 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Product Id</th>\r\n                <th>Product Name</th>\r\n                <th>Unit Price</th>\r\n                <th>Units In Stock</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#line 30 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
             foreach (var product in products)
            {

#line default
#line hidden
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#line 33 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
__builder.AddContent(14, product.ProductId);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#line 34 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
__builder.AddContent(17, product.ProductName);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
#line 35 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
__builder.AddContent(20, product.UnitPrice);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
#line 36 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
__builder.AddContent(23, product.UnitsInStock);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(28, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 37 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
                                                                           () => GoToDetail(product.ProductId)

#line default
#line hidden
            ));
            __builder.AddContent(29, "Detaya Git");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#line 39 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
            }

#line default
#line hidden
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#line 42 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 44 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductList.razor"
       
    Product[] products;

    protected override async Task OnInitializedAsync()
    {

        if (!Http.DefaultRequestHeaders.Contains("Authorization"))
        {
            var token = await LocalStorage.GetItem<string>("token");
            Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        }
        products = await ProductService.GetProducts();
    }

    void GoToDetail(int productId)
    {
        NavigationManager.NavigateTo("/productdetail/" + productId);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalStorage LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591