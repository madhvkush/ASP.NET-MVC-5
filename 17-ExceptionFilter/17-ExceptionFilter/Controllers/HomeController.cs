using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17_ExceptionFilter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Filters.CustomExceptionFilter]
        public ActionResult Index()
        {
            throw new Exception();
            return View();
        }
    }
}