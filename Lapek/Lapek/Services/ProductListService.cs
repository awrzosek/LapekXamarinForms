using Lapek.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lapek.Services
{
    public class ProductListService
    {
        public List<ProductDataModel> GetProducts()
        {
            var productsList = new List<ProductDataModel>
            {
                new ProductDataModel
                {
                    ID = 1,
                    Model = "Inspiron 3552",
                    Manufacturer = "Dell",
                    Price = 2599,
                    Quantity = 2,
                    Specs_ID = 1,
                    Image = new ImageDataModel
                    {
                        ID = 1,
                        Name = "dell_inspiron_3552",
                        Image = null,
                        Product_ID = 1
                    },
                    Specs = new SpecsDataModel
                    {
                        ID = 1,
                        Processor = "Intel Core i7-7500U",
                        RAM = 8,
                        Disk_size = 1000,
                        Disk_type = "HDD SATA3"
                    }
                },
                new ProductDataModel
                {
                    ID = 2,
                    Model = "Air",
                    Manufacturer = "MacBook",
                    Price = 5499,
                    Quantity = 1,
                    Specs_ID = 2,
                    Image = new ImageDataModel
                    {
                        ID = 2,
                        Name = "macbook_air",
                        Image = null,
                        Product_ID = 2
                    },
                    Specs = new SpecsDataModel
                    {
                        ID = 2,
                        Processor = "Intel Core i7-7500U",
                        RAM = 8,
                        Disk_size = 240,
                        Disk_type = "SSD SATA3"
                    }
                }
            };
            return productsList;
        }

        public async Task<List<ProductDataModel>> GetProductsAsync(string productsUri)
        {
            RESTClientService<ProductDataModel> restClientService = new RESTClientService<ProductDataModel>();

            var productList = await restClientService.GetListAsync(productsUri);

            return productList;
        }
    }
}
