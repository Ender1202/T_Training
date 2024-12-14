using MVCClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace MVCClient.Services
{
    public class MovieService
    {
        HttpClient client;
        public MovieService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:62010/"); //set api server address

        }
        public List<Movies> GetMoviesByYear(int year)
        {
            //response hold the json resust retrun by the givne endpoint
            HttpResponseMessage response = client.GetAsync("GetMoviesByYear/" + year).Result;
            //convert response data to List<Movie> object
            List<Movies> movies = JsonConvert.DeserializeObject<List<Movies>>(response.Content.ReadAsStringAsync().Result);
            return movies;
        }
    }
}