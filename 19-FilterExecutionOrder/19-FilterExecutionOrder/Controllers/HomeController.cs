using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19_FilterExecutionOrder.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Filters.CustomActionFilters]
        [Filters.CustomResultFilters]
        [Filters.CustomExceptionFilters]
        [Filters.CustomAuthorizeFilter]
        public ActionResult Index()
        {
            return View();
        }

        [Filters.CustomActionFilters]
        [Filters.CustomResultFilters]
        [Filters.CustomExceptionFilters]
        [Filters.CustomAuthorizeFilter]
        public ActionResult About()
        {
            throw new Exception();
            return View();
        }

       
        public ActionResult OnExceptionFire()
        {
            return View();
        }
    }
}