using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    public class HomeController : Controller
    {
       [Route("Home/GetAll")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("mysite/employee/about")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}