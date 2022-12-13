using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekPoseti.Models;
using Dapper;

namespace YemekPoseti.Controllers
{
    public class UserProductsController : Controller
    {
        // GET: UserProducts
        public ActionResult UPListele()
        {
            return View(DP.Returnlist<ProductsModel>("ProductsListele"));
        }
    }
}