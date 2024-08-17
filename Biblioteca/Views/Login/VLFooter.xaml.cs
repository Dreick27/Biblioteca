using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biblioteca.Views.Home
namespace Biblioteca.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VLFooter : ContentView
    {
        public VLFooter()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = "admin";
            string pass = "admin";

            string usuario_ingresado=txtvalor1.Text;
            string contrasenia_ingresado = txtvalor2.Text;
            if (usuario == usuario_ingresado && pass == contrasenia_ingresado)
            {
                await Navigation.PushModalAsync(new VHPrincipal());
            }
            else
            {
                lblResultado.Text = "Credenciales Incorrectos";
            }
        }
    }
}