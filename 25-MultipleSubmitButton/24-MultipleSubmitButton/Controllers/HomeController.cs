using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_MultipleSubmitButton.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [MultipleButton(Name="Submit",Argument="OK")]
        public ActionResult PostedOK()
        {
            ViewBag.Button = "OK clicked";
            return View("Index");
        }

        [HttpPost]
        [MultipleButton(Name = "Submit", Argument = "Cancel")]
        public ActionResult PostedCancel()
        {
            ViewBag.Button = "Cancel clicked";
            return View("Index");
        }
    }
}
