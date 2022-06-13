namespace ExamSecondTry.View.DisplayManager.Interfaces
{
    public interface IMenuDisplay
    {
        void ClearScreen();
        void PrintMessage(string content);
        void PrintOptions(List<string> options);
    }
}
