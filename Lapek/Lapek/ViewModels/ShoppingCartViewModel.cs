using Lapek.Models;
using Lapek.Services;
using Lapek.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lapek.ViewModels
{
    public class ShoppingCartViewModel : INotifyPropertyChanged
    {
        public ICommand IncreaseAmountCommand { get; set; }
        public ICommand DecreaseAmountCommand { get; set; }
        public ICommand RemoveFromCartCommand { get; set; }

        private string _totalPrice;
        public string TotalPrice
        {
            get
            {
                return _totalPrice;
            }
            set
            {
                _totalPrice = value;
                OnPropertyChanged();
            }
        }
        private List<CartItemModel> _itemsList;
        public List<CartItemModel> ItemsList
        {
            get
            {
                return _itemsList;
            }
            set
            {
                _itemsList = value;
                OnPropertyChanged();
            }
        }
        public ICommand Clear{ get; set; }

        public ShoppingCartViewModel()
        {
            GetItems();

            IncreaseAmountCommand = new Command<CartItemModel>(obj =>
            {
                IncreaseAmount(obj);
            });

            DecreaseAmountCommand = new Command<CartItemModel>(obj =>
            {
                DecreaseAmount(obj);
            });

            RemoveFromCartCommand = new Command<CartItemModel>(obj =>
            {
                RemoveFromCart(obj);
            });
        }

        async void DecreaseAmount(CartItemModel obj)
        {
            if(obj.Amount > 1)
            {
                obj.Amount--;
                await App.DB.UpdateItemAsync(obj);
                GetItems();
            }
        }

        async void IncreaseAmount(CartItemModel obj)
        {
            obj.Amount++;
            await App.DB.UpdateItemAsync(obj);
            GetItems();
        }

        async void RemoveFromCart(CartItemModel obj)
        {
            await App.DB.DeleteItemAsync(obj);
            GetItems();
        }

        private void ClearAll(object obj)
        {
            App.DB.DeleteAllItemsAsync();
        }

        private async void GetItems()
        {
            ItemsList = await App.DB.GetItemsAsync();
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            decimal price = 0;
            foreach(CartItemModel item in ItemsList)
            {
                string val = item.Price;
                val = val.Remove(val.Length-3);
                price += Convert.ToDecimal(val) * item.Amount;
            }
            TotalPrice = "Kontynuuj | " + price + " zł";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
