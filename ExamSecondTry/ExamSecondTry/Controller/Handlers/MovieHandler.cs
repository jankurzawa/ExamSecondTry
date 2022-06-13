using ExamSecondTry.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTry.Controller.Handlers
{
    public class MovieHandler
    {
        private MovieRepository movieRepository;
        public MovieHandler()
        {
            movieRepository = new();
        }
    }
}
