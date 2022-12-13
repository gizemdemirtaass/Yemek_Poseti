using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YemekPoseti.Models
{
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public string CName { get; set; }
        public string CUserName { get; set; }
        public string CUserPassword { get; set; }
        public string CUserMail { get; set; }
        public string CUserAddress { get; set; }
    }
}