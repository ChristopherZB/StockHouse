using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Helpers
{
    public class DisplayOnTable : Attribute
    {
        public bool UseFieldName;
        public string DisplayName;

        public DisplayOnTable()
        {
            UseFieldName = true;
        }
        public DisplayOnTable(string displayName)
        {
            UseFieldName = false;
            DisplayName = displayName;
        }
    }
}
