using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Data
{
    public class LocationObject
    {
        [Key]
        public int LocationID { get; set; }
        public string Location { get; set; }
    }
}
