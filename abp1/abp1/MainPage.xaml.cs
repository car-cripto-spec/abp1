using System;
using Xamarin.Forms;

namespace abp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
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
            await Navigation.PushAsync(new trofeos());
        }
        private async void OnperfilTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PruebaPage());
        }
        private async void OnNotificacionesTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Notificaciones());
        }
        private async void OnBusquedaTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new buscador());
        }
        private async void OnAgregareventoPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgregarEventoPage());
        }
        private async void OnTuEventoPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MostrarEventosPage());
        }
        private async void OnFavoritos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Favoritos());
        }
        private async void OnconfiguracionTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new configuracion());
        }
        private async void OnRegistroTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Registro", "En hora buena, ahora eres voluntario del evento", "OK");
        }
    }
}
