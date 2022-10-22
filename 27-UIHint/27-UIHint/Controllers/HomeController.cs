using _27_UIHint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _27_UIHint.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee
            {
                Name = "MKS",
                BirthDate = DateTime.Now,
                EmployeeID = 1,
                JoiningDate = DateTime.Now,
                Mobile="9717672629"
            });
            empList.Add(new Employee
            {
                Name = "DKS",
                BirthDate = DateTime.Now,
                EmployeeID = 2,
                JoiningDate = DateTime.Now,
                Mobile = "8445333589"
            });

            Employee emp = empList.Find(e => e.EmployeeID == 1);
            return View(emp);
        }
    }
}