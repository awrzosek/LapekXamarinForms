using System;
using System.Collections.Generic;
using System.Text;
using Lapek.Models;

namespace Lapek.Services
{
    public class MenuItemsService
    {
        public List<MenuItemsModel> GetMenu()
        {
            var MenuList = new List<MenuItemsModel>
            {
                new MenuItemsModel
                {
                    Name = "Strona Główna",
                    Source = "homedark.png"
                },
                new MenuItemsModel
                {
                    Name = "Wszystkie przedmioty",
                    Source = "listdark.png"
                },
                new MenuItemsModel
                {
                    Name = "Koszyk",
                    Source = "shoppingcartdark.png"
                },
                new MenuItemsModel
                {
                    Name = "Kontakt",
                    Source = "contactdark.png"
                }
            };
            return MenuList;
        }
    }
}
