#pragma checksum "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4a35da49dd4a46a9c0e1199feae671710dfc37e"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventary.Component.InOuts
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
#line 1 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class CreateInOutComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "class", "form-control");
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
                                            OnChangeWareHouse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", true);
            __builder.AddContent(9, "Selecciones una bondega..");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 7 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
         foreach (var warehouse in warehouses)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 9 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
                            warehouse.WarehouseId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, 
#nullable restore
#line 9 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
                                                    warehouse.WarehouseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 10 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n<hr>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(19);
            __builder.AddAttribute(20, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
                 InOut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __Blazor.Inventary.Component.InOuts.CreateInOutComponent.TypeInference.CreateInputSelect_0(__builder2, 26, 27, "form-control", 28, 
#nullable restore
#line 18 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
                                                        InOut.StorageId

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InOut.StorageId = __value, InOut.StorageId)), 30, () => InOut.StorageId, 31, (__builder3) => {
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.AddMarkupContent(33, "<option value>Selecciones un producto..</option>\r\n");
#nullable restore
#line 20 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
             foreach (var storage in storages)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(34, "                ");
                    __builder3.OpenElement(35, "option");
                    __builder3.AddAttribute(36, "value", 
#nullable restore
#line 22 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
                                storage.StorageId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(37, 
#nullable restore
#line 22 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
                                                    storage.Product.ProductName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\r\n");
#nullable restore
#line 23 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(39, "\r\n        ");
                }
                );
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.AddMarkupContent(45, "<label>Escriba Cantidad</label>\r\n        ");
                __Blazor.Inventary.Component.InOuts.CreateInOutComponent.TypeInference.CreateInputNumber_1(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 29 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
                                                        InOut.Quantity

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InOut.Quantity = __value, InOut.Quantity)), 50, () => InOut.Quantity);
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.AddMarkupContent(56, "<label>Es una entrada?</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(57);
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
                                                          InOut.IsInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InOut.IsInput = __value, InOut.IsInput))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => InOut.IsInput));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n    ");
                __builder2.OpenElement(64, "input");
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "type", "button");
                __builder2.AddAttribute(67, "value", 
#nullable restore
#line 36 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
                                                      buttonValue

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
                                                                             SaveInOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n\r\n");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "text-center h4");
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.AddContent(74, 
#nullable restore
#line 40 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
     message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(75, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\Inventary\Inventary\Component\InOuts\CreateInOutComponent.razor"
       
    InOutEntity InOut = new InOutEntity();
    //Lista de bido a las relaciones de las tables
    List<WarehouseEntity> warehouses = new List<WarehouseEntity>();
    List<StorageEntity> storages = new List<StorageEntity>();

    ProductEntity product = new ProductEntity();
    StorageEntity storage = new StorageEntity();
    //is isOut is true mostrara RegistrarEntreda else RegistrarSalida
    string buttonValue => InOut.IsInput ? "Registrar entrada" : "Registrar salida";

    string message;

    protected override async Task OnInitializedAsync()
    {
        warehouses = B_Warehouse.WarehouseList();
    }

    private void OnChangeWareHouse(ChangeEventArgs e)
    {
        //el 'e' traera el id, por q ese es el value
        var idWareHouse = e.Value.ToString();

        //llamamos la estorage segun el id (porque cada bodega tiene unos productos especificos)

        storages = B_Storage.StorageProductByWarehouse(idWareHouse);
    }

    private void SaveInOut()
    {
        //llamamos a la bodega y el producto del InOut
        storage = storages.LastOrDefault(s => s.StorageId == InOut.StorageId);
        product = storage.Product;



        if (InOut.IsInput)
        {
            storage.PartialQuantity = storage.PartialQuantity + InOut.Quantity;
            B_Storage.UpdateStorage(storage);

            product.TotalQuantity = product.TotalQuantity + InOut.Quantity;
            B_Product.UpdateProduct(product);

            message = "El producto " + product.ProductName+" ha sido actualizad";
        }
        else
        {
            //hacemos esto para que no quede valores negativos
            if (isBiggerThanZero(InOut.Quantity,storage.PartialQuantity))
            {
                storage.PartialQuantity = storage.PartialQuantity - InOut.Quantity;
                B_Storage.UpdateStorage(storage);

                product.TotalQuantity = product.TotalQuantity - InOut.Quantity;
                B_Product.UpdateProduct(product);
                message = "El producto " + product.ProductName + " ha sido actualizad";

            }
            else
            {
                message = "No existe la cantidad sufciente para  " + product.ProductName;

            }

        }
    }

    private bool isBiggerThanZero(int quantity, int storageQuantity)
    {
        if (storageQuantity>quantity)
        {
            return true;
        }
        return false;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Inventary.Component.InOuts.CreateInOutComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591