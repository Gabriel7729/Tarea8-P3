// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea8_P3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 2 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\Pages\RegistrarVacuna.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\Pages\RegistrarVacuna.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\Pages\RegistrarVacuna.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegistrarVacuna")]
    public partial class RegistrarVacuna : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea8-P3\Pages\RegistrarVacuna.razor"
       

    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public int IDCategoria { get; set; }
        public string IdSexo { get; set; }
        public string IdEstadoCivil { get; set; }
        public int IdOcupacion { get; set; }
        public int IDNacionalidad { get; set; }
        public int IDMunicipio { get; set; }
        public int IDColegio { get; set; }
        public object IDCausaCancelacion { get; set; }
        public string IDEstatus { get; set; }
        public object EstatusCedulaAzul { get; set; }
        public object CedulaAnterior { get; set; }
        public string mun_ced { get; set; }
        public string seq_ced { get; set; }
        public string ver_ced { get; set; }
        public object V2004 { get; set; }
        public object V2008 { get; set; }
        public object V2012 { get; set; }
        public object V2016 { get; set; }
        public object PLD { get; set; }
        public object PRD { get; set; }
        public object PRSC { get; set; }
        public object PRM { get; set; }
        public object Multiplicador_NombreCompleto { get; set; }
        public object Multiplicador_Cedula { get; set; }
        public object Simpatia_Descripcion { get; set; }
        public object Ilocalizable { get; set; }
        public object Apodo { get; set; }
        public object PadronLF { get; set; }
        public bool ok { get; set; }
        public string foto { get; set; }
    }

    bool consulta = false;
    bool existe = false;
    bool vc2 = false;
    bool tieneLas2 = false;
    bool BotonAgregar = false;

    String cedula;
    String tipoDeVacuna = "-- Sin seleccionar --";
    String provincia = "-- Sin seleccionar --";
    DateTime fechaDosis1;
    long telefono;
    
    int VacA;
    int VacB;
    int  VacC;


    //Registrados
    String FechaD1Registrado;
    long TelefonoR;
    String vacunaTipoR;
    bool registroAgregado;

    //Segunda fecha
    DateTime fechaDosis2;

    Persona resultado = null;
    String ced;


    static readonly HttpClient http = new HttpClient();

    async Task dosis2()
    {
        vc2 = true;
        existe = false;
        resultado = await http.GetFromJsonAsync<Persona>("https://api.adamix.net/apec/cedula/" + cedula);
        string fecha = fechaDosis2.ToString("dd/MM/yyyy");

        //Verifica si esta cedula esta registrada
        foreach (var data in Products)
        {
            if (cedula == data.Id)
            {
                SetProductForUpdate(data);
                UpdateProduct.fecahDosis2 = fecha;
                UpdateProductData();
                return;
            }
        }

    }

    async Task buscarPersona()
    {
        resultado = await http.GetFromJsonAsync<Persona>("https://api.adamix.net/apec/cedula/" + cedula);

        registroAgregado = false;
        //Verifica si esta cedula esta registrada
        foreach (var data in Products)
        {
            if(cedula == data.Id)
            {
                if(data.fecahDosis2 != "Sin recibir")
                {
                    tieneLas2 = true;
                    return;
                }
                existe = true;
                FechaD1Registrado = data.fecahDosis1;
                vacunaTipoR = data.tipoVacuna;
                TelefonoR = data.telefono;
                SetProductForUpdate(data);
                UpdateProductData();
                return;
            }
        }



        //fin veridicacion

        if (resultado.ok)
        {
            consulta = true;
        }
        else
        {
            ced = "Cedula no encontrada";
        }

    }

    public void tipoVacuna(ChangeEventArgs e)
    {
        tipoDeVacuna = e.Value.ToString();
    }
    public void provincias(ChangeEventArgs e)
    {
        provincia = e.Value.ToString();
    }

    public void nuevoVacunado()
    {
        registroAgregado = true;
        string fecha = fechaDosis1.ToString("dd/MM/yyyy");
        NewProduct.nombre = resultado.Nombres;
        NewProduct.apellido = resultado.Apellido1 + " " + resultado.Apellido2;
        NewProduct.fechaNacimiento = resultado.FechaNacimiento;
        NewProduct.tipoVacuna = tipoDeVacuna;
        NewProduct.provincia = provincia;
        NewProduct.fecahDosis1 = fecha;
        NewProduct.fecahDosis2 = "Sin recibir";
        NewProduct.telefono = telefono;
        NewProduct.Id = cedula;
        AddNewProduct();
        consulta = false;
        cedula = "";
    }

    //Agregar,Altualizar

    List<vacunados>
    Products = new List<vacunados>
        ();

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
        BotonAgregar = false;
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
