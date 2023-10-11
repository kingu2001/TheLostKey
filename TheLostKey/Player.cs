using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostKey
{
    public class Player
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public List<Item> Inventory { get; set; }
        public int xPosition { get; set; }
        public int yPosition { get; set; }

      
    }
}
