using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        [Route("List")]
        public ActionResult List()
        {
            return View();
        }
        [Route("Details/{id?}")]
        public ActionResult Details(string id)
        {
            //if (string.IsNullOrEmpty(id))
            //{
            //    return View("List");
            //}

            return View("Details");
        }
        [Route("Student/GetStudent/{id?}")]
        public ActionResult GetStudent(int ? id)
        {
            return View();
        } 

    }
}