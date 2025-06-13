using System;
using System.Linq;
using Xamarin.Forms;
using abp1.Models; // Asegúrate que este sea el namespace correcto
using abp1.Helpers; // Para acceder a DatosGlobales

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
            await Navigation.PushAsync(new Evento_vista());
        }

        private async void OnMeta_donacionespped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Meta_donaciones());
        }

        private async void OnEventos_donarTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Eventos_donar());
        }

        private async void OntrofeosTapped(object sender, EventArgs e)
        {
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

        private async void OnFavoritosPageTapped(object sender, EventArgs e)
        {
            // Cambiar ícono a rojo (usando texto si es botón)
            if (sender is Button heartButton)
            {
                heartButton.Text = "❤";
            }

            // Crear el evento (puedes usar tus datos reales si los tienes)
            var evento = new EventoModel
            {
                Titulo = "Donación de alimentos",
                Descripcion = "El propósito del evento es participar con la entrega de alimentos a personas en situación de calle.",
                ImagenUrl = "https://www.investopedia.com/thmb/CWFdk-YJkte3rNO_76FNCSfi5mM=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/GettyImages-1498170916-39ceb2a46795483fbbcb05ffa82b79eb.jpg"
            };

            // Guardar si no está repetido
            if (!DatosGlobales.Favoritos.Any(f => f.Titulo == evento.Titulo))
            {
                DatosGlobales.Favoritos.Add(evento);
            }

            // Mostrar alerta con opciones
            bool verFavoritos = await DisplayAlert("Favorito guardado",
                "El evento fue guardado en sus favoritos.",
                "Ver evento guardado", "Volver");

            if (verFavoritos)
            {
                await Navigation.PushAsync(new FavoritosPage());
// Asegúrate que esta página exista
            }
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
