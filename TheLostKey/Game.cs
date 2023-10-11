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

        private void StartGame()
        {
            Clear();
            string ans; 
            WriteLine("Enter your name: ");
            ans = ReadLine();
            Clear(); 
            WriteLine($"Hello, {ans}!");
            Clear();
        }
    }
}
