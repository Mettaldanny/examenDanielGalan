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
    public partial class Resumen : ContentPage
    {
        public Resumen(string user, string nombre, double pago)
        {            
            InitializeComponent();
            string usuario = BoxUsuario.ToString();
            BoxUsuario.Text = user;
            string nombreUsuario = BoxNombre.ToString();
            BoxNombre.Text = nombre;
            string cuota = BoxTotal.ToString();
            BoxTotal.Text = pago.ToString(); ;
        }
    }
}