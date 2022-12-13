using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekPoseti.Models;
using Dapper;

namespace YemekPoseti.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        [HttpGet]
        public ActionResult OrderListele()
        {
            return View(DP.Returnlist<OrderModel>("OrderListele"));
        }
        [HttpGet]
        public ActionResult OrderEY(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@OrderID", id);
                return View(DP.Returnlist<OrderModel>("OrderIDSirala", param).FirstOrDefault<OrderModel>());
            }


        }
        [HttpPost]
        public ActionResult OrderEY(OrderModel order)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@OrderID", order.OrderID);
            param.Add("@CustomerID", order.CustomerID);
            param.Add("@OrderDate", order.OrderDate);
            param.Add("@OrderAddress", order.OrderAddress);
            param.Add("@OrderPrice", order.OrderPrice);
            param.Add("@ProductID", order.ProductID);
            DP.EXReturn("OrderEY", param);
            return RedirectToAction("OrderListele");

        }
        public ActionResult OrderDelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@OrderID", id);
            DP.EXReturn("OSil", param);
            return RedirectToAction("OrderListele");
        }

    }
}