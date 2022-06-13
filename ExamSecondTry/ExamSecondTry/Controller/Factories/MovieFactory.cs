using ExamSecondTry.Controller.Factories.Interfaces;
using ExamSecondTry.Data.Entities;
using ExamSecondTry.View.InputManager.Interfaces;

namespace ExamSecondTry.Controller.Factories
{
    public class MovieFactory : IBaseFactory<Movie>
    {
        private IInputSystem InputSystem;
        private Predicate<string> CheckIfProvideStringIsCorrectForSongAttribute;
        private Predicate<string> CheckIfProvideLengthIsCorrectForSongAttribute;

        public MovieFactory(IInputSystem inputSystem)
        {
            InputSystem = inputSystem;
            CheckIfProvideStringIsCorrectForSongAttribute = value => value.Length > 0 && value != null;
            CheckIfProvideLengthIsCorrectForSongAttribute = value => value.Length > 3 && value[^3] == '.' 
                && double.TryParse(value, out double result) && (double.Parse(value) % 1) < 0.60;
        }

        public Movie Create()
        {
            string title = null, director = null, review = null, length = null, confirming = "n";
            double parsedLength;
            do
            {
                title = InputSystem.FetchStringValueWithCondition("Title: ", CheckIfProvideStringIsCorrectForSongAttribute);
                director = InputSystem.FetchStringValueWithCondition("Director: ", CheckIfProvideStringIsCorrectForSongAttribute);
                review = InputSystem.FetchStringValueWithCondition("Review: ", CheckIfProvideStringIsCorrectForSongAttribute);
                length = InputSystem.FetchStringValueWithCondition("Length: (ex: 1.30 - means one and a half hour) ", CheckIfProvideLengthIsCorrectForSongAttribute);
                parsedLength = double.Parse(length);
                confirming = InputSystem.FetchStringValue("Confirm? [y] -yes / [n] - no");
            } while (confirming == "n");
            return new Movie(title, director, review, parsedLength);
        }
    }
}
