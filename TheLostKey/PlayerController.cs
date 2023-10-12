using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostKey
{
    public class PlayerController
    {
        Player player = new Player(); 
        public void Collect(Item item)
        {
            player.Inventory.Add(item);
        }

        public void Use(Item item )
        {
            item.Usability = 5; 
            int use = 1;
            item.Usability -= use;
        }
    }
}
