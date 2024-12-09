using HandsOnMVCUsingModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnMVCUsingModels.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>()
        {
            new Product(){Id=1,Name="Pen",Description="Sample Product",Price=20},
             new Product(){Id=2,Name="Book",Description="Sample Product",Price=50},
              new Product(){Id=3,Name="Pencil",Description="Sample Product",Price=10},
               new Product(){Id=4,Name="Choclate",Description="Sample Product",Price=20},
              new Product(){Id=5,Name="Bottle",Description="Sample Product",Price=40},
        };
        // GET: Product
        public ActionResult Index()
        {
            return View(products);
        }
        public ActionResult Details(int id=1)
        {
            var product = products.SingleOrDefault(p => p.Id == id);
            return View(product);
        }
        public ActionResult Show()
        {
            try
            {
                //initiate product
                Product product = new Product()
                {
                    Id = 1,
                    Name = "Bottle",
                    Description = "Sample Product",
                    Price = 100
                };
                return View(product);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        //add product details to List
        [HttpPost]
        public ActionResult Add(Product product)
        {
            products.Add(product);
            return RedirectToAction("Index"); //Redirected to Index action

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = products.SingleOrDefault(p => p.Id == id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if(products[i].Id == product.Id)
                {
                    products[i].Price = product.Price;
                }
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var product = products.SingleOrDefault(p => p.Id == id);
            products.Remove(product);
            return RedirectToAction("Index");
        }
    }
}