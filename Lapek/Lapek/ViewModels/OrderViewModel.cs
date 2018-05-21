using Lapek.Models;
using Lapek.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lapek.ViewModels
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        public List<CartItemModel> ItemsList { get; set; }
        public ICommand Test { get; set; }
        private OrderDataModel _order;
        public OrderDataModel Order
        {
            get { return _order; }
            set
            {
                _order = value;
                OnPropertyChanged();
            }
        }

        private decimal _totalPrice;
        public decimal TotalPrice
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

        private string _imie;
        public string Imie
        {
            get
            {
                return _imie;
            }
            set
            {
                _imie = value;
                OnPropertyChanged();
            }
        }

        public OrderViewModel()
        {
            GetItems();
            Order = new OrderDataModel();
            Test = new Command(Pay);
        }

        private string PostOrderUri = "http://lapekwebapi.azurewebsites.net/api/orders/";

        private async void Pay(object obj)
        {
            Order.Total_Price = TotalPrice;
            Order.Order_date = DateTime.Now;
            var orderService = new OrderService();
            await orderService.PostOrderAsync(PostOrderUri, _order);
            App.DB.DeleteAllItemsAsync();
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        async void GetItems()
        {
            ItemsList = await App.DB.GetItemsAsync();
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            foreach (CartItemModel item in ItemsList)
            {
                string val = item.Price;
                val = val.Remove(val.Length - 3);
                TotalPrice += Convert.ToDecimal(val) * item.Amount;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
