using System;
using System.Collections.Generic;
using System.IO;
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
            string extName = Path.GetExtension(file.FileName);
            if (file.ContentType == "image/jpeg" || file.ContentType == "image/jpg" || file.ContentType == "image/png"
            )
            {
                Random r = new Random();
                //给文件取新名字
                string fileName = DateTime.Now.ToString("yyyy-MM-dd") + r.Next(100, 1000) + extName;
                //用户文件夹的物理路径（绝对路径）                   
                String virthPath = "/upload/" + fileName;
                String name = Server.MapPath(virthPath);
                file.SaveAs(name);
               // return Content(virthPath);
                return Content(virthPath );
            }
            else
            {
                return Content("typeError");
            }

           // file.SaveAs(Server.MapPath("/upload/")+file.FileName);
           // return Content(file.FileName+"上传成功！");
        }
    }
}
