using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace abp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Evento_vista : ContentPage
    {
        public Evento_vista()
        {
            InitializeComponent();
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            // Lógica para volver (puedes usar Navigation.PopAsync si es una página dentro de una pila)
            DisplayAlert("Registro", "En hora buena, te has registrado como voluntario", "OK");
        }

        private void OnEnviarPreguntaClicked(object sender, EventArgs e)
        {
            string pregunta = PreguntaEntry.Text?.Trim();
            if (!string.IsNullOrEmpty(pregunta))
            {
                var preguntaFrame = new Frame
                {
                    BackgroundColor = Color.White,
                    CornerRadius = 8,
                    Padding = 10,
                    Content = new Label
                    {
                        Text = "❓ " + pregunta,
                        FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
                    }
                };

                PreguntasMuro.Children.Add(preguntaFrame);
                PreguntaEntry.Text = string.Empty;
            }

            DisplayAlert("Pregunta enviada", "Gracias por tu pregunta", "OK");
        }

        private void OnEnviarComentarioClicked(object sender, EventArgs e)
        {
            string comentario = ComentarioEntry.Text?.Trim();
            if (!string.IsNullOrEmpty(comentario))
            {
                var comentarioFrame = new Frame
                {
                    BackgroundColor = Color.White,
                    CornerRadius = 8,
                    Padding = 10,
                    Content = new Label
                    {
                        Text = "💬 " + comentario,
                        FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
                    }
                };

                ComentariosMuro.Children.Add(comentarioFrame);
                ComentarioEntry.Text = string.Empty;
            }

            DisplayAlert("Comentario enviado", "Gracias por tu comentario", "OK");
        }


        private async void OnMeta_donacionClicked(object sender, EventArgs e)
        {
            // Abre la página del evento
            await Navigation.PushAsync(new Meta_donaciones());
        }
        private void OnRegistrarseClicked(object sender, EventArgs e)
        {
            DisplayAlert("Registro", "En hora buena ahora eres voluntario del evento.", "OK");
        }


    }

}

