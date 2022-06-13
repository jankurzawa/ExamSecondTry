﻿using ExamSecondTry.Controller.Factories.Interfaces;
using ExamSecondTry.Data.DAL.Interfaces;
using ExamSecondTry.Data.Entities;
using ExamSecondTry.View.DisplayManager.Interfaces;
using ExamSecondTry.View.InputManager.Interfaces;

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
        public void DisplayTheShortestMovie() 
        {
            var allMovies = MovieRepository.GetAll().OrderBy(m => m.Length).ToList();
            if (allMovies.Count == 0) return; //throw
            else MovieDisplay.DisplaySingle(allMovies.First());
        }
        public void DisplayTheLongestMovie()
        {
            var allMovies = MovieRepository.GetAll().OrderBy(m => m.Length).ToList();
            if (allMovies.Count == 0) return; //throw
            else MovieDisplay.DisplaySingle(allMovies.Last());
        }
        public void DeleteMovie()
        {
            var movieToRemove = GetMovie();
            if (movieToRemove != null)
            {
                MovieRepository.Delete(movieToRemove);
                MovieRepository.Save();
            }
        }
        private Movie? GetMovie()
        {
            var option = Inputsystem.FetchStringValue("By what attribute do you want to choose the movie? [t] - title\n[d] - director");
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
