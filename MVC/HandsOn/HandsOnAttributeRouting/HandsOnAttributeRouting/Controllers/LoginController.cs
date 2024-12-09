using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("Login")]
    public class LoginController : Controller
    {
        // GET: Login
        [Route("Validate")]
        public ActionResult Index()
        {
            return View();
        }
        [Route]
        public ActionResult Show()
        {
            return View();
        }
    }
}