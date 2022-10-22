using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23_FormAuthentication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(string UserName ,string Password)
        {
            if (UserName == "Madhv")
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie(UserName, true);
                return RedirectToAction("Dasboard");
            }else
            return View();
        }

        [Authorize]
        public ActionResult Dasboard()
        {
         //System.Web.Security.FormsAuthentication.
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult Logout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}