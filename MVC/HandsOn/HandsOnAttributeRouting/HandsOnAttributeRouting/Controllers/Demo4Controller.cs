using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    [RoutePrefix("Category")]
    public class Demo4Controller : Controller
    {
        // URL: /Category/
        [Route]
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Dot Net Stuff!";
            return View();
        }
        // Optional URI Parameter
        // URL: /Category/
        // URL: /Category/MVC
        [Route("{ categoryName }")]
        public ActionResult Show(string categoryName)
        {
            ViewBag.Message = "Welcome to ASP.NET MVC Category!";
            return View();
        }
    }
}