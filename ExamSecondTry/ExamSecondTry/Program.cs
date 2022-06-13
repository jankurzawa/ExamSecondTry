using ExamSecondTry.Controller.Factories;
using ExamSecondTry.Controller.Handlers;
using ExamSecondTry.Data.DAL;
using ExamSecondTry.View.DisplayManager;
using ExamSecondTry.View.InputManager;

namespace ExamSecondTry
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            MovieRepository movieRepository = new();
            MovieDisplay movieDisplay = new();
            InputManager inputSystem = new();
            MovieFactory movieFactory = new(inputSystem); 
            MovieHandler movieHandler = new(movieRepository, movieDisplay, movieFactory, inputSystem);
            MenuDisplay menuDisplay = new();
            AppHandler appHandler = new(movieHandler, menuDisplay, movieDisplay, inputSystem);
            appHandler.Run();
        }
    }
}