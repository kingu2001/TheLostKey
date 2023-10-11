using System;
namespace TheLostKey
{
    public class Menu
    {
        //Fields
        public string Title;
        private MenuItem[] menuItems = new MenuItem[10];
        private int itemCount = 0;


        public Menu(string menuTitle)
        {
            this.Title = menuTitle;
        }

        public void Show() //method
        {
            Console.Clear();
            Console.WriteLine(Title);

            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(menuItems[i].Title);
            }
        }
        public void AddMenuItem(string menuTitle)
        {
            MenuItem mi = new MenuItem(menuTitle);
            //mi.Title = menuTitle;
            menuItems[itemCount] = mi;
            itemCount++;
        }
        public int SelectMenuItem()
        {
            string menuSelect = Console.ReadLine();
            bool isInt = int.TryParse(menuSelect, out int i);

            if (isInt)
            {
                if (i <= itemCount)
                {
                    return i;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }

        }
    }
}

