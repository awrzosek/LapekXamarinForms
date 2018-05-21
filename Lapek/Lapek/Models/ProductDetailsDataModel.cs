using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Models
{
    public class ProductDetailsDataModel
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Specs_ID { get; set; }

        public List<ImageDataModel> Images { get; set; }
        public SpecsDetailsModel Specs { get; set; }
    }
}
