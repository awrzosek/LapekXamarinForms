using Lapek.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lapek.Services
{
    public class OrderService
    {

        public async Task<OrderDataIDModel> GetOrderAsync(string productsUri)
        {
            RESTClientService<OrderDataIDModel> restClientService = new RESTClientService<OrderDataIDModel>();

            var order = await restClientService.GetSingleAsync(productsUri);

            return order;
        }


        public async Task PostOrderAsync(string ordersUri, OrderDataModel order)
        {
            RESTClientService<OrderDataModel> restClientService = new RESTClientService<OrderDataModel>();

            var item = await restClientService.PostAsync(ordersUri, order);
        }

        public async Task PostProductsOrderAsync(string ordersUri, ProductsOrderModel productsOrder)
        {
            RESTClientService<ProductsOrderModel> restClientService = new RESTClientService<ProductsOrderModel>();

            var item = await restClientService.PostAsync(ordersUri, productsOrder);
        }
    }
}
