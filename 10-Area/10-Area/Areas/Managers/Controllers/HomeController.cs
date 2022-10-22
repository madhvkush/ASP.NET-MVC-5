using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10_Area.Areas.Managers.Controllers
{
    public class HomeController : Controller // manegers home controller
    {
        //
        // GET: /Managers/Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
