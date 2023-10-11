using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TheLostKey
{
    public class PlayerController
    {
        Player player = new Player();
        public void Collect(Item item)
        {
            player.Inventory.Add(item);
        }

        public int Use(Item item) 
        {
            int use = 1;
            if (item.Usability > 0)
            {
                return item.Usability -= use;
            }
            else
            {
                WriteLine("The item is not usable!");
                return 0; 
            }
         
        }
    }
}
