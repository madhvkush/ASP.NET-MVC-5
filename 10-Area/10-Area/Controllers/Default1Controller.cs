using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10_Area.Controllers.DiffrentNameSpace
{
    public class HomeController : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            ViewBag.ComeThrough = "Diffenret NameSpce";
            return View();
            
        }

    }
}
