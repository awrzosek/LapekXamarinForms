using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Models
{
    public class CartItemModel
    {
        [PrimaryKey]
        public int ID { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Price { get; set; }
    }
}
