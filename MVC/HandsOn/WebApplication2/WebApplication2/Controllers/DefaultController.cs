using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using WebApplication2.Models;
using Newtonsoft.Json;
namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        HttpClient client;
        public DefaultController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:62010/");
        }
        // GET: Default
        public ActionResult Index()
        {
            HttpResponseMessage response = client.GetAsync("GetMoviesByYear/2024").Result;
            List<Movies> movies = JsonConvert.DeserializeObject<List<Movies>>(response.Content.ReadAsStringAsync().Result);

            return View(movies);
        }
    }
}