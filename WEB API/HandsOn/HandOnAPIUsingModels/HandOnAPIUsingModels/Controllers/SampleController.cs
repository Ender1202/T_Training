using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HandOnAPIUsingModels.Controllers
{
    //[RoutePrefix("{[controller]}")]
    [RoutePrefix("api/{[controller]}")]
    public class SampleController : ApiController
    {
        //endpoints
        List<string> flowers = new List<string>() { "Rose", "Lilly", "Jasmine" };
        [HttpGet,Route("GetFlowers")]
        //Get  api/Sample
        public List<string> LoadFlowers()
        {   
            return flowers;
        }
        [HttpGet,Route("GetCities")]
        public List<string> Cities()
        {
            return new List<string> { "Chennai", "Pune", "Delhi", "Hyderabad" };
        }
    }
}
