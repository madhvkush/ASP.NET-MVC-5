using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23_Authorize.Controllers
{
     [Authorize(Users = @"Madhv-PC\Madhv")]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Users=@"Madhv-PC\Madhv")]
        public ActionResult Secured()
        {
            return View();
        }
    }
}