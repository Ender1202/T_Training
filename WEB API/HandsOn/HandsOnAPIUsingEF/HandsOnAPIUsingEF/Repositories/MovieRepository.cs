using HandsOnAPIUsingEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnAPIUsingEF.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private MovieContext context;
        public MovieRepository()
        {
            context = new MovieContext();
        }
        public void AddMovie(Movie movie)
        {
            try
            {
                context.Movies.Add(movie);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteMovie(int movieId)
        {
            try
            {
                var movie = context.Movies.Find(movieId);
                if (movie != null)
                {
                    context.Movies.Remove(movie);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Movie GetMovie(string movieName)
        {
            try
            {
                var movie = context.Movies.SingleOrDefault(m => m.Title == movieName);
                return movie;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movie> GetMoviesByActor(string actor)
        {
            try
            {
                var movies = context.Movies.Where(m => m.Actor == actor).ToList();
                return movies;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movie> GetMoviesByYear(int year)
        {
            try
            {
                var movies = context.Movies.Where(m => m.ReleaseDate.Year == year).ToList();
                return movies;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateMovie(Movie movie)
        {
            try
            {
                var editMovie = context.Movies.Find(movie.MovieId);
                editMovie.Actor = movie.Actor;
                editMovie.Director = movie.Director;
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}