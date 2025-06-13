using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abp1.Models;
using abp1.Helpers;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace abp1
{


    public partial class FavoritosPage : ContentPage
    {

        public FavoritosPage()
        {
            InitializeComponent();
            MostrarFavoritos();
        }

        private void MostrarFavoritos()
        {
            FavoritosLayout.Children.Clear();

            foreach (var evento in DatosGlobales.Favoritos)
            {
                var card = new Frame
                {
                    BackgroundColor = Color.FromHex("#A9C9FF"),
                    CornerRadius = 10,
                    Padding = 10,
                    Content = new StackLayout
                    {
                        Children =
                    {
                        new Image { Source = evento.ImagenUrl, HeightRequest = 150, Aspect = Aspect.AspectFill },
                        new Label { Text = evento.Titulo, FontAttributes = FontAttributes.Bold, FontSize = 16 },
                        new Label { Text = evento.Descripcion, FontSize = 12 }
                    }
                    }
                };

                FavoritosLayout.Children.Add(card);
            }
        }
    }

}