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
    public partial class Eventos_donar: ContentPage
    {
        public Eventos_donar()
        {
            InitializeComponent();
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnLikeClicked(object sender, EventArgs e)
        {
            DisplayAlert("Like", "Te gusta este evento", "OK");
        }

        private void OnCommentClicked(object sender, EventArgs e)
        {
            DisplayAlert("Comentarios", "Ver o agregar comentarios", "OK");
        }

        private void OnInfoClicked(object sender, EventArgs e)
        {
            DisplayAlert("Información", "Más información sobre este evento", "OK");
        }

        private void OnCameraClicked(object sender, EventArgs e)
        {
            DisplayAlert("Cámara", "Función de cargar foto no implementada", "OK");
        }

        private void OnDonarClicked(object sender, EventArgs e)
        {
            DisplayAlert("Donar", "Gracias por tu donación", "OK");
        }
    }
}