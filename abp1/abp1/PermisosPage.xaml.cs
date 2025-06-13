using System;
using Xamarin.Forms;

namespace abp1
{
    public partial class PermisosPage : ContentPage
    {
        public PermisosPage()
        {
            InitializeComponent();
        }

        private async void OnAceptarClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Permisos", "Gracias por revisar los permisos.", "OK");
            await Navigation.PopAsync(); // Vuelve a la página anterior
        }
    }
}
