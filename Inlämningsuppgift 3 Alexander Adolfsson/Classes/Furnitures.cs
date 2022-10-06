using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3_Alexander_Adolfsson.Classes
{
    public class Furnitures:Items 
    {
        public Furnitures()
        {
        }

        public int Location { get; set; }
        public bool IsOpen { get; set; }
        public List<Items> Inventory { get; set; }

        public static Furnitures CreateFirstRoomChest()
        {
            Furnitures firstRoomChest = new Furnitures();
            firstRoomChest.Name = "Låda av trä";
            firstRoomChest.IsOpen = false;
            firstRoomChest.Type = "Chest";
            firstRoomChest.Information = "Den är låst, försök hitta en nyckel som passar";
            firstRoomChest.Inventory = new List<Items>();
            Items firstChestKey = Items.CreateFirstChestKey();
            Items torch = Items.CreateTorch();
            firstRoomChest.Inventory.Add(firstChestKey);
            firstRoomChest.Inventory.Add(torch);
            return firstRoomChest;
        }
        public static Furnitures CreateFirstRoomExitDoor()
        {
            Furnitures firstRoomExitDoor = new Furnitures();
            firstRoomExitDoor.Name = "Dörr av trä";
            firstRoomExitDoor.Type = "Door";
            firstRoomExitDoor.Information = "Dörren är låst, hur kan man låsa upp den?";
            return firstRoomExitDoor;
        }
    }
}
