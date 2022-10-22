using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutpuCache.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public DateTime CurrentDateTime()
        {
            return DateTime.Now;
        }

        [ChildActionOnly] // not neccessary to make the ouputcahe a child method but to prevent direct invocation make it child.
       // [OutputCache(Duration=5)] 
        [OutputCache(CacheProfile = "10SecondsCahe")] // can use defined cacheProfile defined in web.config
        public DateTime CachedDateTime()
        {
            return DateTime.Now;
        }
    }
}
