using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3_Alexander_Adolfsson.Classes
{
    public class Rooms
    {
        public bool PlayerIsHere { get; set; }

        public List<Furnitures> Furnitures { get; set; }
        public bool ExitDoorOpen { get; set; }
        public List<Items> ItemsInRoom { get; set; }
        public int RoomNo { get; set; }
        public string Clue { get; set; }
        public bool LookedAround { get; set; }
        public bool IsRoomDark { get; set; }
        public Furnitures ExitDoor { get; set; }

        public static Rooms CreateRoomOne()
        {
            Rooms room1 = new Rooms();
            room1.RoomNo = 1;
            room1.LookedAround = false;
            room1.IsRoomDark = false;
            room1.Clue = "Du befinner dig i ett ganska simpelt rum, väggarna är gjorda utav trä och taket likaså." +
                "Dörren bakom dig har magiskt försvunnit och enda vägen ut verkar vara frammåt. Dörren är låst, hur ska du lösa det här?";
            room1.Furnitures = new List<Furnitures>();
            room1.ItemsInRoom = new List<Items>();

            return room1;
        }
        public static Rooms CreateRoomTwo()
        {
            Rooms room2 = new Rooms();
            room2.RoomNo = 2;
            return room2;
        }
        public static Rooms CreateRoomThree()
        {
            Rooms room3 = new Rooms();
            room3.RoomNo = 1;
            return room3;
        }
        public static Rooms CreateRoomFour()
        {
            Rooms room4 = new Rooms();
            room4.RoomNo = 1;
            return room4;
        }


    }

    
}
