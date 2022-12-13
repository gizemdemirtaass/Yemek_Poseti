using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YemekPoseti.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string OrderDate { get; set; }
        public string OrderAddress { get; set; }
        public decimal OrderPrice { get; set; }
        public int ProductID { get; set; }
    }
}