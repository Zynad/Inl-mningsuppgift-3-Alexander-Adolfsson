using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3_Alexander_Adolfsson.Classes
{
    public class Game
        
    {
        
        Player player = Player.CreatePlayerOne();
        Items welcomeLetter = Items.CreateWelcomeLetter();
        Rooms room1 = Rooms.CreateRoomOne();
        Rooms room2 = Rooms.CreateRoomTwo();
        Items firstRoomNote = Items.CreateFirstRoomNote();
        Items firstRoomKey = Items.CreateFirstRoomKey();
        Furnitures firstRoomChest = Furnitures.CreateFirstRoomChest();
        Items firstChestKey = Items.CreateFirstChestKey();
        Items torch = Items.CreateTorch();
        Furnitures firstRoomExitDoor = Furnitures.CreateFirstRoomExitDoor();
        //int currentRoom = 0;

        public int CurrentRoom()
        {            
            return player.Location;
        }
        public string CurrentPlayer()
        {
            return player.Name;           
        }
        public string ReadItem(string choosenItem)
        {
            string result = "";
            if (choosenItem == "Välkomstbrev")
            {
                result = welcomeLetter.Information;
            }
            else if(choosenItem == "Rosa lapp")
            {
                result = firstRoomNote.Information;
            }
            else if (choosenItem == "Silvrig nyckel")
            {
                result = firstRoomKey.Information;
            }
            else if(choosenItem == "Rosa nyckel")
            {             
                result = firstChestKey.Information;
            }
            else if (choosenItem == "Fakla")
            {               
                result = torch.Information;
            }
            else if (choosenItem == "Låda av trä")
            {
                result = firstRoomChest.Information;
            }
            else if (choosenItem == "Dörr av trä")
            {
                result = firstRoomExitDoor.Information;
            }
            return result;
        }
        public List<Items> PlayerInventory() { return player.Inventory; }
        public List<Items> ItemsInRoom()
        {
            List<Items> emptyList = new List<Items>();
            if (player.Location == 1 && room1.LookedAround == true)
            {             
                return room1.ItemsInRoom;              
            }
            else if (player.Location == 2 && room2.LookedAround == true)
            {
                return room2.ItemsInRoom;
            }
            else
                return emptyList;
        }
        public List<Furnitures> FurnituresInRoom()
        {
            List<Furnitures> emptyList = new List<Furnitures>();
            if (player.Location == 1 && room1.LookedAround == true)
            {
                return room1.Furnitures;
            }
            else if (player.Location == 2 && room2.LookedAround == true)
            {
                return room2.Furnitures;
            }
            else
                return emptyList;
        }
        public bool LookAroundInRoom()
        {
            if (player.Location == 1)
            {
                room1.LookedAround = true;
                return true;
            }
            else if (player.Location == 2)
            {
                room2.LookedAround = true;
                return true;
            }
            else return false;
        }
        
        public void StartGame(string nameOfCharacter)
        {
            player.Name = nameOfCharacter;
            player.Inventory.Add(welcomeLetter);
            room1.ItemsInRoom.Add(firstRoomKey);
            room1.ItemsInRoom.Add(firstRoomNote);
            room1.Furnitures.Add(firstRoomChest);
            room1.Furnitures.Add(firstRoomExitDoor);
            




        }
        public void ThrowItemOnGround(string itemToThrow)
        {
            List<Items> roomList = new List<Items>();
            if(player.Location == 1)
            {
                roomList = room1.ItemsInRoom;
            }
            else if (player.Location == 2)
            {
                roomList = room2.ItemsInRoom;
            }
            if (itemToThrow == "Välkomstbrev")
            {
                player.Inventory.Remove(welcomeLetter);                
                roomList.Add(welcomeLetter);
                
            }
            else if (itemToThrow == "Rosa lapp")
            {
                player.Inventory.Remove(firstRoomNote);                
                roomList.Add(firstRoomNote);
                
            }
            else if (itemToThrow == "Silvrig nyckel")
            {
                player.Inventory.Remove(firstRoomKey);                
                roomList.Add(firstRoomKey);
               
            }
            else if (itemToThrow == "Rosa nyckel")
            {
                player.Inventory.RemoveAll(x => x.Name == firstChestKey.Name);                                
                roomList.Add(firstChestKey);
                
            }
            else if (itemToThrow == "Fakla")
            {
                player.Inventory.RemoveAll(x => x.Name == torch.Name);                
                roomList.Add(torch);
                
            }
        }
        public void PickUpItemFromRoom(string itemToPickUp)
        {
            List<Items> roomList = new List<Items>();
            if (player.Location == 1)
            {
                roomList = room1.ItemsInRoom;
            }
            else if (player.Location == 2)
            {
                roomList = room2.ItemsInRoom;
            }
            if (itemToPickUp == "Välkomstbrev")
            {
                player.Inventory.Add(welcomeLetter);                               
                roomList.Remove(welcomeLetter);
                
            }
            else if (itemToPickUp == "Rosa lapp")
            {
                player.Inventory.Add(firstRoomNote);                
                roomList.Remove(firstRoomNote);
                
            }
            else if (itemToPickUp == "Silvrig nyckel")
            {
                player.Inventory.Add(firstRoomKey);
                roomList.Remove(firstRoomKey);
                
            }
            else if (itemToPickUp == "Rosa nyckel")
            {
                player.Inventory.Add(firstChestKey);
                roomList.RemoveAll(x => x.Name == firstChestKey.Name);

            }
            else if (itemToPickUp == "Fakla")
            {
                player.Inventory.Add(torch);
                roomList.RemoveAll(x => x.Name == torch.Name);

            }
        }
        public string RoomInfo()
        {
            if (player.Location == 1)
            {
                return room1.Clue;
            }
            else return null;
        }
        public string UseItem(string choosenItem)
        {
            if (player.Location == 1 || player.Location == 2 && choosenItem == "Fakla")
            {              
                    return "Du ser redan allt i rummet";  
            }
            else return "Du kan inte använda det här föremålet";
        }
        public string UseItemOnFurniture(string choosenItem, string choosenFurniture)
        {
            if (choosenItem == "Silvrig nyckel" && choosenFurniture == "Låda av trä" && firstRoomChest.IsOpen == false)
            {
                firstRoomChest.IsOpen = true;
                player.Inventory.Remove(firstRoomKey);
                foreach (Items item in firstRoomChest.Inventory)
                {
                    room1.ItemsInRoom.Add(item);

                }
                firstRoomChest.Information = "Lådan är öppen och du har tagit allt innehåll";

                return "Lådan är öppen!";
            }
            else if (choosenItem == "Rosa nyckel" && choosenFurniture == "Dörr av trä" && firstRoomExitDoor.IsOpen == false)
            {
                player.Inventory.RemoveAll(x => x.Name == firstChestKey.Name);
                firstRoomExitDoor.IsOpen = true;
                return "Dörren är upplåst";
            }
            else return "Det gick inte att använda det här föremålet på den här möbeln";

        }
        public void GoToNextRoom()
        {
            if (player.Location == 1 && room1.ExitDoorOpen == true)
            {                
                player.Location++;
            }
            else if (player.Location == 2 && room2.ExitDoorOpen == true)
            {

                player.Location++;
            }
        }
        public void GoToPreviousRoom()
        {
            if (player.Location == 2)
            {
                player.Location--;
            }
            else if (player.Location == 3)
            {
                player.Location--;
            }
        }
        public string OpenFurniture(string choosenFurniture)
        {
            if (player.Location == 1 && firstRoomExitDoor.IsOpen == true && choosenFurniture == "Dörr av trä")
            {
                room1.ExitDoorOpen = true;
                return "Dörren är öppnad, du kan gå igenom";
            }
            else if (player.Location == 1 && firstRoomExitDoor.IsOpen == true && room1.ExitDoorOpen == true && choosenFurniture == "Dörr av trä")
            {
                return "Den här dörren är redan öppen";
            }
            else if (player.Location == 1 && firstRoomExitDoor.IsOpen == false && choosenFurniture == "Dörr av trä")
            {
                return "Du kan inte öppna en låst dörr";
            }
            else return "Du kan inte öppna den här möbeln";
        }



    }
}
