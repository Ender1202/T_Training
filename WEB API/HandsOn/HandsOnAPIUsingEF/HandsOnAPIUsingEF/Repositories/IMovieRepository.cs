using HandsOnAPIUsingEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAPIUsingEF.Repositories
{
    internal interface IMovieRepository
    {
        void AddMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(int movieId);
        Movie GetMovie(string movieName);
        List<Movie> GetMoviesByActor(string actor);
        List<Movie> GetMoviesByYear(int year);
    }
}
