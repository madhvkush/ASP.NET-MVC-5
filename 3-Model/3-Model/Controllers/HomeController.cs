using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_Model.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            _3_Model.Models.Student student = new Models.Student
            {
                StID=1,
                name="Madhv",
                course="B.Tech",
                age="23"
            
            };
            return View(student);//pass model object
        }

    }
}
