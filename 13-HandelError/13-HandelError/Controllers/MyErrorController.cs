using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _13_HandelError.Controllers
{
    public class MyErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult MyPageNotFound()
        {
            return View();
        }

    }
}
