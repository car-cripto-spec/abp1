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
    public partial class Agradecimiento : ContentPage
    {
        public Agradecimiento()
        {
            InitializeComponent();
        }

        private async void OnRevisarRecompensasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new trofeos ());
        }

        private async void OnBackTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}