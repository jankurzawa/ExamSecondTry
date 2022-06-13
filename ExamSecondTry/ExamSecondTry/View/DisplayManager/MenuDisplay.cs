using ExamSecondTry.View.DisplayManager.Interfaces;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTry.View.DisplayManager
{
    public class MenuDisplay : IMenuDisplay
    {
        public void ClearScreen() => Clear();

        public void PrintMessage(string message) => WriteLine(message);

        public void PrintOptions(List<string> options) => options.ForEach(o => WriteLine(o));
    }
}
