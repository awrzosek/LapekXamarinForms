using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Models
{
    public class ProductsOrderModel
    {
        public int ID { get; set; }
        public int Orders_ID { get; set; }
        public int Product_ID { get; set; }
        public int Amount { get; set; }
    }
}
