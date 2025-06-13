using System;
using Xamarin.Forms;

namespace abp1
{
    public partial class omitir : ContentPage
    {
        public omitir()
        {
            InitializeComponent();
        }

        private async void OnEvento_vistaTapped(object sender, EventArgs e)
        {
            // Abre la página del evento
            await Navigation.PushAsync(new Evento_vista());
        }
        private async void OnMeta_donacionespped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Meta_donaciones());
        }

        private async void OnEventos_donarTapped(object sender, EventArgs e)
        {
            // Abre la página del evento
            await Navigation.PushAsync(new Eventos_donar());
        }
        private async void OntrofeosTapped(object sender, EventArgs e)
        {
            // Abre la página del evento
            DisplayAlert("no tienes una sesion activa", "porfavor iniciar sesion para acceder a esta funcion", "OK");
        }
        private async void OnperfilTapped(object sender, EventArgs e)
        {
            DisplayAlert("no tienes una sesion activa", "porfavor iniciar sesion para acceder a esta funcion", "OK");
        }
        private async void OnNotificacionesTapped(object sender, EventArgs e)
        {
            DisplayAlert("no tienes una sesion activa", "porfavor iniciar sesion para acceder a esta funcion", "OK");
        }
        private async void OnBusquedaTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new buscador());
        }
        private async void OnAgregareventoPage(object sender, EventArgs e)
        {
            DisplayAlert("no tienes una sesion activa", "porfavor iniciar sesion para acceder a esta funcion", "OK");
        }
        private async void OnTuEventoPage(object sender, EventArgs e)
        {
            DisplayAlert("no tienes una sesion activa", "porfavor iniciar sesion para acceder a esta funcion", "OK");
        }
        private async void OnFavoritos(object sender, EventArgs e)
        {
            DisplayAlert("no tienes una sesion activa", "porfavor iniciar sesion para acceder a esta funcion", "OK");
        }
        private async void OnconfiguracionTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new configuracion());
        }
        private async void OnRegistroTapped(object sender, EventArgs e)
        {
            DisplayAlert("no tienes una sesion activa", "porfavor iniciar sesion para acceder a esta funcion", "OK");
        }
    }
}
