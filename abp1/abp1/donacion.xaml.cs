using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace abp1
{
    public partial class Donacion : ContentPage
    {
        public Donacion()
        {
            InitializeComponent();
            CargarDatosGuardados();
        }

        private void OnAceptarClicked(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string nombre = NombreEntry.Text;
            string tarjeta = TarjetaEntry.Text;
            DateTime expiracion = FechaExpiracionPicker.Date;
            string cvv = CVVEntry.Text;
            string monto = MontoEntry.Text;

            // Guardar en Preferences
            Preferences.Set("nombre", nombre);
            Preferences.Set("tarjeta", tarjeta);
            Preferences.Set("expiracion", expiracion.ToString("MM/yyyy"));
            Preferences.Set("cvv", cvv);
            Preferences.Set("monto", monto);

            // Confirmación simple
            DisplayAlert("Éxito", "Datos guardados correctamente", "OK");
        }

        private void CargarDatosGuardados()
        {
            if (Preferences.ContainsKey("nombre"))
                NombreEntry.Text = Preferences.Get("nombre", string.Empty);

            if (Preferences.ContainsKey("tarjeta"))
                TarjetaEntry.Text = Preferences.Get("tarjeta", string.Empty);

            if (Preferences.ContainsKey("expiracion"))
            {
                string expiracionString = Preferences.Get("expiracion", string.Empty);
                if (DateTime.TryParseExact("01/" + expiracionString, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                {
                    FechaExpiracionPicker.Date = fecha;
                }
            }

            if (Preferences.ContainsKey("cvv"))
                CVVEntry.Text = Preferences.Get("cvv", string.Empty);

            if (Preferences.ContainsKey("monto"))
                MontoEntry.Text = Preferences.Get("monto", "$500");
        }
        private async void OnAgradecimientoTapped(object sender, EventArgs e)
        {
            // Abre la página del evento
            await Navigation.PushAsync(new Agradecimiento());
        }
    }
}
