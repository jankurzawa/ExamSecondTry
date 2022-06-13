namespace ExamSecondTry.Model.Utils.CustomExceptions
{
    public class EmptyMovieListException : Exception
    {
        public EmptyMovieListException()
        {
            Console.WriteLine("EmptyMovieListException");
        }
    }
}
