using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandsOnMVCUsingAjax.Models;
namespace HandsOnMVCUsingAjax.Repositories
{
    public class ProductRep
    {
        static List<Product> list = new List<Product>()
        {
            new Product(){Pid=1,Pname="Mouse",Price=300,Stock=20},
            new Product(){Pid=2,Pname="Keyboard",Price=300,Stock=20},
            new Product(){Pid=3,Pname="Pendrive",Price=300,Stock=20},
            new Product(){Pid=4,Pname="JoyStick",Price=300,Stock=20}
        };
        public List<Product> GetAll()
        {
            return list;
        }
        public Product GetById(int Id)
        {
            return list.SingleOrDefault(i => i.Pid == Id);
        }
        public void Add(Product p)
        {
            list.Add(p);
        }
        public void Delete(int Id)
        {
            list.Remove(list.SingleOrDefault(i => i.Pid == Id));
        }
        public void Update(Product p)
        {
            list.Remove(list.SingleOrDefault(i => i.Pid == p.Pid)); //delete existing
            list.Add(p);//add new 
        }
    }
}