// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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