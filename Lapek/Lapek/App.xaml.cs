using Lapek.SQLite;
using Lapek.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lapek
{
	public partial class App : Application
	{
        //obsługa bazy danych, dostęp w obrębie całej aplikacji
        private static LocalDB _db;
        public static LocalDB DB
        {
            get
            {
                if (_db == null)
                {
                    _db = new LocalDB(DependencyService.Get<IFileHelper>().GetLocalFilePath("SQLiteShoppingCartDB.db3"));
                }
                return _db;
            }
        }
        //

        public static string AllproductsUri { get; set; } = "http://lapekwebapi.azurewebsites.net/api/products/";

        public App ()
		{
			InitializeComponent();
            MainPage = new MainPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
