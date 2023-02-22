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
        public DbSet<Category> Categories { get; set; }

        //Seeding in three rows for the database.
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Horror" },
                new Category { CategoryID = 4, CategoryName = "Drama" },
                new Category { CategoryID = 5, CategoryName = "Chick Flick" }
                );

            mb.Entity<Movie>().HasData(

                new Movie
                {
                    movieId = 1,
                    categoryId = 1,
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
                    categoryId = 1,
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
                    categoryId = 3,
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
