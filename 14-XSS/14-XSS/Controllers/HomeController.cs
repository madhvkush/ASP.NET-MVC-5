using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _14_XSS.Controllers
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
        [ValidateInput(false)]
        public ActionResult Index(string comments)
        {
            //encode html input
            var encodedComment = HttpUtility.HtmlEncode(comments);
            //create string builder and replace the html tag
            StringBuilder sbcomment = new StringBuilder();
            sbcomment.Append(encodedComment);
            sbcomment.Replace("&lt;b&gt;", "<b>");
            sbcomment.Replace("&lt;/b&gt;", "</b>");
            sbcomment.Replace("&lt;u&gt;", "<u>");
            sbcomment.Replace("&lt;/u&gt;", "</u>");


            //var result = new _14_XSS.Models.Mycomments { comments = sbcomment.ToString() };
            var result = sbcomment.ToString();

            return RedirectToAction("Comments", result);
        }

        public ActionResult Comments(string comment)
        {
            return View("Comments", comment);
        }
    }
}
