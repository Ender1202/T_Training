using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnMVCPassingDataBetweenActionToView.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            string title = "Welcome back to MVC!!!";
            //set title value in viewData
            ViewData["key"] = title;
            string ename = "Rajan";
            ViewData["en"] = ename;
            return View();
        }
        public ActionResult Greet(string name)
        {
            ViewData["n"]=name;
            return View();
        }
        public ActionResult GetFlowers()
        {
            List<string> flowers = new List<string>() { "Rose", "Lilly", "Jasmine", "Tulips" };
            //set flowers in ViewData
            ViewData["flowers"] = flowers;
            return View();
        }
    }
}