using PortalModelo.Models;
using PortalModelo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortalModelo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Portales : ContentPage
    {
        public Portales()
        {
            InitializeComponent();
            mostrarPortales();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            await InsertarPortales();
        }

        private async Task InsertarPortales ()
        {
            VMPortales funcion = new VMPortales();
            MPortales parametros = new MPortales();
            parametros.Municipio = txtmunicipio.Text;
            parametros.Status = txtstatus.Text;
            parametros.Fecha = txtfecha.Text;
            parametros.Foto = "-";
            await funcion.insertar_portal(parametros);
            await DisplayAlert("Listo", "Portal Agregado", "OK");
            await mostrarPortales();

        }

        private async Task mostrarPortales ()
        {
            VMPortales funcion = new VMPortales();
            var mostrar = await funcion.mostrar_portales();
            listaPortales.ItemsSource = mostrar;
        }
    }
}