using HandOnAPIUsingModels.Models;
using HandOnAPIUsingModels.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Results;

namespace HandOnAPIUsingModels.Controllers
{
    public class ProductController : ApiController
    {
        private ProductRepository repository;
        public ProductController()
        {
            repository = new ProductRepository();
        }
        [HttpGet,Route("GetAllProducts")]
        public IHttpActionResult GetAll()
        {
            var products=repository.GetProducts();
            return Ok(products); //retunr products in the json form
        }
        [HttpGet, Route("GetProductById/{id}")]
        public IHttpActionResult Get(int id)
        {
            var product = repository.GetProductById(id);
            return Ok(product);
        }
        [HttpPost, Route("AddProduct")]
        public IHttpActionResult Add([FromBody]Product product)
        {
            repository.Add(product);
            return Ok(product);
        }
        [HttpPut, Route("EditProduct")]
        public IHttpActionResult Edit([FromBody] Product product)
        {
            repository.Update(product);
            return Ok(product);
        }
        [HttpDelete, Route("DeleteProduct/{id}")]
        public IHttpActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok("Record Deleted");
        }
    }
}
