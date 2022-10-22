using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5_DataEntryScreen.Models;

namespace _5_DataEntryScreen.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult DisplayCustomer()
        {
            Customer objCustomer = new Customer();
            objCustomer.Custname = Request.Form["Custname"].ToString();
            objCustomer.CustomerCode = Request.Form["CustomerCode"].ToString();
            objCustomer.Amount = Convert.ToDouble(Request.Form["Amount"].ToString()); ;
            return View("DisplayCustomer", objCustomer); // it will return exactly to specified view
        }

    }
}
