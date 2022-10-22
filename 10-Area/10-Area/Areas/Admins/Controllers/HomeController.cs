using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10_Area.Areas.Admins.Controllers
{
    public class HomeController : Controller //home controller for admin
    {
        //
        // GET: /Admins/Home/

        public ActionResult Index()
        {
            return View("Index");
        }

    }
}
