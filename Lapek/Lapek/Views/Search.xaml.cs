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
	public partial class Search : ContentPage
	{
		public Search ()
		{
			InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Searching.Focus();
        }

        void SearchButton_Pressed(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "search", Searching.Text);
            Navigation.PopModalAsync();
            MessagingCenter.Unsubscribe<MainPage, string>(this, "search");
        }

        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyphrase = Searching.Text;
            var vm = new SearchViewModel();
            if (keyphrase != "")
            {
                string lastword = keyphrase.Split(' ').Last();
                Suggestions.ItemsSource = vm.PrepareSuggestions(lastword);
            }
            else
                Suggestions.ItemsSource = null;
        }

        void OnSuggestionTapped(object sender, ItemTappedEventArgs e)
        {
            Searching.Focus();

            var item = e.Item as string;
            string[] words = Searching.Text.Split(' ');
            Searching.Text = "";
            for (int i = 0; i < words.Length - 1; i++)
                Searching.Text += words[i] + ' ';
            Searching.Text += item;
            Suggestions.ItemsSource = null;
        }

        void SearchForProducts(string keyphrase)
        {
            MessagingCenter.Send(this, "search", keyphrase);
            Navigation.PopModalAsync();

            MessagingCenter.Unsubscribe<MainPage, string>(this, "search");
        }
    }
}