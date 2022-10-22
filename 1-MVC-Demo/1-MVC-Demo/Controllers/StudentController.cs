using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_MVC_Demo.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        //http://localhost:58721/Student/index/1?name=madhv
        public string Index(string Id,string name)
        {

            return "Student Id:-" + Id + " Name:-" + name;

        }

    }
}
