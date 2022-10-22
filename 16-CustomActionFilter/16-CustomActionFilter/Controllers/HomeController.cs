using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_CustomActionFilter.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


      [_16_CustomActionFilter.Filter.MyCustomCode]
        public string Index()
        {
            string before = RouteData.Values["before"].ToString();
            //string after = RouteData.Values["after"].ToString();
            return before ;

        }

    }
}
