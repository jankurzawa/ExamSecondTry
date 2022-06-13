using ExamSecondTry.Controller.Factories.Interfaces;
using ExamSecondTry.Data.DAL;
using ExamSecondTry.Data.DAL.Interfaces;
using ExamSecondTry.Data.Entities;
using ExamSecondTry.View.DisplayManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTry.Controller.Handlers
{
    public class MovieHandler
    {
        private IBaseRepository<Movie> MovieRepository;
        private IDisplay<Movie> MovieDisplay;
        private IBaseFactory<Movie> MovieFactory;
        public MovieHandler(IBaseRepository<Movie> movieRepository, IDisplay<Movie> movieDisplay, IBaseFactory<Movie> movieFactory)
        {
            MovieRepository = movieRepository;
            MovieDisplay = movieDisplay;
            MovieFactory = movieFactory;
        }

        public void AddNew()
        {
            var newMovie = MovieFactory.Create();
            MovieRepository.Add(newMovie);
            MovieRepository.Save();
        }

        public void DisplayAll() => MovieDisplay.DisplayList(MovieRepository.GetAll());


    }
}
