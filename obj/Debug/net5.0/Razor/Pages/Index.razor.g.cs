#pragma checksum "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a44506dd3969cdc1ef80324062ec383ce71e031"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea8_P3.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Tarea8_P3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Tarea8_P3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row bg-light");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-bordered");
            __builder.AddMarkupContent(6, @"<thead class=""thead-dark""><tr><th>Id</th>
                    <th>Nombres</th>
                    <th>Apellido</th>
                    <th>Telefono</th>
                    <th>Fecha de nacimiento</th>
                    <th>Tipo de vacuna</th>
                    <th>Fecha dosis 1</th>
                    <th>Fecha dosis 2</th>
                    <th>Provincia</th>
                    <th>Provincia</th></tr></thead>
            ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 24 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                 if (Products.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                     foreach (var product in Products)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                      (() => SetProductForUpdate(product))

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 29 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                 product.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                 product.nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                 product.apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 32 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                 product.telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 33 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                 product.fechaNacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 34 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                 product.tipoVacuna

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 35 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                 product.fecahDosis1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 36 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                 product.fecahDosis2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 37 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                 product.provincia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-danger");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                         (() => DeleteProduct(product))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                      }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "<tr><td colspan=\"6\"><strong>No products available</strong></td></tr>");
#nullable restore
#line 44 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row m-5");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-5 bg-light m-2 justify-content-start");
            __builder.AddMarkupContent(48, "<div class=\"p-3 mb-3 bg-primary text-white text-center\">Add New Product</div>\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(49);
            __builder.AddAttribute(50, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 54 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                              NewProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddMarkupContent(54, "<label for=\"name\">Nombre</label>\r\n                    ");
                __builder2.OpenElement(55, "input");
                __builder2.AddAttribute(56, "type", "text");
                __builder2.AddAttribute(57, "id", "name");
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                                    NewProduct.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProduct.nombre = __value, NewProduct.nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n                ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __builder2.AddMarkupContent(64, "<label for=\"price\">Apellido</label>\r\n                    ");
                __builder2.OpenElement(65, "input");
                __builder2.AddAttribute(66, "type", "text");
                __builder2.AddAttribute(67, "id", "price");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                               NewProduct.apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProduct.apellido = __value, NewProduct.apellido));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n                ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "<label for=\"quantity\">Telefono</label>\r\n                    ");
                __builder2.OpenElement(75, "input");
                __builder2.AddAttribute(76, "type", "text");
                __builder2.AddAttribute(77, "id", "quantity");
                __builder2.AddAttribute(78, "class", "form-control");
                __builder2.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                                  NewProduct.telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProduct.telefono = __value, NewProduct.telefono));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n                ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group");
                __builder2.AddMarkupContent(84, "<label for=\"Description\">Fecha de nacimiento</label>\r\n                    ");
                __builder2.OpenElement(85, "input");
                __builder2.AddAttribute(86, "type", "text");
                __builder2.AddAttribute(87, "id", "Description");
                __builder2.AddAttribute(88, "class", "form-control");
                __builder2.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                                     NewProduct.fechaNacimiento

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProduct.fechaNacimiento = __value, NewProduct.fechaNacimiento));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group");
                __builder2.AddMarkupContent(94, "<label for=\"Description\">Tipo de vacuna</label>\r\n                    ");
                __builder2.OpenElement(95, "input");
                __builder2.AddAttribute(96, "type", "text");
                __builder2.AddAttribute(97, "id", "Description");
                __builder2.AddAttribute(98, "class", "form-control");
                __builder2.AddAttribute(99, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                                     NewProduct.tipoVacuna

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProduct.tipoVacuna = __value, NewProduct.tipoVacuna));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-group");
                __builder2.AddMarkupContent(104, "<label for=\"Description\">Fecha Dosis 1</label>\r\n                    ");
                __builder2.OpenElement(105, "input");
                __builder2.AddAttribute(106, "type", "text");
                __builder2.AddAttribute(107, "id", "Description");
                __builder2.AddAttribute(108, "class", "form-control");
                __builder2.AddAttribute(109, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                                     NewProduct.fecahDosis1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProduct.fecahDosis1 = __value, NewProduct.fecahDosis1));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-group");
                __builder2.AddMarkupContent(114, "<label for=\"Description\">Fecha Dosis 2</label>\r\n                    ");
                __builder2.OpenElement(115, "input");
                __builder2.AddAttribute(116, "type", "text");
                __builder2.AddAttribute(117, "id", "Description");
                __builder2.AddAttribute(118, "class", "form-control");
                __builder2.AddAttribute(119, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 84 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                                     NewProduct.fecahDosis2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(120, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProduct.fecahDosis2 = __value, NewProduct.fecahDosis2));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n\r\n                ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "text-center p-3 mb-3");
                __builder2.OpenElement(124, "button");
                __builder2.AddAttribute(125, "class", "btn btn-info");
                __builder2.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                           AddNewProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(127, " Add Product");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n\r\n        ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "col-5 bg-light m-2 justify-content-end");
            __builder.AddMarkupContent(131, "<div class=\"p-3 mb-1 bg-primary text-white text-center\">Update Product</div>\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(132);
            __builder.AddAttribute(133, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 96 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                              UpdateProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(135, "div");
                __builder2.AddAttribute(136, "class", "form-group");
                __builder2.AddMarkupContent(137, "<label for=\"name\">Product Name</label>\r\n                    ");
                __builder2.OpenElement(138, "input");
                __builder2.AddAttribute(139, "type", "text");
                __builder2.AddAttribute(140, "id", "name");
                __builder2.AddAttribute(141, "class", "form-control");
                __builder2.AddAttribute(142, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                                    UpdateProduct.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(143, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateProduct.nombre = __value, UpdateProduct.nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n\r\n                ");
                __builder2.OpenElement(145, "div");
                __builder2.AddAttribute(146, "class", "form-group");
                __builder2.AddMarkupContent(147, "<label for=\"price\">Price</label>\r\n                    ");
                __builder2.OpenElement(148, "input");
                __builder2.AddAttribute(149, "type", "text");
                __builder2.AddAttribute(150, "id", "price");
                __builder2.AddAttribute(151, "class", "form-control");
                __builder2.AddAttribute(152, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 104 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                               UpdateProduct.apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(153, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateProduct.apellido = __value, UpdateProduct.apellido));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n\r\n                ");
                __builder2.OpenElement(155, "div");
                __builder2.AddAttribute(156, "class", "form-group");
                __builder2.AddMarkupContent(157, "<label for=\"quantity\">Quantity</label>\r\n                    ");
                __builder2.OpenElement(158, "input");
                __builder2.AddAttribute(159, "type", "text");
                __builder2.AddAttribute(160, "id", "quantity");
                __builder2.AddAttribute(161, "class", "form-control");
                __builder2.AddAttribute(162, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 109 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                                  UpdateProduct.telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(163, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateProduct.telefono = __value, UpdateProduct.telefono));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\r\n\r\n                ");
                __builder2.OpenElement(165, "div");
                __builder2.AddAttribute(166, "class", "form-group");
                __builder2.AddMarkupContent(167, "<label for=\"Description\">Description</label>\r\n                    ");
                __builder2.OpenElement(168, "input");
                __builder2.AddAttribute(169, "type", "text");
                __builder2.AddAttribute(170, "id", "Description");
                __builder2.AddAttribute(171, "class", "form-control");
                __builder2.AddAttribute(172, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 114 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                                     UpdateProduct.tipoVacuna

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(173, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateProduct.tipoVacuna = __value, UpdateProduct.tipoVacuna));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n                ");
                __builder2.OpenElement(175, "div");
                __builder2.AddAttribute(176, "class", "form-group");
                __builder2.AddMarkupContent(177, "<label for=\"Description\">Description</label>\r\n                    ");
                __builder2.OpenElement(178, "input");
                __builder2.AddAttribute(179, "type", "text");
                __builder2.AddAttribute(180, "id", "Description");
                __builder2.AddAttribute(181, "class", "form-control");
                __builder2.AddAttribute(182, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 118 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                                                     UpdateProduct.provincia

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(183, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateProduct.provincia = __value, UpdateProduct.provincia));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\r\n\r\n                ");
                __builder2.OpenElement(185, "div");
                __builder2.AddAttribute(186, "class", "text-center p-3 mb-3");
                __builder2.OpenElement(187, "button");
                __builder2.AddAttribute(188, "class", "btn btn-info");
                __builder2.AddAttribute(189, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
                                                           UpdateProductData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(190, " Update Product");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\Index.razor"
        List<vacunados> Products = new List<vacunados>();

    protected override async Task OnInitializedAsync()
    {
        await RefreshProducts();
    }

    private async Task RefreshProducts()
    {
        Products = await service.GetProductAsync();
    }


    public vacunados NewProduct { get; set; } = new vacunados();

    private async Task AddNewProduct()
    {
        await service.AddProductAsync(NewProduct);
        NewProduct = new vacunados();
        await RefreshProducts();
    }

    vacunados UpdateProduct = new vacunados();

    private void SetProductForUpdate(vacunados product)
    {
        UpdateProduct = product;
    }

    private async Task UpdateProductData()
    {
        await service.UpdateProductAsync(UpdateProduct);
        await RefreshProducts();
    }

    private async Task DeleteProduct(vacunados product)
    {
        await service.DeleteProductAsync(product);
        await RefreshProducts();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private vacunadosServices service { get; set; }
    }
}
#pragma warning restore 1591
