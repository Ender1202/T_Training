using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    [RouteArea("PostArea")]
    [RoutePrefix("Post")]
    [Route("{action=index}")] 
    public class Demo5Controller : Controller
    {
        // URL: /PostArea/Category/
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC Routing!";
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}