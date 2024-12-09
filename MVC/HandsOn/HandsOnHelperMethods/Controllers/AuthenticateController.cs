using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnHelperMethods.Controllers
{
    public class AuthenticateController : Controller
    {
        // GET: Authenticate
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Validate(string Uname,string Pwd)
        {
            if(Uname=="Virat" &&  Pwd=="12345")
            {
                return RedirectToAction("Welcome");
            }
            else
            {
                ViewBag.Error = "Invalid Credentials";
                return View("Login"); //stay in the Login View
            }
        }
    }
}