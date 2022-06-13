using ExamSecondTry.View.DisplayManager.Interfaces;
using ExamSecondTry.View.InputManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTry.Controller.Handlers
{
    public abstract class BaseHandler <T> where T : class
    {
        protected IMenuDisplay MenuDisplay;
        protected IDisplay<T> Display;
        protected IInputSystem InputSystem;
        protected string[] options;

        public BaseHandler(IMenuDisplay menuDisplay, IDisplay<T> display, IInputSystem inputSystem)
        {
            MenuDisplay = menuDisplay;
            Display = display;
            InputSystem = inputSystem;
            options = GetAvailableCommands();
        }

        public void Run()
        {
            string userInput = "";
            while (!userInput.Equals("quit"))
            {
                MenuDisplay.ClearScreen();
                MenuDisplay.PrintOptions(new List<string>(options));
                userInput = InputSystem.FetchStringValue("Provide option ");
                RunFeatureBasedOn(userInput);
                InputSystem.FetchStringValue("Press enter to continue");
                MenuDisplay.ClearScreen();
            }
        }
        protected abstract void RunFeatureBasedOn(string option);
        protected abstract string[] GetAvailableCommands();
    }
}
