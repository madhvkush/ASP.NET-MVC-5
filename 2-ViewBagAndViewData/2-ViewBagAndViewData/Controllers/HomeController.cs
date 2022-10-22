using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_ViewBagAndViewData.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
           ViewBag.Cities= new List<string>()
            {
                "New Delhi",
                "Noida",
                "Gurgaon",
                "Agra"
            };
            return View();
        }

        //get best contries

        public ActionResult BestContries()
        {
           ViewData["Contries"] = new List<string>()
            {
                "India",
                "USA",
                "UK",
                "Japan"
            };
            return View();
        }


    }
}
