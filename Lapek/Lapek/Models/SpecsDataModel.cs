using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Models
{
    public class SpecsDataModel
    {
        public int ID { get; set; }
        public string Processor { get; set; }
        public int? RAM { get; set; }
        public int? Disk_size { get; set; }
        public string Disk_type { get; set; }
    }
}
