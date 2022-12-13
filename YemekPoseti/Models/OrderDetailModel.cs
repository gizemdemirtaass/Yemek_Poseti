using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YemekPoseti.Models
{
    public class OrderDetailModel
    {
        public int OrderDetailID { get; set; }
        public int ProductID { get; set; }
        public string Introduction { get; set; }
    }
}