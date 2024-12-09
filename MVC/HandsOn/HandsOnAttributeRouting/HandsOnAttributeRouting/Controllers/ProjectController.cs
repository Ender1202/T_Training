using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }
        [Route("GP/{*id:DateTime}")]
        public ActionResult GetProjectByDate(DateTime id)
        {
            return View();
        }
    }
}