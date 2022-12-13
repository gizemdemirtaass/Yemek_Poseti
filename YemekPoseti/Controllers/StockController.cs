using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekPoseti.Models;
using Dapper;

namespace YemekPoseti.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult StockListele()
        {
            return View(DP.Returnlist<StockModel>("StockListele"));
        }
        [HttpGet]
        public ActionResult StockEY(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@StockID", id);
                return View(DP.Returnlist<StockModel>("StockIDSirala", param).FirstOrDefault<StockModel>());
            }


        }
        [HttpPost]
        public ActionResult StockEY(StockModel stock)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@StockID", stock.StockID);
            param.Add("@ProductID", stock.ProductID);
            param.Add("@ProductAmount", stock.ProductAmount);
            DP.EXReturn("StockEY", param);
            return RedirectToAction("StockListele");

        }
        public ActionResult StockDelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@StockID", id);
            DP.EXReturn("StockSil", param);
            return RedirectToAction("StockListele");
        }
    }
}