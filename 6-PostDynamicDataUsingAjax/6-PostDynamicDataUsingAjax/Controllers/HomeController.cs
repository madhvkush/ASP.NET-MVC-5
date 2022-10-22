using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_PostDynamicDataUsingAjax.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Foo(IDictionary<string, object> model)
        {
            //To get first key
            //model.Keys.First().ToString()
            //To get first value
            //model.Values.First().ToString()
            return Json(model);
        }

    }
}
