using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    [RouteArea("PostArea")]
    public class Demo6Controller : Controller
    {
        // GET: Demo6
        public ActionResult Index()
        {
            return View();
        }
    [Route("Category/{id}/Orders/Details/{name}")]
        public ActionResult Orders(string id,string name)
        {
            return View();
        }
    }
}