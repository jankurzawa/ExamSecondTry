using ExamSecondTry.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTry.Data.Context.Seeders
{
    public static class MovieSeeder
    {
        public static void SeedDatabase(this ModelBuilder builder)
        {
            List<Movie> movies = new();

            movies.Add(new Movie("Titanic", "James Cameron", "Boring", 3.14));
            movies.Add(new Movie("Avatar", "James Cameron", "Nice", 2.40));
            movies.Add(new Movie("The Wolf Of Wall Street", "Martin Scorsese", "average", 3.00));
            
            builder.Entity<Movie>().HasData(movies);
        }
    }
}
