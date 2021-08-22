using StockHouse.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Helpers
{
    public class TestingData
    {
        public static List<ItemObject> ItemObjects = new List<ItemObject>
        {
            new ItemObject { ItemID = 0, ItemName = "A", ItemNumber = 111111111111 },
            new ItemObject { ItemID = 1, ItemName = "B", ItemNumber = 222222222222 },
            new ItemObject { ItemID = 2, ItemName = "C", ItemNumber = 333333333333 },
            new ItemObject { ItemID = 3, ItemName = "D", ItemNumber = 444444444444 },
            new ItemObject { ItemID = 4, ItemName = "E", ItemNumber = 555555555555 },
            new ItemObject { ItemID = 5, ItemName = "F", ItemNumber = 666666666666 }
        };

        public static List<LocationObject> LocationObjects = new List<LocationObject>
        {
            new LocationObject { LocationID = 0, Location = "Chest Freezer" },
            new LocationObject { LocationID = 1, Location = "Fridge" },
            new LocationObject { LocationID = 2, Location = "Fridge Freezer" },
            new LocationObject { LocationID = 3, Location = "Cabinet" }
        };

        public static List<NameObject> NameObjects = new List<NameObject>
        {
            new NameObject { NameID = 0, Name = "Chris" },
            new NameObject { NameID = 1, Name = "Kyle" },
            new NameObject { NameID = 2, Name = "Brady" },
            new NameObject { NameID = 3, Name = "Parker" },
            new NameObject { NameID = 4, Name = "Maeve" }
        };

        public static List<StockObject> StockObjects = new List<StockObject>
        {
            new StockObject { StockID = 0, StockName = "Chris", StockItemName = "A", StockLocation = "Fridge", StockQuantity = 3, StockItemNum = "111111111111", StockDateTime = DateTime.Now.AddDays(-4) },
            new StockObject { StockID = 1, StockName = "Brady", StockItemName = "A", StockLocation = "Fridge", StockQuantity = 2, StockItemNum = "111111111111", StockDateTime = DateTime.Now.AddDays(-2) },
            new StockObject { StockID = 2, StockName = "Parker", StockItemName = "A", StockLocation = "Fridge", StockQuantity = 10, StockItemNum = "111111111111", StockDateTime = DateTime.Now.AddDays(-1) },
            new StockObject { StockID = 3, StockName = "Parker", StockItemName = "C", StockLocation = "Cabinet", StockQuantity = 40, StockItemNum = "333333333333", StockDateTime = DateTime.Now.AddDays(-7) },
            new StockObject { StockID = 4, StockName = "Parker", StockItemName = "F", StockLocation = "Fridge Freezer", StockQuantity = 4, StockItemNum = "666666666666", StockDateTime = DateTime.Now.AddDays(-4) },
            new StockObject { StockID = 5, StockName = "Parker", StockItemName = "B", StockLocation = "Chest Freezer", StockQuantity = 6, StockItemNum = "222222222222", StockDateTime = DateTime.Now.AddDays(-4) },
            new StockObject { StockID = 6, StockName = "Brady", StockItemName = "D", StockLocation = "Cabinet", StockQuantity = 2, StockItemNum = "444444444444", StockDateTime = DateTime.Now.AddDays(-4) },
            new StockObject { StockID = 7, StockName = "Chris", StockItemName = "E", StockLocation = "Fridge", StockQuantity = 2, StockItemNum = "555555555555", StockDateTime = DateTime.Now.AddDays(-3) },
            new StockObject { StockID = 8, StockName = "Chris", StockItemName = "B", StockLocation = "Chest Freezer", StockQuantity = 8, StockItemNum = "222222222222", StockDateTime = DateTime.Now.AddDays(-1) },
            new StockObject { StockID = 9, StockName = "Chris", StockItemName = "F", StockLocation = "Chest Freezer", StockQuantity = 7, StockItemNum = "666666666666", StockDateTime = DateTime.Now.AddDays(-4) },
            new StockObject { StockID = 10, StockName = "Kyle", StockItemName = "C", StockLocation = "Cabinet", StockQuantity = 13, StockItemNum = "333333333333", StockDateTime = DateTime.Now.AddDays(-8) },
        };
    }
}
