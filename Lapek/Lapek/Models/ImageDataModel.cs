using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Models
{
    public class ImageDataModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public int Product_ID { get; set; }
    }
}
