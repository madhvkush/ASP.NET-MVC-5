using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_MutipleSubmit.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitOK()
        {
            ViewBag.Messsage = "OK clicked";
            return View("Index");
        }

        [HttpPost]
        public ActionResult SubmitCancel()
        {
            ViewBag.Messsage = "Cancel clicked";
            return View("Index");
        }
    }
}