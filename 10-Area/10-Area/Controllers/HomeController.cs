using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10_Area.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.ComeThrough = "Default NameSpce";
            ViewData["ComeThrough"] = "Default NameSpce";
            return View("Index");
        }

    }
}
