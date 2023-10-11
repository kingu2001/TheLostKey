namespace TheLostKey
{
    internal class Program
    {
        public static bool isSelected = false; // Hvis isSelected er false så vil programmet blive ved med at køre menu'en
        public static bool isFocused = true; // Dette styrer hele menuen, altså når man trykker enter kommer man i næste menu

        static void Main(string[] args)
        {
           
            int option = 0; // Dette initialisere hvilket punkt vi er på i programmet, altså man stater på mulighed 0
            string decorator = "➡️ \u001b[32m"; // Sætter emoji ved siden af det sted man er i programmet, og farver det grønt
            ConsoleKeyInfo key; // Tager informationer af den tastatur key vi trykker på

            while (isFocused) // Herunder laves en whileloop der tillader at menuen bare bliver ved foreveigt indtil man trykker på noget
            {
                while (!isSelected) // Herunder laver man et while-loop under det første loop.
                {
                    Console.Clear();

                    Console.WriteLine("\n __          __  _                            _______      _______ _          _               _   _  __          \n \\ \\        / / | |                          |__   __|    |__   __| |        | |             | | | |/ /          \n  \\ \\  /\\  / /__| | ___ ___  _ __ ___   ___     | | ___      | |  | |__   ___| |     ___  ___| |_| ' / ___ _   _ \n   \\ \\/  \\/ / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\    | |/ _ \\     | |  | '_ \\ / _ \\ |    / _ \\/ __| __|  < / _ \\ | | |\n    \\  /\\  /  __/ | (_| (_) | | | | | |  __/    | | (_) |    | |  | | | |  __/ |___| (_) \\__ \\ |_| . \\  __/ |_| |\n     \\/  \\/ \\___|_|\\___\\___/|_| |_| |_|\\___|    |_|\\___/     |_|  |_| |_|\\___|______\\___/|___/\\__|_|\\_\\___|\\__, |\n                                                                                                            __/ |\n                                                                                                           |___/ \n \n __________________________________________________________________________________________________________________\n ");
                    Console.WriteLine("A basic text adventure game where the player makes choices by typing in text commands.\nThe goal is to find a lost key hidden within a small maze-like environment. \n");
                    Console.WriteLine(" You can use ⬆️ & ⬇️, to move and use ENTER to select an Option");
                    Console.WriteLine($"{(option == 0 ? decorator : "  ")}Start \u001b[0m");
                    Console.WriteLine($"{(option == 1 ? decorator : "  ")}Controls \u001b[0m");
                    Console.WriteLine($"{(option == 2 ? decorator : "  ")}Exit \u001b[0m");

                    key = Console.ReadKey(); // Her der tager programmet og kigger på hvad man trykker på og læser det

                    switch (key.Key) // I dette switch punkt der giver man mulighed for at trykke på pil-op, pil-ned og enter på tastaturet for at lave en vis handling.
                    {
                        case ConsoleKey.UpArrow:
                            option = option == 0 ? 2 : option - 1;
                            break;
                        case ConsoleKey.DownArrow:
                            option = option == 2 ? 0 : option + 1;
                            break;
                        case ConsoleKey.Enter:
                            isSelected = true;
                            break; // Hvis man trykker enter på tastaturet så bliver "isSelected" sat til true og menuen ændre sig til det man vil ind i.
                    }
                }
            }
        }
    }
}