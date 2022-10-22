using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _8_UploadImage.Controllers
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
        public ActionResult UploadImage(HttpPostedFileBase MyImage)
        {
            if (MyImage != null)
            {


                string path = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                ViewBag.ImgName = MyImage.FileName;
                MyImage.SaveAs(path + Path.GetFileName(MyImage.FileName));
                Response.Write("file uploaded");
                return View("Index");
            }
            else { Response.Write("Not a image"); return View("Index"); }

        }

    }
}
