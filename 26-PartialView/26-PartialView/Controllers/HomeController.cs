using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _26_PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Content = "ViewBag content to Main view";
            return View();
        }
        // use child action only to prevent direct GET, now it can be called only by Render.Action method in the view 
        [ChildActionOnly] 
        public PartialViewResult ActionWithPartialView()
        {
            ViewBag.Content = "ViewBag content";
            return PartialView("ActionWithPartialView", "This Content is from Action Method which is return to this Partial View");
        }
    }
}