using ExamSecondTry.Controller.Factories.Interfaces;
using ExamSecondTry.Data.DAL;
using ExamSecondTry.Data.DAL.Interfaces;
using ExamSecondTry.Data.Entities;
using ExamSecondTry.View.DisplayManager.Interfaces;
using ExamSecondTry.View.InputManager.Interfaces;
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
        private IInputSystem Inputsystem;
        public MovieHandler(IBaseRepository<Movie> movieRepository, IDisplay<Movie> movieDisplay, IBaseFactory<Movie> movieFactory, IInputSystem inputsystem)
        {
            MovieRepository = movieRepository;
            MovieDisplay = movieDisplay;
            MovieFactory = movieFactory;
            Inputsystem = inputsystem;
        }

        public void AddNew()
        {
            var newMovie = MovieFactory.Create();
            MovieRepository.Add(newMovie);
            MovieRepository.Save();
        }

        public void DisplayAll() => MovieDisplay.DisplayList(MovieRepository.GetAll());
        public void DisplaySpecificMovie()
        {
            var searchedMovie = GetMovie();
            if (searchedMovie != null) MovieDisplay.DisplaySingle(searchedMovie);
        }
        public void DisplayMovieFromSortedList(Index index) => MovieDisplay.DisplaySingle(MovieRepository.GetAll().OrderBy(m => m.Length).ToList()[index]);

        
        private Movie? GetMovie()
        {
            var option = Inputsystem.FetchStringValue("By what attribute do you want to search for the movie? [t] - title\n[d] - director");
            var dateToSearch = Inputsystem.FetchStringValue("enter data: ");
            Movie searchedMovie = null;

            if (option == "t")
                searchedMovie = MovieRepository.GetSingle(m => m.Title == dateToSearch);
            else if (option == "d")
                searchedMovie = MovieRepository.GetSingle(m => m.Director == dateToSearch);
            else
            {
                Inputsystem.FetchStringValue("Not found. Press enter to continue.");
                return null;
            }
            return searchedMovie;
        }
    }
}
