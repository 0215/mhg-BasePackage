using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Niunan.HTML5FileUpload.Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>单文件上传
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>多文件上传
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult MoreUpload() { return View(); }

        public ActionResult Upload() {
            HttpPostedFileBase file = Request.Files["fileToUpload"];
            file.SaveAs(Server.MapPath("/upload/")+file.FileName);
            return Content(file.FileName+"上传成功！");
        }
    }
}
