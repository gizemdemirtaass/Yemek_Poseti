using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YemekPoseti.Models
{
    public class ProductsModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Number { get; set; }
    }
}