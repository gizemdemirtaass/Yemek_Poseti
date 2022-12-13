using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YemekPoseti.Models;
using Dapper;


namespace YemekPoseti.Controllers
{
    public class RegisterController : Controller

    {
        YemekPosetiEntities db = new YemekPosetiEntities();
        // GET: Register
        public ActionResult YeniUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniUser(Customer ekle)
        {
            try
            {
                using (YemekPosetiEntities db = new YemekPosetiEntities())
                {
                    db.Customers.Add(ekle);
                    db.SaveChanges();
                }
                return RedirectToAction("Home", "Yonetici");
            }
            catch (Exception)
            {

                return View();
            }
        }
    }
}