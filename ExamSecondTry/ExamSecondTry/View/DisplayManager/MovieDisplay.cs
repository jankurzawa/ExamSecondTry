using ExamSecondTry.Data.Entities;
using ExamSecondTry.View.DisplayManager.Interfaces;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTry.View.DisplayManager
{
    public class MovieDisplay : IDisplay<Movie>
    {
        public void DisplayList(List<Movie> entities) => entities.ForEach(e => DisplaySingle(e));

        public void DisplaySingle(Movie entity) => WriteLine($"Title:\t{entity.Title}|Director\t{entity.Director}|Review:\t{entity.Review}|Length:\t{entity.Length}");
    }
}
