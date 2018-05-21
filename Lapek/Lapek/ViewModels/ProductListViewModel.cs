using Lapek.Models;
using Lapek.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lapek.ViewModels
{
    public class ProductListViewModel : INotifyPropertyChanged
    {
        private List<ProductModel> _productsList;
        public List<ProductModel> ProductsList
        {
            get { return _productsList; }
            set
            {
                _productsList = value;
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

        private string Uri = "http://lapekwebapi.azurewebsites.net/api/products";

        public ProductListViewModel()
        {
            IsBusy = true;
            GetDisplayValues(Uri);
        }

        public ProductListViewModel(string categoryUri)
        {
            IsBusy = true;
            categoryUri.Replace(" ", "%20");
            GetDisplayValues(categoryUri);
        }


        public async Task GetDisplayValues(string Uri)
        {
            var productListServices = new ProductListService();
            var list = await productListServices.GetProductsAsync(Uri);

            ProductsList = new List<ProductModel>();
            foreach (ProductDataModel product in list)
            {
                if(product.Quantity > 0)
                {
                    var singleProduct = new ProductModel
                    {
                        ID = product.ID,
                        Name = product.Manufacturer +
                        " " + product.Model,
                        Processor = product.Specs.Processor,
                        RAM = product.Specs.RAM + " GB RAM",
                        Storage = product.Specs.Disk_size +
                        " GB " + product.Specs.Disk_type,
                        Price = "CENA: \n" + (int)product.Price + " zł",
                        Img = product.Image.Image
                    };
                    ProductsList.Add(singleProduct);
                }
            }
            IsBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
