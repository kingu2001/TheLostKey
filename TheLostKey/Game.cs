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
        Player player = new Player();
        List<Player> players = new List<Player>();
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

        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("This game demo was created by Group 10");
            WriteLine("This is just a demo...");
            WriteLine("Press any key to return to the menu");
            ReadKey(true);
            RunMainMenu();
        }

        private void StartGame()
        {
            string ans;
            Clear();
            WriteLine("Enter your name: ");
            ans = ReadLine();
            Clear();
            string chapter1 = "The Beginning of the end\n\n";
            string text = $"{ans}, you find yourself in a dimly lit room, your vision hazy and senses clouded.\nYou try to move, but your body feels heavy and unresponsive.\nPanic starts to creep in as you realize you're experiencing sleep paralysis — a terrifying and disorienting condition.\n\nYour heart races, and you struggle to regain control of your body.\nYou attempt to speak, to scream, but only a faint whisper escapes your lips.\nThe room, although vaguely familiar, seems distorted in the eerie stillness of your frozen state.\n\nAs you fight to break free from the paralysis, your surroundings slowly come into focus.\nYou remember that you're in an old, mysterious mansion.\nDusty furniture and cobwebs surround you, and a single door stands before you, shrouded in shadow.\n\nDespite the dread that's taken hold, you manage to calm your racing thoughts.\nFor some reason you recall an objective to find a Lost key to escape, the sleep paralysis and this eerie place.\nYou hear quiet whispers in your head of a key Lost somewhere.\nYou ponder about the location of the Lost key.\nYou head outside.";
            WriteText(chapter1);
            WriteText(text);
            ReadKey();
            Clear();
            string prompt = "Where do you want to go?";
            string[] options = {"Go to the castle", "Go to the woods"};
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run(); 
            switch (selectedIndex) 
            {
                case 0:
                    EnterCastle();
                    break;
                case 1:
                    EnterForest();
                    break; 

            }
            //string prompt = "What color paint would you like to try?";
            //string[] options = { "Red", "Green", "Blue", "Yellow" };
            //Menu colorMenu = new Menu(prompt, options);
            //int selectedIndex = colorMenu.Run();
            //BackgroundColor = ConsoleColor.White;

            //switch (selectedIndex)
            //{
            //    case 0:
            //        ForegroundColor = ConsoleColor.Red;
            //        WriteLine("\nHere is red!");
            //        break;
            //    case 1:
            //        ForegroundColor = ConsoleColor.Green;
            //        WriteLine("\n Here is green!");
            //        break;
            //    case 2:
            //        ForegroundColor = ConsoleColor.Blue;
            //        WriteLine("\n Here is blue");
            //        break;
            //    case 3:
            //        ForegroundColor = ConsoleColor.Yellow;
            //        WriteLine("\n Here is yellow");
            //        break;

        }

        public void WriteText(string text, int speed = 2)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
        }

        private void EnterCastle()
        {
            string text = $"Upon seeing the scary castle you decide to enter…\nUpon entering the scary castle you find yourself standing in an empty hall with three doors…\n";
            string dinnerRoom = $"You find yourself in a dinner room with a table that seems to go on forever. (Maybe my mind is playing a trick on me?)\r\n";
            WriteText(text);
            string[] options1 = { "Go north", "Go east", "Go west"};
            Menu castleMenu = new Menu(text, options1);
            int selectedIndex = castleMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    ALibrary(); 
                    break;
                case 1:
                    ArtRoom();
                    break; 
                case 2:
                    DinnerRoom();
                    break; 
            }
        }

        public void ArtRoom()
        {
            string text = $"You enter a room with various animal heads and old paintings \nhanging on the wall, also stuffed animals on the floor… \nSuddenly you hear strange noises coming from another room, somewhere in the castle…\n";
            string goNorth = $"You enter an empty room with no doors\n\n You see nothing in the room except a lighter hanging from the ceiling with a rope around it.\n";
            string GB = $"You go back and find yourself standing in an empty hall with three doors…";
            WriteText(text);
            string[] options2 = { "Go north", "Go back" };
            Menu artroomMenu = new Menu(text, options2);
            int selectedIndex = artroomMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    WriteText(goNorth);
                    EmptyRoom();
                    break;
                case 1:
                    WriteText(GB);
                    EnterCastle();
                    break;
            }
            
        }
        public void EmptyRoom()
        {
            string text = $"You see nothing in the room except a lighter hanging from the ceiling with a rope around it.\n";
            string Investigate = $"Take the ligher and risk the consequences!";
            string GoB = $"You ignore the lighter and go back";
            WriteText(text);
            string[] options3 = { "Investigate", "Go back to art room" };
            Menu emptyroomMenu = new Menu(text, options3);
            int selectedIndex = emptyroomMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    WriteText(Investigate);
                    ReadKey();
                    ArtRoom();
                    break;
                case 1:
                    WriteText(GoB);
                    ArtRoom();
                    break;
            }

        }

        public void ALibrary()
        {
            string text = $"Upon entering the abandoned library you discover that it has been ravaged and everything is a mess. \nBooks all over the floor, infinitely  tall bookshelves fallen over, blood on walls and floor.\n You wonder what happened in the library.\n";
            string Invest = $"You investigate the library and find nothing.";
            string GoA = $"You ignore the mess and return to the empty hall";
            WriteText(text);
            string[] options4 = { "Investigate", "Go back to empty hall" };
            Menu alibraryMenu = new Menu(text, options4);
            int selectedIndex = alibraryMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    WriteText(Invest);
                    ReadKey();
                    EnterCastle();
                    break;
                case 1:
                    WriteText(GoA);
                    EnterCastle();
                    break;

                   
            }
        }

        public void DinnerRoom()
        {
            string text = $"You find yourself in a dinner room with a table that seems to go on forever.\n(MC dialog: Maybe my mind is playing a trick on me?)\n";
            string gN = $"You go north and enter the Kitchen.";
            string gb = "You decide to go back to the empty hall.";
            WriteText(text);
            string[] options5 = { "Go north", "Go back to empty hall" };
            Menu dMenu = new Menu(text, options5);
            int selectedIndex = dMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    WriteText(gN);
                    Kitchen();
                    break;
                case 1:
                    WriteText(gb);
                    ReadKey();
                    EnterCastle();
                    break;
            }
        }

        public void Kitchen()
        {
            string text = $"After entering what seems like a normal kitchen, you then recognize that there are various different meat hooks hanging from the ceiling.\n";
            string gbDR = $"You decide go back to dinnerroom";
            string gtsr = $"You go north and enter Storage Room";
            WriteText(text);
            string[] options6 = { "Go north", "Go back to dinnerroom" };
            Menu kmenu = new Menu(text, options6);
            int selectedIndex = kmenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    WriteText(gtsr);
                    ArtRoom();
                    break;
                case 1:
                    WriteText(gbDR);
                    DinnerRoom();
                    break;

            }
        }
        
        private void EnterForest()
        {

        }
    }
   
}

