#pragma checksum "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3666da6d8b16d3b03f2b90cbcb98e00f4f65bad"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventary.Component.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Inventary\Inventary\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Inventary\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Inventary\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Inventary\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Inventary\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Inventary\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Inventary\Inventary\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Inventary\Inventary\_Imports.razor"
using Inventary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Inventary\Inventary\_Imports.razor"
using Inventary.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Inventary\Inventary\_Imports.razor"
using Inventary.Component.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Inventary\Inventary\_Imports.razor"
using Inventary.Component.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Inventary\Inventary\_Imports.razor"
using Inventary.Component.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Inventary\Inventary\_Imports.razor"
using Inventary.Component.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Inventary\Inventary\_Imports.razor"
using Inventary.Component.Warehouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Inventary\Inventary\_Imports.razor"
using Inventary.Component.Storages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Inventary\Inventary\_Imports.razor"
using Inventary.Component.InOuts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListProductsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
                                        CategoryChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "option");
            __builder.AddAttribute(6, "value", true);
            __builder.AddContent(7, "Selecciones Categoria...");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 7 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
     foreach (var category in categories)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 9 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
                        category.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 9 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
                                              category.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 10 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table table-hover table-bordered");
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.AddMarkupContent(19, "<thead>\r\n        <tr>\r\n            <th>Referencia</th>\r\n            <th>Nombre Producto</th>\r\n            <th>Categoria</th>\r\n            <th>Cantidad</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(20, "tbody");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 25 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
         foreach (var product in tempProducts)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 28 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
                 product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 29 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
                 product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 30 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
                 product.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 31 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
                 product.TotalQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "product/update/" + (
#nullable restore
#line 32 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
                                         product.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 34 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n");
            __builder.AddContent(46, 
#nullable restore
#line 38 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
 message

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\Inventary\Inventary\Component\Products\ListProductsComponent.razor"
       
    List<ProductEntity> products = new List<ProductEntity>();
    List<ProductEntity> tempProducts = new List<ProductEntity>();

    List<CategoryEntity> categories = new List<CategoryEntity>();

    string message;

    protected override async Task OnInitializedAsync()
    {

        products = B_Product.ProductList();
        tempProducts = products;
        categories = B_Category.CategoryList();
    }

    private void CategoryChanged(ChangeEventArgs e)
    {
        //en este caso e: sera el Id de categoria
        // message = e.Value.ToString();
        //filtramos la lista temporal, donde su categoryId sea la misma que escogaos en select
        tempProducts=products.Where(c => c.CategoryId == e.Value.ToString()).ToList();
       
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
