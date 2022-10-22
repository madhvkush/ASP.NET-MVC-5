using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7_PostTightcoupledView.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [HttpGet]
        public ActionResult Index()
        {
            var dpt=new Models.Departments(){DepartHead="Akhilesh",DepartName="IT"};
            

            var obj = new _7_PostTightcoupledView.Models.EmployeeInfo()
            {
                User = new Models.UserInfo { Name = "Madhv", Email = "Kushwanshb.tech@gmail.com", Mobile = "9717672629" },
                Depart = dpt,
                Epmloyee="Babu"
            };
            return View(obj);
        }

        [HttpPost]
        public string Index(_7_PostTightcoupledView.Models.EmployeeInfo emp)
        {
            return emp.Depart.DepartHead;
        }

    }
}
