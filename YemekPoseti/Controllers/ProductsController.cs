using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekPoseti.Models;
using Dapper;


namespace YemekPoseti.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult ProductListele()
        {
            return View(DP.Returnlist<ProductsModel>("ProductsListele"));
        }
        [HttpGet]
        public ActionResult ProductEY(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ProductID", id);
                return View(DP.Returnlist<ProductsModel>("ProductsSirala", param).FirstOrDefault<ProductsModel>());
            }


        }
        [HttpPost]
        public ActionResult ProductEY(ProductsModel products)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ProductID", products.ProductID);
            param.Add("@ProductName", products.ProductName);
            param.Add("@Type", products.Type);
            param.Add("@Price", products.Price);
            param.Add("@Number", products.Number);
            DP.EXReturn("ProductsEY", param);
            return RedirectToAction("ProductListele");

        }
        public ActionResult ProductDelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ProductID", id);
            DP.EXReturn("PSil", param);
            return RedirectToAction("ProductListele");
        }
    }
}