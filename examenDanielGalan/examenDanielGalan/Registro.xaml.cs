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
        public Registro(string user)
        {
            InitializeComponent();
            
            
        }

        private async void btnPago_Clicked(object sender, EventArgs e)
        {
            string usuario = lblUser.Text;

            string nombre = BoxUsuario.Text;
            
            double cuota = 1800 - Convert.ToDouble(BoxMonto.Text);

            double mensual = cuota / 3 ;            

            double pago = mensual + mensual * 0.05;

            BoxPago.Text = pago.ToString();

            double total = cuota + pago*3;

            await Navigation.PushAsync(new Resumen(usuario, nombre, total));
            DisplayAlert("Informacion", "Elemento guardado con exito", "OK");

        }
    }
}