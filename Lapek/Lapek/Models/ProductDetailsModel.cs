using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Models
{
    public class ProductDetailsModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Max_RAM { get; set; }
        public string Disk_size { get; set; }
        public string Disk_type { get; set; }
        public string Display_type { get; set; }
        public string Display_size { get; set; }
        public string Resolution { get; set; }
        public string Graphics_card { get; set; }
        public string Battery { get; set; }
        public string OS { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Depth { get; set; }
        public string Weight { get; set; }
        public string Warranty { get; set; }

        public List<ImageDataModel> Images { get; set; }

    }
}
