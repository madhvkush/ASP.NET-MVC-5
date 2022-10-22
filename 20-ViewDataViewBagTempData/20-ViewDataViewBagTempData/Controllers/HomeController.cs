using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20_ViewDataViewBagTempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "This is from ViewBag";
            ViewData["Message"] = "This is from ViewData";
            TempData["Message"] = "This is from TempData";
            return View();
        }

        [HttpPost]
        public ActionResult Posted()
        {
            ViewBag.AfterPosted = TempData["Message"]+" After Posted";
            return View("Index");
        }
    }
}