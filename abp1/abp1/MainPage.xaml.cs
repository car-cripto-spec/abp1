using System;
using System.Linq;
using abp1.Helpers; // Para acceder a DatosGlobales
using abp1.Models; // Asegúrate que este sea el namespace correcto
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
            await Navigation.PushAsync(new Evento_vista());
        }

        private async void OnFavoritosTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FavoritosPage());
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
            // Cambiar texto del botón (si es Button y no ImageButton)
            if (sender is Button heartButton)
            {
                // Crear el evento que representa esta tarjeta
                var evento = new EventoModel
                {
                    Titulo = "Donación de alimentos",
                    Descripcion = "El propósito del evento es participar con la entrega de alimentos a personas en situación de calle.",
                    ImagenUrl = "https://www.investopedia.com/thmb/CWFdk-YJkte3rNO_76FNCSfi5mM=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/GettyImages-1498170916-39ceb2a46795483fbbcb05ffa82b79eb.jpg"
                };

                // Verificar si ya está en favoritos
                var existente = DatosGlobales.Favoritos.FirstOrDefault(f => f.Titulo == evento.Titulo);

                if (existente != null)
                {
                    // Ya está → quitar
                    DatosGlobales.Favoritos.Remove(existente);
                    heartButton.Text = "♡";

                    await DisplayAlert("Favorito eliminado", "El evento se borró de tus favoritos.", "OK");
                }
                else
                {
                    // No está → agregar
                    DatosGlobales.Favoritos.Add(evento);
                    heartButton.Text = "❤";

                    bool verFavoritos = await DisplayAlert("Favorito guardado",
                        "El evento fue guardado en tus favoritos.",
                        "Ver evento guardado", "Volver");

                    if (verFavoritos)
                    {
                        await Navigation.PushAsync(new FavoritosPage());
                    }
                }
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
