using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieApplication.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("MA")
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
}