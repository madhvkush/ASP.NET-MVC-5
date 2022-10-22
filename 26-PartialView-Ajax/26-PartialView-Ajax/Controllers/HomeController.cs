using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _26_PartialView_Ajax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult GetPartialResult(string Parm1)
        {
            string Result = "Hello " + Parm1;
            return PartialView("_MPartial", Result);
        }
    }
}