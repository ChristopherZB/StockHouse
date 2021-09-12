using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Helpers.DTOs
{
    public class SortingDTO
    {

        public StockFields Field { get; set; }
        public bool IsAcend { get; set; }
    }
}
