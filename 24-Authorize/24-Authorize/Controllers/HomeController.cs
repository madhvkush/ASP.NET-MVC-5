using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23_Authorize.Controllers
{
    // if you want to access this controller through anonymous than comment below
    // [Authorize(Users = @"Madhv-Office-PC\Madhv-Office")]
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

        //we want to allow this action under the Madhv-Office user log-in
        [Authorize(Users=@"Madhv-Office-PC\Madhv-Office")]
        public ActionResult Secured()
        {
            return View();
        }
    }
}