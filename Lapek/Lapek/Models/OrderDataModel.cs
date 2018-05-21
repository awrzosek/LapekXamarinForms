using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Models
{
    public class OrderDataModel
    {
        public int ID { get; set; }
        public System.DateTime Order_date { get; set; }
        public string Client_FirstName { get; set; }
        public string Client_LastName { get; set; }
        public string Client_Address { get; set; }
        public string Zip_Code { get; set; }
        public string City { get; set; }
        public string Client_Tel { get; set; }
        public string Client_Email { get; set; }
        public decimal Total_Price { get; set; }
        public string Delivery { get; set; }
    }
}
