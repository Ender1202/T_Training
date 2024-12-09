using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace HandsOnAPIUsingEF.Entities
{
    public class MovieContext:DbContext
    {
        public MovieContext():base("MovieConnection")
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }

    }
}