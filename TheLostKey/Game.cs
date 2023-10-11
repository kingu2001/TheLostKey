using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TheLostKey
{
    public class Game
    {
        public void Start()
        {
            RunMainMenu();
        }

        public void RunMainMenu()
        {
            string title = @"
_____  _     _____   _     ____  ____  _____    _  __ ________  _
/__ __\/ \ /|/  __/  / \   /  _ \/ ___\/__ __\  / |/ //  __/\  \//
  / \  | |_|||  \    | |   | / \||    \  / \    |   / |  \   \  / 
  | |  | | |||  /_   | |_/\| \_/|\___ |  | |    |   \ |  /_  / /  
  \_/  \_/ \|\____\  \____/\____/\____/  \_/    \_|\_\\____\/_/  

Welcome to the Lost Key.
(Use arrow keys to cycle through options and press enter to select an option.)";

            string[] options = { "Start", "Exit" };
            Menu mainMenu = new Menu(title, options);
            mainMenu.Run();
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }

        private void ExitGame()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("This game demo was created by Kiet Nguyen");
            WriteLine("This is just a demo... full game coming to console near you soon!");
            WriteLine("Press any key to return to the menu");
            ReadKey(true);
            RunMainMenu();
        }

        private void StartGame()
        {
            string prompt = "Hey Pal! Who are you?";
            string[] options = { "Red", "Green", "Blue", "Yellow" };
            Menu colorMenu = new Menu(prompt, options);
            int selectedIndex = colorMenu.Run();
            BackgroundColor = ConsoleColor.White;

            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("\nHere is red!");
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\n Here is green!");
                    break;
                case 2:
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("\n Here is blue");
                    break;
                case 3:
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\n Here is yellow");
                    break;

            }
            ResetColor();
            WriteLine("That is it for now...");
            ExitGame();
        }
    }
}
