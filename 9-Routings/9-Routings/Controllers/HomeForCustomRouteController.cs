using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _9_Routings.Controllers
{
    public class HomeForCustomRouteController : Controller
    {
        //
        // GET: /HomeForCustomRoute/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(int Id)
        {
            ViewBag.Id = Id;
            return View("Index");
        }
        

    }
}
