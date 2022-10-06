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
        Items firstRoomNote = Items.CreateFirstRoomNote();
        Items firstRoomKey = Items.CreateFirstRoomKey();
        Furnitures firstRoomChest = Furnitures.CreateFirstRoomChest();
        Items firstChestKey = Items.CreateFirstChestKey();
        Items torch = Items.CreateTorch();
        Furnitures firstRoomExitDoor = Furnitures.CreateFirstRoomExitDoor();
        int currentRoom = 0;

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
            return result;
        }
        public List<Items> PlayerInventory() { return player.Inventory; }
        public List<Items> ItemsInRoom()
        {
            List<Items> emptyList = new List<Items>();
            if (currentRoom == 1 && room1.LookedAround == true)
            {             
                return room1.ItemsInRoom;              
            }
            else if (currentRoom == 2)
            {
                return emptyList;
            }
            else
                return emptyList;
        }
        public List<Furnitures> FurnituresInRoom()
        {
            List<Furnitures> emptyList = new List<Furnitures>();
            if (currentRoom == 1 && room1.LookedAround == true)
            {
                return room1.Furnitures;
            }
            else if (currentRoom == 2)
            {
                return emptyList;
            }
            else
                return emptyList;
        }
        public bool LookAroundInRoom()
        {
            if (currentRoom == 1)
            {
                room1.LookedAround = true;
                return true;
            }
            else return false;
        }
        
        public void StartGame(string nameOfCharacter)
        {
            player.Name = nameOfCharacter;
            player.Inventory.Add(welcomeLetter);
            currentRoom = room1.RoomNo;
            room1.ItemsInRoom.Add(firstRoomKey);
            room1.ItemsInRoom.Add(firstRoomNote);
            room1.Furnitures.Add(firstRoomChest);
            room1.Furnitures.Add(firstRoomExitDoor);
            




        }
        public void ThrowItemOnGround(string itemToThrow)
        {
            if (itemToThrow == "Välkomstbrev")
            {
                player.Inventory.Remove(welcomeLetter);
                if (currentRoom == 1)
                {
                    room1.ItemsInRoom.Add(welcomeLetter);
                }
            }
            else if (itemToThrow == "Rosa lapp")
            {
                player.Inventory.Remove(firstRoomNote);
                if (currentRoom == 1)
                {
                    room1.ItemsInRoom.Add(firstRoomNote);
                }
            }
            else if (itemToThrow == "Silvrig nyckel")
            {
                player.Inventory.Remove(firstRoomKey);
                if (currentRoom == 1)
                {
                    room1.ItemsInRoom.Add(firstRoomKey);
                }
            }
            else if (itemToThrow == "Rosa nyckel")
            {
                player.Inventory.RemoveAll(x => x.Name == firstChestKey.Name);
                //player.Inventory.Remove(firstChestKey);
                if (currentRoom == 1)
                {
                    room1.ItemsInRoom.Add(firstChestKey);
                }
            }
            else if (itemToThrow == "Fakla")
            {
                player.Inventory.RemoveAll(x => x.Name == torch.Name);
                if (currentRoom == 1)
                {
                    room1.ItemsInRoom.Add(torch);
                }
            }
        }
        public void PickUpItemFromRoom(string itemToPickUp)
        {
            if (itemToPickUp == "Välkomstbrev")
            {
                player.Inventory.Add(welcomeLetter);
                if(currentRoom == 1)
                {
                    room1.ItemsInRoom.Remove(welcomeLetter);
                }
            }
            else if (itemToPickUp == "Rosa lapp")
            {
                player.Inventory.Add(firstRoomNote);
                if (currentRoom == 1)
                {
                    room1.ItemsInRoom.Remove(firstRoomNote);
                }
            }
            else if (itemToPickUp == "Silvrig nyckel")
            {
                player.Inventory.Add(firstRoomKey);
                if (currentRoom == 1)
                {
                    room1.ItemsInRoom.Remove(firstRoomKey);
                }
            }
            else if (itemToPickUp == "Rosa nyckel")
            {
                player.Inventory.Add(firstChestKey);
                if (currentRoom == 1)
                {
                    room1.ItemsInRoom.Remove(firstChestKey);
                }
            }
            else if (itemToPickUp == "Fakla")
            {
                player.Inventory.Add(torch);
                if (currentRoom == 1)
                {
                    room1.ItemsInRoom.Remove(torch);
                }
            }
        }
        public string RoomInfo()
        {
            if (currentRoom == 1)
            {
                return room1.Clue;
            }
            else return null;
        }
        public string UseItem(string choosenItem)
        {
            if (currentRoom == 1 && choosenItem == "Fakla")
            {
                if (room1.IsRoomDark == false)
                {
                    return "Du ser redan allt i rummet";
                }
                else if (room1.IsRoomDark == true)
                {
                    return "Nu kan du se allt i rummet";
                }
                return null;
            }
            else return "Du kan inte använda det här föremålet";
        }
        public string UseItemOnFurniture(string choosenItem, string choosenFurniture)
        {
            if (choosenItem == "Silvrig nyckel" && choosenFurniture == "Låda av trä" && firstRoomChest.IsOpen == false)
            {
                firstRoomChest.IsOpen = true;
                player.Inventory.Remove(firstRoomKey);  
                //List<Items> firstChestItems = firstRoomChest.Inventory;
                foreach (Items item in firstRoomChest.Inventory)
                {
                    player.Inventory.Add(item);
                    
                }
                firstRoomChest.Information = "Lådan är öppen och du har tagit allt innehåll";
                
                return "Lådan är öppen!";
            }
            else return "Det gick inte att använda det här föremålet på den här möbeln";

        }
        public void GoToNextRoom()
        {
            if (currentRoom == 1)
            {
                currentRoom++;
                player.Location++;
            }
        }
        public void GoToPreviousRoom()
        {
            if (currentRoom == 2)
            {
                currentRoom--;
                player.Location--;
            }
        }



    }
}
