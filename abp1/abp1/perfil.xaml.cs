using System;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.IO;

namespace abp1
{
    public partial class perfil : ContentPage
    {
        public perfil()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Cargar datos del usuario
            NombreLabel.Text = Preferences.Get("nombreUsuario", "Sin nombre");
            DescripcionLabel.Text = Preferences.Get("descripcionPerfil", "Sin descripción");

            // Imagen de perfil
            var imagePath = Preferences.Get("imagenPerfil", "");
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                ProfileImage.Source = ImageSource.FromFile(imagePath);
            else
                ProfileImage.Source = "default_profile.png"; // Imagen por defecto
        }

        private async void OnEditarPerfilClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditarPerfil());
        }
    }
}
