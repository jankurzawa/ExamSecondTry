using ExamSecondTry.Data.Context;
using ExamSecondTry.Data.DAL.Interfaces;
using ExamSecondTry.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamSecondTry.Data.DAL
{
    public class MovieRepository : IBaseRepository<Movie>
    {
        private MoviesContext moviesContext;
        public MovieRepository() => moviesContext = new();
        public void Add(Movie entity) => moviesContext.Movies.Add(entity);
        public void Delete(Movie entity) => moviesContext.Movies.Remove(entity);
        public void Edit(Movie entity) => moviesContext.Movies.Update(entity);
        public List<Movie> GetAll() => moviesContext.Movies.AsNoTracking().ToList();
        public Movie GetSingle(Func<Movie, bool> condition) => moviesContext.Movies.Where(condition).FirstOrDefault();
        public void Save() => moviesContext.SaveChanges();
    }
}
