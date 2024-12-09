using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    [RoutePrefix("MyHome")]
    [Route("{action=Index}")]
    public class Demo1Controller : Controller
    {
        //new route: /MyHome/Index 
        public ActionResult Index()
        {
            return View();
        }

        //new route: /MyHome/About 
        [Route("mysite/about")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        //new route: /MyHome/Contact 
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page."; return View();
        }
    }
}