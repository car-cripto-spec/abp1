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
	public partial class Meta_donaciones: ContentPage
	{
		public Meta_donaciones ()
		{
            InitializeComponent();

        }
        private async void OnDonacionClicked(object sender, EventArgs e)

        {
            
            await Navigation.PushAsync(new Donacion());
        }
    }
}