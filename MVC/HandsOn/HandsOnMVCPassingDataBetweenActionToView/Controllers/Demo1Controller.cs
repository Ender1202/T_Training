using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnMVCPassingDataBetweenActionToView.Controllers
{
    public class Demo1Controller : Controller
    {
        // GET: Demo1
        public ActionResult Index()
        {
            ViewBag.Message = "ViewBag Demo";
            List<string> list = new List<string>() { "Pune", "Mumbai", "Hyderabad", "Chennai", "Delhi" };
            //set value in ViewBag
            ViewBag.Cities = list;
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}