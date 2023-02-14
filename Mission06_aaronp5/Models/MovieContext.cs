using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_aaronp5.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<Movie> movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(

                new Movie
                {
                    movieId = 1,
                    category = "Action",
                    title = "Indiana Jones",
                    director = "Steven Spielberg",
                    rating = "PG-13",
                    edited = true,
                    lentTo = "Jack",
                    note = "Nothing much"
                },
                new Movie
                {
                    movieId = 2,
                    category = "Comdey",
                    title = "Home Alone",
                    director = "Chris Columbus",
                    rating = "PG",
                    edited = true,
                    lentTo = "John",
                    note = "Boring"

                },
                new Movie
                {
                    movieId = 3,
                    category = "Action",
                    title = "Jaws",
                    director = "Steven Spielberg",
                    rating = "PG-13",
                    edited = true,
                    lentTo = "James",
                    note = "Sharks"

                }
               );
        }
    }
}
