using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3_Alexander_Adolfsson.Classes
{
    public class Game
        
    {
        #region startAssets       
        Player player = Player.CreatePlayerOne();  
        Rooms room1 = Rooms.CreateRoomOne();
        Rooms room2 = Rooms.CreateRoomTwo();
        Rooms room3 = Rooms.CreateRoomThree();
        Items welcomeLetter = Items.CreateWelcomeLetter();
        Items firstRoomNote = Items.CreateFirstRoomNote();
        Items firstRoomKey = Items.CreateFirstRoomKey();        
        Items firstChestKey = Items.CreateFirstChestKey();
        Items torch = Items.CreateTorch();
        Items firstBookshelfKey = Items.CreateFirstBookshelfKey();
        Items secondChestKey = Items.CreateSecondChestKey();
        Items firstLampKey = Items.CreateFirstLampkey();
        Items rock = Items.CreateRock();
        Items matchBox = Items.CreateMatchBox();
        Items secondRoomNote = Items.CreateSecondRoomNote();
        Items firstCombineNote = Items.CreateFirstCombineNote();
        Items secondCombineNote = Items.CreateSecondCombineNote();
        Items firstCombinedNote = Items.CreateFirstCombinedNote();
        Items dustyNote = Items.CreateDustyNote();
        Items oldShoe = Items.CreateOldShoe();
        Items burningTorch = Items.CreateBurningTorch();
        Furnitures firstRoomExitDoor = Furnitures.CreateFirstRoomExitDoor();
        Furnitures firstRoomChest = Furnitures.CreateFirstRoomChest();
        Furnitures secondRoomExitDoor = Furnitures.CreateSecondRoomExitDoor();
        Furnitures secondRoomBookShelf = Furnitures.CreateSecondRoomBookShelf();
        Furnitures secondRoomTable = Furnitures.CreateSecondRoomTable();
        Furnitures secondRoomLamp = Furnitures.CreateSecondRoomLamp();
        Furnitures secondRoomChest = Furnitures.CreateSecondRoomChest();
        Furnitures secondRoomDrawer = Furnitures.CreateSecondRoomDrawer();
        #endregion

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
            List<Items> allItems = Items.CreateItemsList();
            string result = allItems.Where(x => x.Name == choosenItem).Select(x => x.Information).SingleOrDefault();
            return result;
            
        }
        public string ReadFurniture(string choosenItem)
        {
            List<Furnitures> allFurnitures = Furnitures.CreateFurnnitureList();
            string result = allFurnitures.Where (x => x.Name == choosenItem).Select(x => x.Information).SingleOrDefault();
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
            room2.ItemsInRoom.Add(rock);
            room2.ItemsInRoom.Add(dustyNote);
            room2.ItemsInRoom.Add(oldShoe);
            room2.Furnitures.Add(secondRoomExitDoor);
            room2.Furnitures.Add(secondRoomBookShelf);
            room2.Furnitures.Add(secondRoomTable);
            room2.Furnitures.Add(secondRoomLamp);
            room2.Furnitures.Add(secondRoomChest);
            room2.Furnitures.Add(secondRoomDrawer);
        }
        public void ThrowItemOnGround(string itemToThrow)
        {
            List<Items> allItems = Items.CreateItemsList();
            Items result = allItems.Where(x => x.Name == itemToThrow).SingleOrDefault();
            List<Items> roomList = new List<Items>();
            if (player.Location == 1)
            {
                roomList = room1.ItemsInRoom;
            }
            else if (player.Location == 2)
            {
                roomList = room2.ItemsInRoom;
            }
            if(result != null)
            {
                player.Inventory.RemoveAll(x => x.Name == result.Name);
                roomList.Add(result);
            }
        }

        public void PickUpItemFromRoom(string itemToPickUp)
        {
            List<Items> allItems = Items.CreateItemsList();
            Items result = allItems.Where(x => x.Name == itemToPickUp).SingleOrDefault();
            List<Items> roomList = new List<Items>();
            if (player.Location == 1)
            {
                roomList = room1.ItemsInRoom;
            }
            else if (player.Location == 2)
            {
                roomList = room2.ItemsInRoom;
            }
            if (result != null)
            {
                player.Inventory.Add(result);
                roomList.RemoveAll(x => x.Name == result.Name);
            }
        }
        public string RoomInfo()
        {
            if (player.Location == 1)
                return room1.Clue;           
            else if (player.Location == 2)
                return room2.Clue;
            else if (player.Location == 3)
                return room3.Clue;
            else return null;
        }
        public string UseItem(string choosenItem)
        {
            if (player.Location == 1 || player.Location == 2 && choosenItem == burningTorch.Name)
            {              
                    return "Du ser redan allt i rummet";  
            }
            else return "Du kan inte använda det här föremålet";
        }
        public string UseItemOnFurniture(string choosenItem, string choosenFurniture)
        {
            if (choosenItem == firstRoomKey.Name && choosenFurniture == firstRoomChest.Name && firstRoomChest.IsOpen == false)
            {
                firstRoomChest.IsOpen = true;
                player.Inventory.RemoveAll(x => x.Name == firstRoomKey.Name);
                foreach (Items item in firstRoomChest.Inventory)
                {
                    room1.ItemsInRoom.Add(item);

                }
                firstRoomChest.Inventory = null;
                firstRoomChest.Information = "Lådan är öppen och du har tagit allt innehåll";

                return "Lådan är öppen!";
            }
            else if (choosenItem == firstChestKey.Name && choosenFurniture == firstRoomExitDoor.Name && firstRoomExitDoor.IsOpen == false)
            {
                player.Inventory.RemoveAll(x => x.Name == firstChestKey.Name);
                firstRoomExitDoor.IsOpen = true;
                return "Dörren är upplåst";
            }
            else if (choosenItem == firstBookshelfKey.Name && choosenFurniture == secondRoomChest.Name)
            {
                player.Inventory.RemoveAll(x => x.Name == firstBookshelfKey.Name);
                secondRoomChest.IsOpen = true;
                foreach (Items item in secondRoomChest.Inventory)
                {
                    room2.ItemsInRoom.Add(item);
                }
                secondRoomChest.Inventory = null;
                return "Nyckeln passade, bra jobbat";
            }
            else if (choosenItem == secondChestKey.Name && choosenFurniture == secondRoomDrawer.Name)
            {
                player.Inventory.RemoveAll(x => x.Name == secondChestKey.Name);
                secondRoomDrawer.IsOpen = true;
                foreach (Items item in secondRoomDrawer.Inventory)
                {
                    room2.ItemsInRoom.Add(item);
                }
                secondRoomDrawer.Inventory = null;
                return "Helt otroligt, den gick att låsa upp";
            }
            else if (choosenItem == rock.Name && choosenFurniture == secondRoomLamp.Name)
            {
                Random throwRock = new Random();
                int didItHit = throwRock.Next(0,5);
                if (didItHit == 3)
                {
                    player.Inventory.RemoveAll(x => x.Name == rock.Name);
                    foreach (Items item in secondRoomLamp.Inventory)
                    {
                        room2.ItemsInRoom.Add(item);
                    }
                    return "Du träffade lampan! Någonting ramlade ur den, vad är det?";
                }
                else
                {
                    player.Inventory.RemoveAll(x => x.Name == rock.Name);
                    room2.ItemsInRoom.Add(rock);
                    return "Du missade, försök igen";
                }
                    
            }
            else if (choosenItem == firstLampKey.Name && choosenFurniture == secondRoomExitDoor.Name)
            {
                player.Inventory.RemoveAll(x => x.Name == firstLampKey.Name);
                secondRoomExitDoor.IsOpen = true;
                return "DÖRREN ÄR UPPLÅST!";
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
                MessageBox.Show("GRATTIS DU HAR VUNNIT SPELET");
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
            if (player.Location == 1 && firstRoomExitDoor.IsOpen == true && choosenFurniture == firstRoomExitDoor.Name)
            {
                room1.ExitDoorOpen = true;
                return "Dörren är öppnad, du kan gå igenom";
            }
            else if (player.Location == 1 && firstRoomExitDoor.IsOpen == true && room1.ExitDoorOpen == true && choosenFurniture == firstRoomExitDoor.Name)
            {
                return "Den här dörren är redan öppen";
            }
            else if (player.Location == 1 && firstRoomExitDoor.IsOpen == false && choosenFurniture == firstRoomExitDoor.Name)
            {
                return "Du kan inte öppna en låst dörr";
            }
            else if (player.Location == 2 && secondRoomExitDoor.IsOpen == true && choosenFurniture == secondRoomExitDoor.Name)
            {
                room2.ExitDoorOpen = true;
                return "Dörren är öppnad! Du hör fågelkvitter";
            }
            else if (player.Location == 2 && secondRoomExitDoor.IsOpen == true && room2.ExitDoorOpen == true && choosenFurniture == secondRoomExitDoor.Name)
            {
                return "Den här dörren är redan öppen, vad väntar du på?";
            }
            else if (player.Location == 2 && secondRoomExitDoor.IsOpen == false && choosenFurniture == secondRoomExitDoor.Name)
            {
                return "Nu har du otur, du kan inte öppna en låst dörr";
            }
            else return "Du kan inte öppna den här möbeln";
        }
        public string LookThroughFurniture(string choosenFurniture)
        {if (choosenFurniture == secondRoomBookShelf.Name)
            {
                if (secondRoomBookShelf.Inventory != null)
                {


                    foreach (Items item in secondRoomBookShelf.Inventory)
                    {
                        room2.ItemsInRoom.Add(item);
                    }
                    secondRoomBookShelf.Inventory = null;
                    return "Du letar igenom bokhyllan";
                }
                else return "Du har redan letat här";
            }
            return "Du kan inte leta igenom detta";
        }
        public string CombineItems(string choosenInventoryItem, string choosenRoomItem)
        {
            List<Items> roomList = new List<Items>();
            if (player.Location == 1)
                roomList = room1.ItemsInRoom;
            else if(player.Location == 2)
                roomList = room2.ItemsInRoom;
            if(choosenInventoryItem == torch.Name && choosenRoomItem == matchBox.Name || 
                choosenInventoryItem == matchBox.Name && choosenRoomItem == torch.Name)
            {
                player.Inventory.Add(burningTorch);
                player.Inventory.RemoveAll(x => x.Name == torch.Name);
                player.Inventory.RemoveAll(x => x.Name == matchBox.Name);
                roomList.RemoveAll(x => x.Name == torch.Name);
                roomList.RemoveAll(x => x.Name == matchBox.Name);
                return "Du har tänt eld på faklan";
            }
            else if (choosenInventoryItem == firstCombineNote.Name && choosenRoomItem == secondCombineNote.Name || 
                choosenInventoryItem == secondCombineNote.Name && choosenRoomItem == firstCombineNote.Name)
            {
                player.Inventory.Add(firstCombinedNote);
                player.Inventory.RemoveAll(x => x.Name == firstCombineNote.Name);
                player.Inventory.RemoveAll(x => x.Name == secondCombineNote.Name);
                roomList.RemoveAll(x => x.Name == firstCombineNote.Name);
                roomList.RemoveAll(x => x.Name == secondCombineNote.Name);
                return "Du har lagt ihop lapparna, testa att läsa nu";
            }
            else return $"Du kan inte använda {choosenInventoryItem} på {choosenRoomItem}";
        }



    }
}
