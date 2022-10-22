using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17_ExceptionFilter.Controllers
{
    [Filters.CustomExceptionFilter]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View("AdminDetail");
        }

        [HttpGet]
        public ActionResult AdminDetail()
        {
            throw new Exception();
            return View();
        }

    }
}