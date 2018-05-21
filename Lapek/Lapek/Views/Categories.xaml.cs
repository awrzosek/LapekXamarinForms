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
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Categories : ContentPage
	{
		public Categories ()
		{
			InitializeComponent();

		}


        void OnCategoryTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var selection = e.Item as CategoryModel;
                var viewModel = new CategoriesViewModel();
                Navigation.PushAsync(new ProductsList(viewModel.NavigateToCategory(selection.Name)));
            }
        }
	}
}