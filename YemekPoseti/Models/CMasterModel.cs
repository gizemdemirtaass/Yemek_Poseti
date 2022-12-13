using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YemekPoseti.Models
{
    public class CMasterModel
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserMail { get; set; }
        public string UserAddress { get; set; }
    }
}