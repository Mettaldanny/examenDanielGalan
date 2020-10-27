using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace examenDanielGalan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string user, string pass)
        {
            InitializeComponent();
        }

        private async void btnPago_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resumen());
            DisplayAlert("Informacion", "Elemento guardado con exito", "OK");

        }
    }
}