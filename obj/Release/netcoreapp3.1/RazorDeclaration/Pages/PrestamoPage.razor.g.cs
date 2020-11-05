#pragma checksum "C:\Aplicada2\PrestamoBlazor\Pages\PrestamoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e8088fa5d5a199031dc3e45c5c8a56ebcb0b9e0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PrestamoBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Aplicada2\PrestamoBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicada2\PrestamoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicada2\PrestamoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aplicada2\PrestamoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Aplicada2\PrestamoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Aplicada2\PrestamoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Aplicada2\PrestamoBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Aplicada2\PrestamoBlazor\_Imports.razor"
using PrestamoBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Aplicada2\PrestamoBlazor\_Imports.razor"
using PrestamoBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Aplicada2\PrestamoBlazor\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Aplicada2\PrestamoBlazor\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aplicada2\PrestamoBlazor\Pages\PrestamoPage.razor"
using PrestamoBlazor.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Aplicada2\PrestamoBlazor\Pages\PrestamoPage.razor"
using PrestamoBlazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/prestamos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/prestamos/{PrestamosId:int}")]
    public partial class PrestamoPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Aplicada2\PrestamoBlazor\Pages\PrestamoPage.razor"
       

    Prestamos prestamo = new Prestamos();

    [Parameter]
    public int PrestamosId { get; set; }

    private List<Personas> listaPersona = new List<Personas>();



    protected override void OnInitialized()
    {
        Nuevo();
        if (PrestamosId > 0)
        {
            var auxPretamo = PrestamoBLL.Buscar(PrestamosId);
            if (auxPretamo != null)
                this.prestamo = auxPretamo;
            else
                toast.ShowWarning("No encontrado.");
        }

        listaPersona = PersonasBLL.GetList(p => true);
    }

    private void Buscar()
    {
        var encontrado = PrestamoBLL.Buscar(prestamo.PrestamoId);
        if (encontrado != null)
        {
            this.prestamo = encontrado;
        }
        else
            toast.ShowWarning("No encontrado");

    }


    private void IgualarMontoBalance()
    {
        decimal auxMonto = prestamo.Monto;
        prestamo.Balance = auxMonto;
    }

    private void Nuevo()
    {
        this.prestamo = new Prestamos();
    }


    private void Guardar()
    {
        bool paso;
        paso = PrestamoBLL.Guardar(prestamo);

        if (paso)
        {
            Nuevo();
            toast.ShowSuccess("Guardado correctamente");
        }
        else
        {
            toast.ShowError("No fue posible guardar");
        }

    }

    private void Eliminar()
    {
        bool elimino;

        elimino = PrestamoBLL.Eliminar(prestamo.PrestamoId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado correctamente");
        }
        else
            toast.ShowError("No fue posible eliminar");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
