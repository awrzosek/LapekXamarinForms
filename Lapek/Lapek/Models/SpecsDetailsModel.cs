using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Models
{
    public class SpecsDetailsModel
    {
        public int ID { get; set; }
        public string Processor { get; set; }
        public int? RAM { get; set; }
        public int? Max_RAM { get; set; }
        public int? Disk_size { get; set; }
        public string Disk_type { get; set; }
        public string Display_type { get; set; }
        public decimal Display_size { get; set; }
        public string Resolution { get; set; }
        public string Graphics_card { get; set; }
        public string Battery { get; set; }
        public string OS { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Weight { get; set; }
        public int? Warranty { get; set; }
    }
}
