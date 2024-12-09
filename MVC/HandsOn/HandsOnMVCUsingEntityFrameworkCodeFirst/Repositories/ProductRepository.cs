using HandsOnMVCUsingEntityFrameworkCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnMVCUsingEntityFrameworkCodeFirst.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private OnlineECommContext _context;
        public ProductRepository()
        {
            _context = new OnlineECommContext();
        }
        public void Add(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(string id)
        {
            try
            {
                var product = _context.Products.SingleOrDefault(x => x.Id == id);
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Edit(Product product)
        {
            try
            {
                var obj = _context.Products.SingleOrDefault(x => x.Id == product.Id);
                obj.Price = product.Price;
                obj.Stock = product.Stock;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product Get(string id)
        {
            try
            {
                var product = _context.Products.Find(id);
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}