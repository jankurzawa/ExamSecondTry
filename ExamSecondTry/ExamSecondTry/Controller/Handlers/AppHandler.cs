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
    public class AppHandler : BaseHandler<Movie>
    {
        private MovieHandler MovieHandler;
        public AppHandler(MovieHandler movieHandler, IMenuDisplay menuDisplay, IDisplay<Movie> display, IInputSystem inputSystem) 
            : base(menuDisplay, display, inputSystem)
        {
            MovieHandler = movieHandler;
        }

        protected override string[] GetAvailableCommands() 
            => new string[] {"1 - Add new movie", "2 - Display all movies", "3 - Display specific movie", "4 - Display the longest movie", 
                "5 - Display the shortest movie", "6 - Delete existing movie", "[quit] - to quit" };

        protected override void RunFeatureBasedOn(string option)
        {
            switch (option)
            {
                case "1":
                    MovieHandler.AddNew();
                    break;
                case "2":
                    MovieHandler.DisplayAll();
                    break;
                case "3":
                    MovieHandler.DisplaySpecificMovie();
                    break;
                case "4":
                    MovieHandler.DisplayMovieFromSortedList("last");
                    break;
                case "5":
                    MovieHandler.DisplayMovieFromSortedList("first");
                    break;
                case "6":
                    MovieHandler.DeleteMovie();
                    break;
                case "quit":
                    break;
                default:
                    InputSystem.FetchStringValue($"'{option}' option not found. Press enter to continue");
                    break;
            }
        }
    }
}
