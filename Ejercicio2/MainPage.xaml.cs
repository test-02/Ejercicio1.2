using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btninformacion_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) || string.IsNullOrWhiteSpace(apellidos.Text)
                || string.IsNullOrWhiteSpace(edad.Text) || string.IsNullOrWhiteSpace(correo.Text))
            {
                await DisplayAlert("Aviso", "Debe llenar todos los campos", "Ok");
            }
            else
            {
                var estudiante = new Models.Persona()
                {
                    Nombre = nombre.Text,
                    Apellidos = apellidos.Text,
                    Edad = edad.Text,
                    Correo = correo.Text,
                };

                var paginaSegunda = new Views.Informacion
                {
                    BindingContext = estudiante
                };
                LimpiarCampos();
                await Navigation.PushAsync(paginaSegunda);
            }
        }

        private void LimpiarCampos()
        {
            nombre.Text = "";
            apellidos.Text = "";
            edad.Text = "";
            correo.Text = "";
        }
    }
}
