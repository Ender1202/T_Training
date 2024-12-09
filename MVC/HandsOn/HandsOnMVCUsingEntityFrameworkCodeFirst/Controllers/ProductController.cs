using HandsOnMVCUsingEntityFrameworkCodeFirst.Entities;
using HandsOnMVCUsingEntityFrameworkCodeFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnMVCUsingEntityFrameworkCodeFirst.Controllers
{
   
    public class ProductController : Controller
    {
        private ProductRepository _productRepository;
        public ProductController()
        {
            _productRepository= new ProductRepository();
        }
        // GET: Product
       
        public ActionResult Index() //Get All Products
        {
            var products= _productRepository.GetAll();
            return View(products);
        }
        public ActionResult Details(string id)
        {
            var product=_productRepository.Get(id); 
            return View(product);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            _productRepository.Add(product);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string id)
        {
            var product=_productRepository.Get(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            _productRepository.Edit(product);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id)
        {
            _productRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}