using HandOnAPIUsingModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandOnAPIUsingModels.Repositories
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product { Id = 1,Name="Pen",Description="Sample Product",Price=20 },
            new Product { Id = 2,Name="Book",Description="Sample Product",Price=40 },
            new Product { Id = 3,Name="Bottle",Description="Sample Product",Price=60 },
            new Product { Id = 4,Name="Choclate",Description="Sample Product",Price=120 },
        };
        public void Add(Product product)
        {
            products.Add(product);
        }
        public void Update(Product product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if(products[i].Id == product.Id)
                {
                    products[i].Name = product.Name;
                    products[i].Description = product.Description;
                    products[i].Price = product.Price;
                }
            }
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public Product GetProductById(int id)
        {
            return products.SingleOrDefault(p => p.Id == id);
        }
        public void Delete(int id)
        {
            products.Remove(products.SingleOrDefault(x => x.Id == id));
        }
    }
}