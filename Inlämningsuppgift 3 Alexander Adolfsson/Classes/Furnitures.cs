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
            firstRoomExitDoor.IsOpen = false;
            return firstRoomExitDoor;
        }
        public static Furnitures CreateSecondRoomExitDoor()
        {
            Furnitures secondRoomExitDoor = new Furnitures();
            return secondRoomExitDoor;
        }
        public static Furnitures CreateSecondRoomBookShelf()
        {
            Furnitures secondRoomBookShelf = new Furnitures();
            return secondRoomBookShelf;
        }
        public static Furnitures CreateSecondRoomTable()
        {
            Furnitures secondRoomTable = new Furnitures();
            return secondRoomTable;
        }
        public static Furnitures CreateSecondRoomLamp()
        {
            Furnitures secondRoomLamp = new Furnitures();
            return secondRoomLamp;
        }
        public static Furnitures CreateSecondRoomChest()
        {
            Furnitures secondRoomChest = new Furnitures();
            return secondRoomChest;
        }
        public static Furnitures CreateSecondRoomDrawer()
        {
            Furnitures secondRoomDrawer = new Furnitures();
            return secondRoomDrawer;
        }
    }
}
