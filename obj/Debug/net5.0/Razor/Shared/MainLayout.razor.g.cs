#pragma checksum "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "def473f06b79796c3759910856b10067e65cc657"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea8_P3.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using Tarea8_P3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using Tarea8_P3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-gzhc9p0l3q");
            __builder.OpenComponent<Tarea8_P3.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "main");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddAttribute(8, "b-gzhc9p0l3q");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content");
            __builder.AddAttribute(11, "b-gzhc9p0l3q");
            __builder.AddMarkupContent(12, @"<nav class=""navbar navbar-expand-lg navbar-light bg-info"" b-gzhc9p0l3q><a class=""navbar-brand"" href style=""font-size:2rem;"" b-gzhc9p0l3q><img src=""https://www.biol.unlp.edu.ar/wp-content/uploads/2017/02/vaccine.png"" width=""50"" height=""50"" class=""d-inline-block align-top"" alt loading=""lazy"" b-gzhc9p0l3q>
                    <strong b-gzhc9p0l3q>Vacunados's Team</strong></a>
                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"" b-gzhc9p0l3q><ul class=""nav navbar-nav ml-auto"" b-gzhc9p0l3q><li class=""nav-item active"" style=""font-size:1.5rem;"" b-gzhc9p0l3q></li></ul></div></nav>

            <br b-gzhc9p0l3q>

            ");
            __builder.AddContent(13, 
#nullable restore
#line 26 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n\r\n            <br b-gzhc9p0l3q>\r\n\r\n            ");
            __builder.AddMarkupContent(15, "<footer class=\"site-footer\" b-gzhc9p0l3q><div class=\"container\" b-gzhc9p0l3q><div class=\"row\" b-gzhc9p0l3q><div class=\"col-sm-12 col-md-6\" b-gzhc9p0l3q><h6 b-gzhc9p0l3q>Sobre nosotros</h6>\r\n                            <p class=\"text-justify\" b-gzhc9p0l3q>\r\n                                Esta es una página, la cuál está encargada de registrar personas, que recibirán su primera y segunda dosis de vacuna. También está encargada de consultar los mismo y poder filtrarlos de manera, en la cuál el usuario pueda saber y filtrar a sus pacientes. Otra cosa que se puede hacer es anular los pacientes, de manera en que sí ese paciente recibió su primera dosis, esta pueda ser eliminada.\r\n                            </p></div>\r\n                        <div class=\"col-sm-12 col-md-6\" b-gzhc9p0l3q><h6 b-gzhc9p0l3q>Componentes Usados</h6>\r\n                            <p class=\"text-justify\" b-gzhc9p0l3q><ul b-gzhc9p0l3q><li b-gzhc9p0l3q>C#</li>\r\n                                    <li b-gzhc9p0l3q>CSS</li>\r\n                                    <li b-gzhc9p0l3q>HTML</li>\r\n                                    <li b-gzhc9p0l3q>Javascript</li>\r\n                                    <li b-gzhc9p0l3q>Sqlite</li></ul></p></div></div>\r\n                    <hr b-gzhc9p0l3q></div>\r\n                <div class=\"container\" b-gzhc9p0l3q><div class=\"row\" b-gzhc9p0l3q><div class=\"col-md-8 col-sm-6 col-xs-12\" b-gzhc9p0l3q><p class=\"copyright-text\" b-gzhc9p0l3q>\r\n                                Copyright &copy; 2021 All Rights Reserved by\r\n                                <a href=\"#\" b-gzhc9p0l3q>Vacunados</a>.\r\n                            </p></div>\r\n\r\n                        <div class=\"col-md-4 col-sm-6 col-xs-12\" b-gzhc9p0l3q><a class=\"navbar-brand\" target=\"_blank\" href=\"https://www.youtube.com/channel/UCnAQox3y2MbF8-yi9kJjuRA/videos?view_as=subscriberl\" b-gzhc9p0l3q><img src=\"Logos Redes Sociales/Youtube.png\" width=\"65\" height=\"65\" class=\"d-inline-block align-top\" alt=\"Logo Youtube\" loading=\"lazy\" b-gzhc9p0l3q></a>\r\n                            <a class=\"navbar-brand\" target=\"_blank\" href=\"https://www.facebook.com/gabrielernesto.delarosapaniagua/\" b-gzhc9p0l3q><img src=\"Logos Redes Sociales/Facebook.png\" width=\"65\" height=\"65\" class=\"d-inline-block align-top\" alt=\"Logo Facebook\" loading=\"lazy\" b-gzhc9p0l3q></a>\r\n                            <a class=\"navbar-brand\" target=\"_blank\" href=\"https://www.instagram.com/gabriel_7729/\" b-gzhc9p0l3q><img src=\"Logos Redes Sociales/Instagram.png\" width=\"65\" height=\"65\" class=\"d-inline-block align-top\" alt=\"Logo Instagram\" loading=\"lazy\" b-gzhc9p0l3q></a>\r\n                            <a class=\"navbar-brand\" target=\"_blank\" href=\"https://twitter.com/Lusan7729?s=09\" b-gzhc9p0l3q><img src=\"Logos Redes Sociales/Twitter.png\" width=\"65\" height=\"65\" class=\"d-inline-block align-top\" alt=\"Logo Twitter\" loading=\"lazy\" b-gzhc9p0l3q></a></div></div></div></footer>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
