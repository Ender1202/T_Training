using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnMVCUsingAjax.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetString()
        {
            string content = "Hello User";
            return Json(content, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Greet(string name)
        {
            string content = "Hello " + name;
            return Json(content,JsonRequestBehavior.AllowGet);
        }
    }
}