using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3_Alexander_Adolfsson.Classes
{
    public class Player
    {
        public string Name { get; set; }
        public List<Items> Inventory { get; set; }
        public int Location { get; set; }

        public static Player CreatePlayerOne()
        {
            Player player = new Player();            
            player.Location = 1;
            player.Inventory = new List<Items>();
            return player;
        }

        

    }
}
