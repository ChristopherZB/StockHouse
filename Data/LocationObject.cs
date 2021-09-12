using StockHouse.Helpers;
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
        [DisplayOnTable]
        public string Location { get; set; }

        public static bool LocationValidation(LocationObject obj)
        {
            return LocationNameValidation(obj);
        }

        public static bool LocationNameValidation(LocationObject obj)
        {
            return !string.IsNullOrWhiteSpace(obj.Location);
        }
    }
}
