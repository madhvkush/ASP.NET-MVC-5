using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace NonAction_ChilActionOnly.Controllers
{
    public class HomeController : Controller
    {
        public List<Models.Person> PRepository = new List<Models.Person>();
        

        public ActionResult Index()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult Index(int a, int b)
        {
            this.ADD(a, b);
            return View();
        }

        [NonAction] // now can't directly invoked by url.
        public ActionResult ADD(int a, int b)
        {
            var result = a + b;
            ViewBag.result = result;
            return View("abc"); //doesn't matter. because control of execution return to above Index method.

            //return RedirectToAction("Index");
            
        }

        [ChildActionOnly] // its also can't directly invoked by URL but can be invoked by ACtion or RenderAction.
        public string ChildAction()
        {
            return "Hello this is child action only";
        }

        [ChildActionOnly]
        [ValidateInput(false)]
        public string GetPerson()
        {
            //PRepository.Add(new Models.Person { PersonId = 1, Name = "John", Mobile = "9717672629" });
            //PRepository.Add(new Models.Person { PersonId = 2, Name = "Adam", Mobile = "8445333589" });
            //PRepository.Add(new Models.Person { PersonId = 3, Name = "Merry", Mobile = "9837060997" });
            //return PRepository.Where(p => p.PersonId == 1).FirstOrDefault();

            return new JavaScriptSerializer().Serialize(new Models.Person { PersonId = 1, Name = "John", Mobile = "9717672629" });
        }
    }
}
