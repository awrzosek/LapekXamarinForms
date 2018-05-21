using Lapek.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Lapek.Services;
using Lapek.ViewModels;
using Lapek.Models;

namespace Lapek
{
	public partial class MainPage : MasterDetailPage
	{

        private string Uri = "http://lapekwebapi.azurewebsites.net/api/products/";
        public MainPage()
		{
			InitializeComponent();
            Detail = new NavigationPage(new Categories());
        }

        void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var selection = e.Item as MenuItemsModel;
                var viewModel = new MainPageViewModel();
                Detail = viewModel.Selected(selection.Name);
                IsPresented = false;
            }
        }

        void Shopping_cart_clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ShoppingCart());
        }

        void Search_clicked(object sender, EventArgs e)
        {
            //var searchPhrase = "";
            Navigation.PushModalAsync(new Search());

            MessagingCenter.Subscribe<Search, string>(this, "search", (Sender, argument) =>
            {
                Uri += argument;
                Detail = new NavigationPage(new ProductsList(Uri));
            });
        }
    }
}
