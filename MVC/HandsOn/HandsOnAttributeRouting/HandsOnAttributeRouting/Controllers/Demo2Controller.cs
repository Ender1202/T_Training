using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    //Action level attribute routing
    public class Demo2Controller : Controller
    {
        [Route("users/{id:int:min(100):max(300)}")] //route: /users/100
        //[Route("users/{id}")] //users/10
        //[Route("users/{id ?}")]
        public ActionResult Index(int? id)
        {
            //TO DO:
            return View();
        }

        [Route("users/about")] //route" /users/about
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        //route: /Demo2/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}