using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HandsOnMVCUisngActionResults.Models;
namespace HandsOnMVCUisngActionResults.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }
        public RedirectToRouteResult View1()
        {
            // return RedirectToAction("View2");
            // return RedirectToAction("Details", new Student() { Sid = 1, Sname = "Rohan" });
            // return RedirectToAction("About", "Home");
            return RedirectToAction("Details", "Home",new Student() { Sid = 1, Sname = "Rohan" });
        }
        public ViewResult View2()
        {
            return View();
        }
        public ViewResult Details(Student s)
        {
            return View(s);

        }
        public ViewResult Search(int Id)
        {
            return View();
        }
        public RedirectResult View3()
        {
            // return Redirect("/Home/About");
            // return Redirect("Search/12");
            return Redirect("http://www.google.co.in");
        }
        public JsonResult GetString()

        {
            var content = "Json stands for Javascript Object Notation";
            return Json(content, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetFlowers()
        {
            List<string> list = new List<string>() { "Rose", "Lilly", "Marigole", "Tulip" };
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ContentResult Content1()
        {
            return Content("<h1>I love MVC Programming</h1>");
        }
        public ContentResult Content2()
        {
            return Content("<script>alert('Hello User')</script>");
        }
        public FileResult File1()
        {
            return File("~/ass.pdf", "text");
        }
        public EmptyResult Action1()
        {
            return null;
        }
        public PartialViewResult Partial()
        {
            return PartialView("_view1");
        }

    }
}