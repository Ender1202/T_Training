using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    [RoutePrefix("Products")]
    public class ProductController : Controller
    {
        //This will be translated to /products  

        [Route] //set as default action method
        public ActionResult List()
        {
            return View();
        }

        //This will be translated to /products/2  

        [Route("Details/{id?}")]
        public ActionResult Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return View("List");
            }

            return View("Details");
        }
        //route gets called as /products/productname  
        [Route("ProductbyName/{id:alpha}")]
        public ActionResult GetProduct(string id)
        {
            return View();
        }

        //route gets called as /products/2  
        [Route("ProductbyId/{id:int}")]
        public ActionResult GetProduct(int id)
        {
            return View();
        } 
        public ActionResult GetProductById()
        {
            return View();
        }
    }  
}