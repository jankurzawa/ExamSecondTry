using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTry.Model.Utils.CustomExceptions
{
    public class EmptyMovieListException : Exception
    {
        public EmptyMovieListException()
        {
            Console.WriteLine("EmptyMovieListException");
        }
        public EmptyMovieListException(string message) : base(message)
        {
        }

    }
}
