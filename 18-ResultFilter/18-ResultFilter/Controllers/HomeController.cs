using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18_ResultFilter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Filters.CustomActionResultFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}