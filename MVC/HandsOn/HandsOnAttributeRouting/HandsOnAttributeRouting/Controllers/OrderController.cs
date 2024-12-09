using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        [Route(@"OrderById/{id:max(100):min(10)}")]
        public ViewResult OrderbyId(int id)
        {
            return View();
        }
        [Route(@"OrderPizza/{mobile:regex(^[789]\d{9}$)}")]
        public ViewResult TakeOrder(string mobile)
        {
            ViewData["Message"] = mobile + " Order is Success";
            return View();
        }
    }
}