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
    public partial class buscador : ContentPage
    {
        // Lista original de elementos
        private List<string> allItems;

        public buscador()
        {
            InitializeComponent();

            // Lista de ejemplo
            allItems = new List<string>
            {
                "Donación de comida",
                "Donación de alimentos",
                "Donación de ropa"
            };

            // Mostrar todos los elementos inicialmente
            ResultsListView.ItemsSource = allItems;
        }

        // Manejar clic en flecha
        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(); // O PopModalAsync si abriste modal
        }

        // Filtrar resultados
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue.ToLower();

            var filteredItems = allItems
                .Where(item => item.ToLower().Contains(searchText))
                .ToList();

            ResultsListView.ItemsSource = filteredItems;
        }
    }
}