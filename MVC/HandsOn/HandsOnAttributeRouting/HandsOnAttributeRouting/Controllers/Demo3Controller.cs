using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    public class Demo3Controller : Controller
{
  // Optional URI Parameter
  // URL: /Category/
  // URL: /Category/MVC
        [Route("Product/Category/{ categoryName?}")]
        public ActionResult Show(string categoryName)
        {
            ViewBag.Message = "This is Attribute Routing with Optional Parameter ASP.NET MVC!";
            return View();
        }
   // Optional URI Parameter with default value
// URL: /Category/
  // URL: /Category/MVC
    [Route("Product/Categories/{ categoryName =MVC}")]
    public ActionResult Show1(string categoryName){
        ViewBag.Message = "This is Attribute Routing with Default ValueASP.NET MVC!";
        return View();
    }
}
}
