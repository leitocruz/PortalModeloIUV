using PortalModelo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortalModelo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Portales();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
