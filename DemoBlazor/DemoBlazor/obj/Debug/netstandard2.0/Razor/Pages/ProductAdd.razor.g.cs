#pragma checksum "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3fc8136f80885c20301136ce5500a17609968373aeeaa95de40272659c82a58b"
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
#line 2 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
using DemoBlazor.Models;

#line default
#line hidden
#line 3 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
using DemoBlazor.Services;

#line default
#line hidden
#line 6 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
using DemoBlazor.Utilities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/productadd")]
    public partial class ProductAdd : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 8 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
 if (product != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "ProductDetail for ");
#line 10 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
__builder.AddContent(3, product.ProductName);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#line 11 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                      product

#line default
#line hidden
            )));
            __builder.AddAttribute(7, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 11 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
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
#line 15 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                                                                                  product.ProductName

#line default
#line hidden
                )));
                __builder2.AddAttribute(20, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductName = __value, product.ProductName)))));
                __builder2.AddAttribute(21, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.ProductName)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            ");
                global::__Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#line 16 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                      ()=>product.ProductName

#line default
#line hidden
                );
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "\r\n            ");
                global::__Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateInputNumber_1(__builder2, 30, 31, "Fiyat", 32, "form-control", 33, "description", 34, 
#line 19 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                                                                                 product.UnitPrice

#line default
#line hidden
                , 35, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.UnitPrice = __value, product.UnitPrice)), 36, () => product.UnitPrice);
                __builder2.AddMarkupContent(37, "\r\n            ");
                global::__Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateValidationMessage_2(__builder2, 38, 39, 
#line 20 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                      ()=>product.UnitPrice

#line default
#line hidden
                );
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(45);
                __builder2.AddAttribute(46, "Placeholder", (object)("Ürün açıklaması"));
                __builder2.AddAttribute(47, "Class", (object)("form-control"));
                __builder2.AddAttribute(48, "Id", (object)("description"));
                __builder2.AddAttribute(49, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#line 24 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                                                                                             product.QuantityPerUnit

#line default
#line hidden
                )));
                __builder2.AddAttribute(50, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.QuantityPerUnit = __value, product.QuantityPerUnit)))));
                __builder2.AddAttribute(51, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.QuantityPerUnit)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n            ");
                global::__Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateValidationMessage_3(__builder2, 53, 54, 
#line 25 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                      ()=>product.QuantityPerUnit

#line default
#line hidden
                );
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "\r\n");
#line 29 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
             if (categories != null)
            {

#line default
#line hidden
                __builder2.AddContent(60, "                ");
                global::__Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateInputSelectNumber_4(__builder2, 61, 62, "form-control", 63, "categoryId", 64, 
#line 31 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                                                                      product.CategoryId

#line default
#line hidden
                , 65, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.CategoryId = __value, product.CategoryId)), 66, () => product.CategoryId, 67, (__builder3) => {
                    __builder3.AddMarkupContent(68, "\r\n");
#line 32 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                     foreach (var category in categories)
                            {

#line default
#line hidden
                    __builder3.AddContent(69, "                        ");
                    __builder3.OpenElement(70, "option");
                    __builder3.AddAttribute(71, "value", 
#line 34 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                       category.CategoryId

#line default
#line hidden
                    );
#line 34 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
__builder3.AddContent(72, category.CategoryName);

#line default
#line hidden
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\r\n");
#line 35 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                            }

#line default
#line hidden
                    __builder3.AddMarkupContent(74, "                    /**/\r\n                    /**/\r\n                    /**/\r\n                    /**/\r\n                    /**/\r\n                ");
                }
                );
                __builder2.AddMarkupContent(75, "\r\n");
#line 42 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
            }

#line default
#line hidden
                __builder2.AddMarkupContent(76, "\r\n            ");
                global::__Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateValidationMessage_5(__builder2, 77, 78, 
#line 44 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                      ()=>product.CategoryId

#line default
#line hidden
                );
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n\r\n        ");
                __builder2.AddMarkupContent(81, "<button class=\"btn btn-primary\" type=\"submit\">Kaydet</button>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n");
#line 50 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(83, "    ");
            __builder.AddMarkupContent(84, "<h4>Geliyor...</h4>\r\n");
#line 54 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 57 "C:\Users\burak.cengiz.BELENCO\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
       

    Product product = new Product();
    Category[] categories;

    protected override async Task OnInitializedAsync()
    {
        categories = await CategoryService.GetCategories();
    }

    private void HandleSave()
    {
        ProductService.Add(product);
        Console.WriteLine("Ürün eklendi");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
namespace __Blazor.DemoBlazor.Pages.ProductAdd
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", (object)__arg0);
        __builder.AddAttribute(__seq1, "Class", (object)__arg1);
        __builder.AddAttribute(__seq2, "Id", (object)__arg2);
        __builder.AddAttribute(__seq3, "Value", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", (object)__arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", (object)__arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelectNumber_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
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
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
