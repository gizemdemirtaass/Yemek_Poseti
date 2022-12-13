using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YemekPoseti.Models;

namespace YemekPoseti.Controllers
{
    [AllowAnonymous]
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(AdminLogin user)
        {
            using (YemekPosetiEntities db = new YemekPosetiEntities())
            {
                var result = db.CMasters.Where(x => x.UserName == user.Username && x.UserPassword == user.Password1);
                if (result.Count() != 0)
                {
                    FormsAuthentication.SetAuthCookie(user.Username, false);  

                    return RedirectToAction("Home", "AYonetici");
                }
                else
                {
                    TempData["msg"] = "hatalı";  
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut(); 
            return View("Login"); 
        }

    }
}