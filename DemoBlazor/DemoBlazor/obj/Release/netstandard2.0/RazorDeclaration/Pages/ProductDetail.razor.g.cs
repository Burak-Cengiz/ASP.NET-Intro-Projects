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
#line 2 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
using DemoBlazor.Models;

#line default
#line hidden
#line 3 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
using DemoBlazor.Services;

#line default
#line hidden
#line 7 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
using DemoBlazor.Utilities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/productdetail/{productid:int}")]
    public partial class ProductDetail : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 53 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
       
    [Parameter]
    public int ProductId { get; set; }

    Product product;
    Category[] categories;

    protected override async Task OnInitializedAsync()
    {
        product = await ProductService.GetProductById(ProductId);
        categories = await CategoryService.GetCategories();
    }

    private void HandleSave()
    {
        ProductService.Save(product);
        Console.WriteLine("Ürün eklendi");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
