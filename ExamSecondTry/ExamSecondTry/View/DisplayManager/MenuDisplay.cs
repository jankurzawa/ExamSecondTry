using ExamSecondTry.View.DisplayManager.Interfaces;
using static System.Console;

namespace ExamSecondTry.View.DisplayManager
{
    public class MenuDisplay : IMenuDisplay
    {
        public void ClearScreen() => Clear();

        public void PrintMessage(string message) => WriteLine(message);

        public void PrintOptions(List<string> options) => options.ForEach(o => WriteLine(o));
    }
}
