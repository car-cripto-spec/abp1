using System;
using System.Runtime.InteropServices;
using Xamarin.Forms;

namespace abp1
{
    public partial class configuracion : ContentPage
    {
        public configuracion()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(); // o PopModalAsync si lo abriste como modal
        }

        private async void OnCuentaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new perfil());
        }

        private  async void onHistorialClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistorialBancarioPage());
        }

        private  async void OnNormasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new normas());
        }

        private async void OnPermisosClicked(object sender, EventArgs e)
        {
         await Navigation.PushAsync(new PermisosPage());
        }

        private void OnAyudaClicked(object sender, EventArgs e)
        {
            DisplayAlert("Ayuda", "Sección Ayuda", "OK");
        }
    }
}
