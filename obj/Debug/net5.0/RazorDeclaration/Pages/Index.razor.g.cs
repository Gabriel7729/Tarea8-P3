// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
