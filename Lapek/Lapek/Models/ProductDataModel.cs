using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Models
{
    public class ProductDataModel
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Specs_ID { get; set; }

        public ImageDataModel Image { get; set; }
        public SpecsDataModel Specs { get; set; }
    }
}
