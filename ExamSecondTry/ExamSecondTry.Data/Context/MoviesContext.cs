using ExamSecondTry.Data.Context.Seeders;
using ExamSecondTry.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamSecondTry.Data.Context
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Movies;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedDatabase();
        }
    }
}
