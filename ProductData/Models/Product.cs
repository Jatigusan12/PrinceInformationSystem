using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        public string ProductStatus { get; set; }
        public DateTime DateAdded { get; set; }
        public string PersonAdded{ get; set; }
        public DateTime DateUpdated { get; set; }
        public string PersonUpdated { get; set; }


    }
}
