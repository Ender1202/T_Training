using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HandsOnMVCUsingAjax.Repositories;
using HandsOnMVCUsingAjax.Models;
namespace HandsOnMVCUsingAjax.Controllers
{
    public class ProductController : Controller
    {
        ProductRep db = new ProductRep();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAll()
        {
            return Json(db.GetAll(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetById(int Id)
        {
            Product p = null;
                p=db.GetById(Id);
                return Json(p, JsonRequestBehavior.AllowGet);
           
        }
        public JsonResult Add(Product p)
        {
            db.Add(p);
            return Json("Record is Added",JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update(Product p)
        {
            db.Update(p);
            return Json("Record is Updated", JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int id)
        {
            db.Delete(id);
            return Json("Record is Deleted", JsonRequestBehavior.AllowGet);
        }
    }
};