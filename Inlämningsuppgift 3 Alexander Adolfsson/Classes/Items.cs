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
    }
}
