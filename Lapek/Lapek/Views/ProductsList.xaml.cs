using Lapek.Models;
using Lapek.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lapek.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductsList : ContentPage
	{
		public ProductsList ()
		{
			InitializeComponent ();
            BindingContext = new ProductListViewModel();
		}

        public ProductsList(string category)
        {
            InitializeComponent();
            BindingContext = new ProductListViewModel(category);
        }

        void OnProductTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var selection = e.Item as ProductModel;
                Navigation.PushAsync(new ProductDetails(selection.ID));
            }
        }
    }
}