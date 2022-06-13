using ExamSecondTry.Data.Entities;
using ExamSecondTry.View.DisplayManager.Interfaces;
using static System.Console;

namespace ExamSecondTry.View.DisplayManager
{
    public class MovieDisplay : IDisplay<Movie>
    {
        public void DisplayList(List<Movie> entities) => entities.ForEach(e => DisplaySingle(e));

        public void DisplaySingle(Movie entity) 
            => WriteLine($"Title:\t{entity.Title}|Director\t{entity.Director}|Review:\t{entity.Review}|Length:\t{entity.Length}");
    }
}
