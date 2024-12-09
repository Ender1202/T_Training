using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnMVCPassingDataBetweenActionToView.Controllers
{
    public class Demo2Controller : Controller
    {
        // GET: Demo2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult View1()
        {
            int flag = 398434;
            //set value in TempData
            TempData["flag"] = flag;
            // return RedirectToAction("View2"); //Redirect to View2
            return RedirectToAction("Details", "Demo1");
        }
        public ActionResult View2()
        {
            return View();
        }
    }
}