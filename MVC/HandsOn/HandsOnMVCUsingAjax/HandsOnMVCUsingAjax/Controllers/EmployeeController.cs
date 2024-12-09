using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HandsOnMVCUsingAjax.Models;
namespace HandsOnMVCUsingAjax.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAll()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee(){Eid=1,Ename="Rohan",Sal=12000,Desig="Programmer",JoinDate=DateTime.Now.ToLongDateString()},
                 new Employee(){Eid=1,Ename="Rohan",Sal=12000,Desig="Programmer",JoinDate=DateTime.Now.ToLongDateString()},
                  new Employee(){Eid=1,Ename="Rohan",Sal=12000,Desig="Programmer",JoinDate=DateTime.Now.ToLongDateString()},
                   new Employee(){Eid=1,Ename="Rohan",Sal=12000,Desig="Programmer",JoinDate=DateTime.Now.ToLongDateString()},
                   new Employee(){Eid=1,Ename="Rohan",Sal=12000,Desig="Programmer",JoinDate=DateTime.Now.ToLongDateString()},
                   new Employee(){Eid=1,Ename="Rohan",Sal=12000,Desig="Programmer",JoinDate=DateTime.Now.ToLongDateString()},
                 new Employee(){Eid=1,Ename="Rohan",Sal=12000,Desig="Programmer",JoinDate=DateTime.Now.ToLongDateString()}
            };
            return Json(list, JsonRequestBehavior.AllowGet);

        }
    }
}