#pragma checksum "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\Pages\PaginaPrincipal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0560eb78903ded49351eb9ca5a558edd8328b30"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea8_P3.Pages
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
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\Pages\PaginaPrincipal.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class PaginaPrincipal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section id=""hero"" class=""d-flex align-items-center""><div class=""container""><div class=""row""><div class=""col-lg-6 pt-4 pt-lg-0 order-2 order-lg-1 d-flex flex-column justify-content-center""><h1>Registro de personas, para ponerse la bacuna</h1>
                <h2>Esta es una página, la cuál está encargada de registrar personas, que recibirán su primera y segunda dosis de vacuna. También está encargada de consultar los mismo y poder filtrarlos de manera, en la cuál el usuario pueda saber y filtrar a sus pacientes.</h2></div>
            <div class=""col-lg-6 order-1 order-lg-2 hero-img""><img src=""assets/img/hero-img.png"" class=""img-fluid"" alt></div></div></div></section>

");
            __builder.AddMarkupContent(1, "<section id=\"about\" class=\"about\"><div class=\"container\"><div class=\"row\"><div class=\"col-xl-5 col-lg-6 d-flex justify-content-center video-box align-items-stretch\"><img src=\"assets/img/vacuna vertical.jpg\" class=\"img-fluid\" alt></div>\r\n\r\n            <div class=\"col-xl-7 col-lg-6 icon-boxes d-flex flex-column align-items-stretch justify-content-center py-5 px-lg-5\"><h3>Definición COVID-19</h3>\r\n                <p>La COVID-19 afecta de distintas maneras en función de cada persona. La mayoría de las personas que se contagian presentan síntomas de intensidad leve o moderada, y se recuperan sin necesidad de hospitalización.</p>\r\n\r\n                <div class=\"icon-box\"><h4>Los síntomas más habituales son los siguientes:</h4>\r\n                    <ul><li>Fiebre</li>\r\n                        <li>Tos seca</li>\r\n                        <li>Cansancio</li></ul></div>\r\n\r\n                <div class=\"icon-box\"><h4>Otros síntomas menos comunes son los siguientes:</h4>\r\n                    <ul><li>Molestias y dolores</li>\r\n                        <li>Dolor de garganta</li>\r\n                        <li>Diarrea</li>\r\n                        <li>Conjuntivitis</li>\r\n                        <li>Dolor de cabeza</li></ul></div>\r\n\r\n                <div class=\"icon-box\"><h4>Persistencia en superficies:</h4>\r\n                    <ul><li>Papel y pañuelos de papel**: 3 horas</li>\r\n                        <li>Cobre*: 4 horas</li>\r\n                        <li>Cartón*: 24 horas</li>\r\n                        <li>Madera**: 2 días</li>\r\n                        <li>Tela**: 2 días</li></ul></div></div></div></div></section>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
