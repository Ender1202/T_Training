using HandsOnAPIUsingEF.Entities;
using HandsOnAPIUsingEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace HandsOnAPIUsingEF.Controllers
{
    public class MovieController : ApiController
    {
        private IMovieRepository repository;
        public MovieController()
        {
            repository = new MovieRepository();
        }
        [HttpGet,Route("GetMoviesByActor/{actor}")]
        public IHttpActionResult GetMoviesByActor(string actor)
        {
            try
            {
                var movies = repository.GetMoviesByActor(actor);
                return Ok(movies);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet, Route("GetMoviesByYear/{year}")]
        public IHttpActionResult GetMoviesByYear(int year)
        {
            try
            {
                var movies = repository.GetMoviesByYear(year);
                return Ok(movies);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet,Route("GetMovieByName/{name}")]
        public IHttpActionResult GetMovieByName(string name)
        {
            try
            {
                var movie = repository.GetMovie(name);
                return Ok(movie);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost, Route("AddMovie")]
        public IHttpActionResult Add([FromBody]Movie movie)
        {
            try
            {
                repository.AddMovie(movie);
                return Ok(movie);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut, Route("EditMovie")]
        public IHttpActionResult Edit([FromBody]Movie movie)
        {
            try
            {
                repository.UpdateMovie(movie);
                return Ok(movie);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete, Route("DeleteMovie/{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                repository.DeleteMovie(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
