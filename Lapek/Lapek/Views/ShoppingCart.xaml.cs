using Lapek.Models;
using Lapek.SQLite;
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
	public partial class ShoppingCart : ContentPage
	{
		public ShoppingCart ()
		{
			InitializeComponent ();
		}

        public void NavigateToOrder()
        {
            Navigation.PushModalAsync(new OrderForm());
        }
    }
}