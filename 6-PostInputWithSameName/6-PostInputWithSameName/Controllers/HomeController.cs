using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_PostInputWithSameName.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostData(string[] InputwithSameName)
        {
            ViewBag.Names = string.Join(",", InputwithSameName);
            return View("Index");
        }
    }
}