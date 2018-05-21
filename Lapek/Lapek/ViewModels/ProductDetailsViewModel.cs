using Lapek.Models;
using Lapek.Services;
using Lapek.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lapek.ViewModels
{
    public class ProductDetailsViewModel : INotifyPropertyChanged
    {
        private string baseUri = "http://lapekwebapi.azurewebsites.net/api/products/";

        private ProductDetailsModel _productDetails;
        public ProductDetailsModel ProductDetails
        {
            get { return _productDetails; }
            set
            {
                _productDetails = value;
                OnPropertyChanged();
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddToCartCommand { get; set; }

        public ProductDetailsViewModel(int ID)
        {
            IsBusy = true;
            IsEnabled = false;
            GetProductDetails(ID);
            AddToCartCommand = new Command(AddToCart);
        }

        public List<CartItemModel> CartList { get; set; }

        private void AddToCart(object obj)
        {
            var item = new CartItemModel
            {
                ID = ProductDetails.ID,
                Amount = 1,
                Name = ProductDetails.Name,
                Price = ProductDetails.Price,
                Image = ProductDetails.Images[0].Image
            };
            if (!CartList.Exists(e => e.ID == item.ID))
            {
                App.DB.AddItemAsync(item);
            }
        }

        public async Task GetProductDetails(int ID)
        {
            CartList = await App.DB.GetItemsAsync();
            var Uri = baseUri + ID + "/details";
            var productDetailsService = new ProductDetailsService();
            var details = await productDetailsService.GetProductsAsync(Uri);

            ProductDetails = new ProductDetailsModel()
            {
                ID = details.ID,
                Name = details.Manufacturer + " " + details.Model,
                Price = details.Price + " zł",
                Processor = details.Specs.Processor,
                RAM = details.Specs.RAM + " GB",
                Max_RAM = details.Specs.Max_RAM + " GB",
                Disk_size = details.Specs.Disk_size + " GB",
                Disk_type = details.Specs.Disk_type,
                Display_type = details.Specs.Display_type,
                Display_size = details.Specs.Display_size + "\"",
                Resolution = details.Specs.Resolution,
                Graphics_card = details.Specs.Graphics_card,
                Battery = details.Specs.Battery,
                OS = details.Specs.OS,
                Height = details.Specs.Height + " mm",
                Width = details.Specs.Width + " mm",
                Depth = details.Specs.Depth + " mm",
                Weight = details.Specs.Weight + " kg",
                Warranty = details.Specs.Warranty + " mies.",
                Images = details.Images
            };
            IsBusy = false;
            IsEnabled = true;
        }

        public string NavigateToDetails(string name)
        {
            var Uri = baseUri + name;
            return Uri;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
