using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        //action method
        public string Hello()
        {
            return "Hello MVC Users!!!";
        }
        public string Greet(string name)
        {
            return "Hello " + name;
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public List<string> GetCountries()
        {
            return new List<string> { "India", "China", "Japan", "US" };
        }
        public ActionResult Info() //return viewpage as a response
        {
            return View();
        }

    }
}