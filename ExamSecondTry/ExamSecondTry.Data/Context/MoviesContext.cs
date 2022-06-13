using ExamSecondTry.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
