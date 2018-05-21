using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Lapek.Models
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string Price { get; set; }
        public byte[] Img { get; set; }
    }
}
