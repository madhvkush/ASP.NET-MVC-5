using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _4_Models_Entityframework.Models;

namespace _4_Models_Entityframework.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Index(int id)
        {
            StudentContext studentcontext = new StudentContext();
            Student student = studentcontext.students.Where(std => std.Id == id).SingleOrDefault();
            return View(student);
        }

    }
}
