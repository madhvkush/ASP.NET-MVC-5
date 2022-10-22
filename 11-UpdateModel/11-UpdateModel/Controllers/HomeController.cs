using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _11_UpdateModel.Controllers
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
        [ActionName("Index")]  //action selector for calling the action by name of Index
        public ActionResult Index_POST()
        {
            // fetch the object from database.
          var std=  new Models.Student
                {
                    StudentId = 1,
                    name = "Madhv",
                    mobile = string.Empty
                };

            // now update the posted properties
          UpdateModel(std, includeProperties: new string[]{"mobile"}); // it will update the mobile number which is entered from view.
            return View("StudentInfo",std);
        }

    }
}
