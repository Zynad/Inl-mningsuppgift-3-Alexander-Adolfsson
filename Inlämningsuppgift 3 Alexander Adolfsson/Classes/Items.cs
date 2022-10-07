using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3_Alexander_Adolfsson.Classes
{
    public class Items
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Information { get; set; }

        public Items(string name, string type, string information)
        {
            Name = name;
            Type = type;
            Information = information;
        }
        public Items()
        {

        }
        public static List<Items> CreateItemsList()
        {
            List<Items> itemsList = new List<Items>();
            itemsList.Add(CreateWelcomeLetter());
            itemsList.Add(CreateFirstRoomNote());
            itemsList.Add(CreateFirstRoomKey());
            itemsList.Add(CreateFirstChestKey());
            itemsList.Add(CreateTorch());
            itemsList.Add(CreateFirstBookshelfKey());
            itemsList.Add(CreateSecondChestKey());
            itemsList.Add(CreateFirstLampkey());
            itemsList.Add(CreateRock());
            itemsList.Add(CreateMatchBox());
            itemsList.Add(CreateSecondRoomNote());
            itemsList.Add(CreateFirstCombineNote());
            itemsList.Add(CreateSecondCombineNote());
            itemsList.Add(CreateFirstCombinedNote());
            itemsList.Add(CreateDustyNote());
            itemsList.Add(CreateOldShoe());
            return itemsList;
        }
        public static Items CreateWelcomeLetter()
        {
            Items welcomeLetter = new Items();
            welcomeLetter.Name = "Välkomstbrev";
            welcomeLetter.Type = "Note";
            welcomeLetter.Information = "Välkommen till Zynads Adventure, börja med att kolla runt i rummet";
            return welcomeLetter;
        }
        public static Items CreateFirstRoomNote()
        {
            Items firstRoomNote = new Items();
            firstRoomNote.Name = "Rosa lapp";
            firstRoomNote.Type = "Note";
            firstRoomNote.Information = "Har du testat att använda nyckeln på kistan?";
            return firstRoomNote;
        }
        public static Items CreateFirstRoomKey()
        {
            Items FirstRoomKey = new Items();
            FirstRoomKey.Name = "Silvrig nyckel";
            FirstRoomKey.Type = "Key";
            FirstRoomKey.Information = "Den ser ut att öppna någonting gjort utav trä";
            return FirstRoomKey;
        }

        public static Items CreateFirstChestKey()
        {
            Items firstChestKey = new Items();
            firstChestKey.Name = "Rosa nyckel";
            firstChestKey.Type = "Key";
            firstChestKey.Information = "Den ser ut att öppna en trädörr";
            return firstChestKey;
        }

        public static Items CreateTorch()
        {
            Items torch = new Items();
            torch.Name = "Fakla";
            torch.Type = "Useable";
            torch.Information = "Använd denna om det är för mörkt för att se";
            return torch;
        }
        public static Items CreateFirstBookshelfKey()
        {
            Items firstBookshelfKey = new Items();
            firstBookshelfKey.Name = "Gul nyckel";
            firstBookshelfKey.Type = "Key";
            firstBookshelfKey.Information = "Varför är den här nyckeln gul? Mycket konstig färg på en nyckel";
            return firstBookshelfKey;
        }
        public static Items CreateSecondChestKey()
        {
            Items secondChestKey = new Items();
            secondChestKey.Name = "Röd nyckel";
            secondChestKey.Type = "Key";
            secondChestKey.Information = "Röd nyckel... kan det vara färgat utav blod?";
            return secondChestKey;
        }
        public static Items CreateFirstLampkey()
        {
            Items firstLampKey = new Items();
            firstLampKey.Name = "Blå nyckel";
            firstLampKey.Type = "Key";
            firstLampKey.Information = "Den här var gömd i en lampa, varför i hela friden var den det?";
            return firstLampKey;
        }
        public static Items CreateRock()
        {
            Items rock = new Items();
            rock.Name = "Liten sten";
            rock.Type = "Throwable";
            rock.Information = "Är det något speciellt med den här eller har den bara ramlat ifrån väggen?";
            return rock;
        }
        public static Items CreateMatchBox()
        {
            Items matchBox = new Items();
            matchBox.Name = "Tändsticksask";
            matchBox.Type = "Useable";
            matchBox.Information = "Perfekt om jag vill tända eld på något";
            return matchBox;
        }
        public static Items CreateSecondRoomNote()
        {
            Items secondRoomNote = new Items();
            secondRoomNote.Name = "Handskriven lapp";
            secondRoomNote.Type = "Note";
            secondRoomNote.Information = "Det här rummet är lite klurigare va? Lycka till att ta dig vidare";
            return secondRoomNote;
        }
        public static Items CreateFirstCombineNote()
        {
            Items firstCombineNote = new Items();
            firstCombineNote.Name = "Avrivet papper(vänster)";
            firstCombineNote.Type = "Note";
            firstCombineNote.Information = "Tänk skuggan faktiskt något att";
            return firstCombineNote;
        }
        public static Items CreateSecondCombineNote()
        {
            Items secondCombineNote = new Items();
            secondCombineNote.Name = "Avrivet papper(höger)";
            secondCombineNote.Type = "Note";
            secondCombineNote.Information = "om i lampan är som går använda";
            return secondCombineNote;
        }
        public static Items CreateFirstCombinedNote()
        {
            Items firstCombinedNote = new Items();
            firstCombinedNote.Name = "Ihoplagt papper";
            firstCombinedNote.Type = "Note";
            firstCombinedNote.Information = "Tänk om skuggan i lampan faktiskt är något som går att använda";
            return firstCombinedNote;
        }
        public static Items CreateDustyNote()
        {
            Items dustyNote = new Items();
            dustyNote.Name = "Dammig lapp";
            dustyNote.Type = "Note";
            dustyNote.Information = "Det är för dammigt för att tyda något";
            return dustyNote;
        }
        public static Items CreateOldShoe()
        {
            Items oldShoe = new Items();
            oldShoe.Name = "Gammal sko";
            oldShoe.Type = "Useless";
            oldShoe.Information = "Det är bara en sko, var är den andra?";
            return oldShoe;
        }
        public static Items CreateBurningTorch()
        {
            Items burningTorch = new Items();
            burningTorch.Name = "Tänd fakla";
            burningTorch.Type = "Useable";
            burningTorch.Information = "Lyser upp rummet";
            return burningTorch;
        }
    }
}
