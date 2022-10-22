using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index()
        {
            return "Hello in MVC-World";
        }

       
        public string GetDetails(string id)
        {
            return "GetDetails is Invoked";
        }


        public string RetriveDetails()
        {
            return "RetriveDetails is Invoked";
        }
    }
}
