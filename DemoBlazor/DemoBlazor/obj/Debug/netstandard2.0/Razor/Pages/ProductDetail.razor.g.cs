#pragma checksum "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74fd80f269d3139b5192fa7631a319063125154b1a188d3075ccfb68247c36b0"
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
#line 11 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
 if (product != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "ProductDetail for ");
#line 13 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
__builder.AddContent(3, product.ProductName);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#line 14 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
                      product

#line default
#line hidden
            )));
            __builder.AddAttribute(7, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 14 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
                                               HandleSave

#line default
#line hidden
            ))));
            __builder.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "Placeholder", (object)("Ürün adı"));
                __builder2.AddAttribute(17, "Class", (object)("form-control"));
                __builder2.AddAttribute(18, "Id", (object)("productName"));
                __builder2.AddAttribute(19, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#line 18 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
                                                                                                  product.ProductName

#line default
#line hidden
                )));
                __builder2.AddAttribute(20, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductName = __value, product.ProductName)))));
                __builder2.AddAttribute(21, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.ProductName)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            ");
                global::__Blazor.DemoBlazor.Pages.ProductDetail.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#line 19 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
                                      ()=>product.ProductName

#line default
#line hidden
                );
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(30);
                __builder2.AddAttribute(31, "Placeholder", (object)("Ürün açıklaması"));
                __builder2.AddAttribute(32, "Class", (object)("form-control"));
                __builder2.AddAttribute(33, "Id", (object)("description"));
                __builder2.AddAttribute(34, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#line 23 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
                                                                                                             product.QuantityPerUnit

#line default
#line hidden
                )));
                __builder2.AddAttribute(35, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.QuantityPerUnit = __value, product.QuantityPerUnit)))));
                __builder2.AddAttribute(36, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.QuantityPerUnit)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n            ");
                global::__Blazor.DemoBlazor.Pages.ProductDetail.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#line 24 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
                                      ()=>product.QuantityPerUnit

#line default
#line hidden
                );
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n");
#line 28 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
             if (categories != null)
            {

#line default
#line hidden
                __builder2.AddContent(45, "                ");
                global::__Blazor.DemoBlazor.Pages.ProductDetail.TypeInference.CreateInputSelectNumber_2(__builder2, 46, 47, "form-control", 48, "categoryId", 49, 
#line 30 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
                                                                                      product.CategoryId

#line default
#line hidden
                , 50, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.CategoryId = __value, product.CategoryId)), 51, () => product.CategoryId, 52, (__builder3) => {
                    __builder3.AddMarkupContent(53, "\r\n");
#line 31 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
                     foreach (var category in categories)
                            {

#line default
#line hidden
                    __builder3.AddContent(54, "                        ");
                    __builder3.OpenElement(55, "option");
                    __builder3.AddAttribute(56, "value", 
#line 33 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
                                       category.CategoryId

#line default
#line hidden
                    );
#line 33 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
__builder3.AddContent(57, category.CategoryName);

#line default
#line hidden
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\r\n");
#line 34 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
                            }

#line default
#line hidden
                    __builder3.AddMarkupContent(59, "                    /**/\r\n                    /**/\r\n                ");
                }
                );
                __builder2.AddMarkupContent(60, "\r\n");
#line 38 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
            }

#line default
#line hidden
                __builder2.AddMarkupContent(61, "\r\n            ");
                global::__Blazor.DemoBlazor.Pages.ProductDetail.TypeInference.CreateValidationMessage_3(__builder2, 62, 63, 
#line 40 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
                                      ()=>product.CategoryId

#line default
#line hidden
                );
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n        ");
                __builder2.AddMarkupContent(66, "<button class=\"btn btn-primary\" type=\"submit\">Kaydet</button>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n");
#line 46 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(68, "    ");
            __builder.AddMarkupContent(69, "<h4>Geliyor...</h4>\r\n");
#line 50 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductDetail.razor"
}

#line default
#line hidden
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
namespace __Blazor.DemoBlazor.Pages.ProductDetail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelectNumber_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::DemoBlazor.Utilities.InputSelectNumber<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", (object)__arg0);
        __builder.AddAttribute(__seq1, "Id", (object)__arg1);
        __builder.AddAttribute(__seq2, "Value", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", (object)__arg4);
        __builder.AddAttribute(__seq5, "ChildContent", (object)__arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
