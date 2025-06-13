using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace abp1
{
    public partial class App : Application
    {
        public App()
        {
            {
                InitializeComponent();

                // Envolver MainPage en un NavigationPage para habilitar PushAsync
                MainPage = new NavigationPage(new MainPage());

               
            }
        }

        protected override void OnStart()
        {
            

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
