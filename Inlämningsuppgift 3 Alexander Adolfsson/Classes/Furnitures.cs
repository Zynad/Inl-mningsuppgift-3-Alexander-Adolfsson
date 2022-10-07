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

        public static List<Furnitures> CreateFurnnitureList()
        {
            List<Furnitures> furnituresList = new List<Furnitures>();
            furnituresList.Add(CreateFirstRoomChest());
            furnituresList.Add(CreateFirstRoomExitDoor());
            furnituresList.Add(CreateSecondRoomExitDoor());
            furnituresList.Add(CreateSecondRoomBookShelf());
            furnituresList.Add(CreateSecondRoomTable());
            furnituresList.Add(CreateSecondRoomLamp());
            furnituresList.Add(CreateSecondRoomChest());
            furnituresList.Add(CreateSecondRoomDrawer());

            return furnituresList;
        }
        public static Furnitures CreateFirstRoomChest()
        {
            Furnitures firstRoomChest = new Furnitures();
            firstRoomChest.Name = "Låda av trä";
            firstRoomChest.IsOpen = false;
            firstRoomChest.Type = "Chest";
            firstRoomChest.Information = "Den är låst, försök hitta en nyckel som passar";
            firstRoomChest.Inventory = new List<Items>();
            Items firstChestKey = CreateFirstChestKey();
            Items torch = CreateTorch();
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
            secondRoomExitDoor.Name = "Dörr av sten";
            secondRoomExitDoor.Type = "Door";
            secondRoomExitDoor.Information = "Dörren ser stor och tung upp, den är låst. Finns ett litet nyckelhål, vad för nyckel kan passa här?";
            secondRoomExitDoor.IsOpen = false;
            return secondRoomExitDoor;
        }
        public static Furnitures CreateSecondRoomBookShelf()
        {
            Furnitures secondRoomBookShelf = new Furnitures();
            secondRoomBookShelf.Name = "Bokhylla av marmor";
            secondRoomBookShelf.Type = "Bookshelf";
            secondRoomBookShelf.Information = "En stor bokhylla, den ser ut att vara tom. Eller?";
            secondRoomBookShelf.Inventory = new List<Items>();
            Items firstBookshelfKey = CreateFirstBookshelfKey();
            Items firstCombineNote = CreateFirstCombineNote();
            secondRoomBookShelf.Inventory.Add(firstBookshelfKey);
            secondRoomBookShelf.Inventory.Add(firstCombineNote);
            return secondRoomBookShelf;
        }
        public static Furnitures CreateSecondRoomTable()
        {
            Furnitures secondRoomTable = new Furnitures();
            secondRoomTable.Name = "Litet bord";
            secondRoomTable.Type = "Table";
            secondRoomTable.Information = "Ett litet träbord i mitten utav rummet";
            return secondRoomTable;
        }
        public static Furnitures CreateSecondRoomLamp()
        {
            Furnitures secondRoomLamp = new Furnitures();
            secondRoomLamp.Name = "Lampa av glas";
            secondRoomLamp.Type = "Lamp";
            secondRoomLamp.Information = "En taklampa utav glas, det brinner ett stearinljus där inne. Skymtar man en skygga?";
            secondRoomLamp.Inventory = new List<Items>();
            Items firstLampKey = CreateFirstLampkey();
            secondRoomLamp.Inventory.Add(firstLampKey);
            return secondRoomLamp;
        }
        public static Furnitures CreateSecondRoomChest()
        {
            Furnitures secondRoomChest = new Furnitures();
            secondRoomChest.Name = "Stenlåda";
            secondRoomChest.IsOpen = false;
            secondRoomChest.Type = "Chest";
            secondRoomChest.Information = "En dammig stenlåda, den ser aldrig ut att ha öppnats. Men någon ska ju vara den första.";
            secondRoomChest.Inventory = new List<Items>();
            Items secondChestKey = CreateSecondChestKey();
            Items secondRoomNote = CreateSecondRoomNote();
            secondRoomChest.Inventory.Add(secondRoomNote);
            secondRoomChest.Inventory.Add(secondChestKey);
            return secondRoomChest;
        }
        public static Furnitures CreateSecondRoomDrawer()
        {
            Furnitures secondRoomDrawer = new Furnitures();
            secondRoomDrawer.Name = "Skrivbord";
            secondRoomDrawer.Type = "Drawer";
            secondRoomDrawer.IsOpen = false;
            secondRoomDrawer.Information = "Ett skrivbord i hörnet, vem har suttit här? Är något kvar i det?";
            secondRoomDrawer.Inventory = new List<Items>();
            Items secondCombineNote = CreateSecondCombineNote();
            Items matchBox = CreateMatchBox();
            secondRoomDrawer.Inventory.Add(secondCombineNote);
            secondRoomDrawer.Inventory.Add(matchBox);
            return secondRoomDrawer;
        }
    }
}
