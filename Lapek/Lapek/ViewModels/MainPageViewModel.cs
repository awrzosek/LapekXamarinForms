using Lapek.Models;
using Lapek.Services;
using Lapek.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lapek.ViewModels
{
    class MainPageViewModel
    {
        public List<MenuItemsModel> MenuItemsList { get; set; }

        public MainPageViewModel()
        {
            var menuItemsService = new MenuItemsService();

            MenuItemsList = menuItemsService.GetMenu();
        }

        public NavigationPage Selected(string selectedItem)
        {
            NavigationPage page = new NavigationPage();
            switch (selectedItem)
            {
                case "Strona Główna":
                    {
                        page = new NavigationPage(new Categories());
                    }
                    break;
                case "Wszystkie przedmioty":
                    {
                        page = new NavigationPage(new ProductsList());
                    }
                    break;
                case "Koszyk":
                    {
                        page = new NavigationPage(new ShoppingCart());
                    }
                    break;
                case "Kontakt":
                    {
                        page = new NavigationPage(new Contact());
                    }
                    break;
            }
            return page;
        }
    }
}
