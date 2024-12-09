using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("menu")]
    [Route("{action}")]
    public class MenuController : Controller
    {
        // route: /admin/menu/login
        public ActionResult Login()
        {
            return View();
        }

        // route: /admin/menu/products
        [Route("products")]
        public ActionResult GetProducts()
        {
            return View();
        }

        // route: /categories
        [Route("~/categories")]
        public ActionResult Categories()
        {
            return View();
        }

        [Route("customers/{customerId}/orders")]
        public IEnumerable<string> GetOrdersByCustomer(int customerId)
        {
            return null;
        }
    }
}