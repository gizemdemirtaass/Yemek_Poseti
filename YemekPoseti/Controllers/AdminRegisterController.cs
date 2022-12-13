using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekPoseti.Models;
using System.Web.Security;

namespace YemekPoseti.Controllers
{
    public class AdminRegisterController : Controller
    {
        YemekPosetiEntities db = new YemekPosetiEntities();
        // GET: AdminRegister
        public ActionResult YeniAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniAdmin(CMaster ekle)
        {
            try
            {
                using (YemekPosetiEntities db = new YemekPosetiEntities())
                {
                    db.CMasters.Add(ekle);
                    db.SaveChanges();
                }
                return RedirectToAction("Home", "AYonetici");
            }
            catch (Exception)
            {

                return View();
            }
        }
    }
}