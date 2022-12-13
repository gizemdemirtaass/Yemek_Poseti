using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekPoseti.Models;
using Dapper;

namespace YemekPoseti.Controllers
{
    public class OrderDetailController : Controller
    {
        // GET: OrderDetail
        public ActionResult OrderDetailListele()
        {
            return View(DP.Returnlist<OrderDetailModel>("OrderDetailListele"));
        }

        public ActionResult OrderDetailEY(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@OrderDetailID", id);
                return View(DP.Returnlist<OrderDetailModel>("OrderDetailSirala", param).FirstOrDefault<OrderDetailModel>());
            }

        }
        [HttpPost]
        public ActionResult OrderDetailEY(OrderDetailModel orderDetail)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@OrderDetailID", orderDetail.OrderDetailID);
            param.Add("@ProductID", orderDetail.ProductID);
            param.Add("@Introduction", orderDetail.Introduction);
            DP.EXReturn("OrderDetailEY", param);
            return RedirectToAction("OrderDetailListele");

        }
        public ActionResult OrderDetailDelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@OrderDetailID", id);
            DP.EXReturn("ODSil", param);
            return RedirectToAction("OrderDetailListele");
        }
    }
}