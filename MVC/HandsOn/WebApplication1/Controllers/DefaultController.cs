using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        MyContext _context=new MyContext();
        // GET: Default
        public ActionResult Index()
        {
            var products=_context.Products;
            return View(products);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}