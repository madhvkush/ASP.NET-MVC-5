using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21_KeepPeek.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["Message1"] = "Temp Data 1";
            TempData["Message2"] = "Temp Data 2";
            TempData["Message3"] = "Temp Data 3";
            return View();
        }

        [HttpPost]
        public ActionResult Posted()
        {
            //ViewBag.Message1 = TempData["Message1"] != null ? TempData["Message1"].ToString() : "TempData Message1 has been read";
            //ViewBag.Message2 = TempData["Message2"] != null ? TempData["Message2"].ToString() : "TempData Message2 has been read";
            //ViewBag.Message3 = TempData["Message3"] != null ? TempData["Message3"].ToString() : "TempData Message3 has been read";


            string str1 = TempData["Message1"] != null ? TempData["Message1"].ToString() : "TempData Message1 has been read";
            string str2 = TempData["Message2"] != null ? TempData["Message2"].ToString() : "TempData Message2 has been read";
            string str3 = TempData["Message3"] != null ? TempData["Message3"].ToString() : "TempData Message3 has been read";

            ViewBag.Message1 = str1;
            ViewBag.Message2 = str2;
            ViewBag.Message3 = str3;


            return View("Index");
        }

        public ActionResult Index2()
        {
            
           return RedirectToAction("Index");
        }


    }
}