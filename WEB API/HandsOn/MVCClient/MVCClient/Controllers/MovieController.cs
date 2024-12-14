using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using MVCClient.Models;
using Newtonsoft.Json;
using System.Xml.Linq;
using MVCClient.Services;
namespace MVCClient.Controllers
{
    [RoutePrefix("Movies")]
    public class MovieController : Controller
    {
        HttpClient client;
        MovieService movieService;
        public MovieController()
        {
            movieService = new MovieService();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:62010/"); //set api server address
        }
        // GET: Movie
        [Route("GetMoviesByYear/{year}")]
        public ActionResult GetMoviesByYear(int year=2024)
        {
            var movies=movieService.GetMoviesByYear(year);
            return View(movies);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movies movies)
        {
            if (ModelState.IsValid)
            {
                //convert model data to json
                var content = new StringContent(JsonConvert.SerializeObject(movies),
                   System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("AddMovie", content).Result;
                return RedirectToAction("GetMoviesByYear", new { year=2024});
            }
            else
            {
                return View();
            }
        }
        public ActionResult Edit(string name)
        {
            HttpResponseMessage response = client.GetAsync("GetMovieByName/"+name).Result;
            //convert response data to List<Movie> object
            Movies movies = JsonConvert.DeserializeObject<Movies>(response.Content.ReadAsStringAsync().Result);
            return View(movies);
        }
        [HttpPost]
        public ActionResult Edit(Movies movies)
        {
            if (ModelState.IsValid)
            {
                //convert model data to json
                var content = new StringContent(JsonConvert.SerializeObject(movies),
                   System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync("EditMovie", content).Result;
                return RedirectToAction("GetMoviesByYear", new { year = 2024 });
            }
            else
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                HttpResponseMessage response = client.DeleteAsync("DeleteMovie/" + id).Result;
                return RedirectToAction("GetMoviesByYear", new { year = 2024 });
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }

    }
}