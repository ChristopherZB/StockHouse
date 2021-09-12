using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Helpers.DTOs
{
    public class FilteringDTO
    {
        public string LocFilter { get; set;}
        public string NameFilter { get; set;}
        public string ItemFilter { get; set;}
        public string NumFilter { get; set; }
    }
}
