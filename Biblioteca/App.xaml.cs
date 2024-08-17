using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biblioteca.Views.Home;
using Biblioteca.Views.Product;
using Biblioteca.Views.Login;

namespace Biblioteca
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new VHPrincipal());
            //MainPage = new VPPrincipal();
            MainPage = new VLPrincipal();
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
