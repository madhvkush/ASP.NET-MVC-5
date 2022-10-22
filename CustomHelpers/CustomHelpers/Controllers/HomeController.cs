using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomHelpers.Models;

namespace CustomHelpers.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View("InlineHTMLHelper");
        }

        public ActionResult CustomStaticHelper()
        {
            return View("CustomStaticHelper");
        }

        public ActionResult StronglyTypedHelper()
        {
            UserInfo user = new UserInfo { Name = "Madhv",Mobile="9717672629" };
            return View(user);
        }

    }
}
