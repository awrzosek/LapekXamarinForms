using Lapek.Models;
using Lapek.SQLite;
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
	public partial class ProductDetails : ContentPage
	{
		public ProductDetails ()
		{
			InitializeComponent ();
        }

        public ProductDetails(int ID)
        {
            InitializeComponent();
            BindingContext = new ProductDetailsViewModel(ID);
        }

        //do kropek w galerii
        //private void OnImageSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var img = e.SelectedItem as ImageDataModel;
        //    Test.Text = img.Name;
        //}
    }
}