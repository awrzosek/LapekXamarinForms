using Lapek.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lapek.Services
{
    public class ProductDetailsService
    {
        public async Task<ProductDetailsDataModel> GetProductsAsync(string productsUri)
        {
            RESTClientService<ProductDetailsDataModel> restClientService = new RESTClientService<ProductDetailsDataModel>();

            var productList = await restClientService.GetSingleAsync(productsUri);

            return productList;
        }
    }
}
