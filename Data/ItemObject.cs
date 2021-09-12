using StockHouse.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Data
{
    public class ItemObject
    {
        [Key]
        public int ItemID { get; set; }

        [Column("Name")]
        [DisplayOnTable]
        public string ItemName { get; set; }//name of item being stored EX: 'chicken tendies'

        [DisplayOnTable]
        public float ItemNumber { get; set; }//serial number or whatever from barcode

        public static bool ItemValidation(ItemObject obj)
        {
            return ItemNameValidation(obj) && ItemNumberValidation(obj);
        }

        public static bool ItemNameValidation(ItemObject obj)
        {
            return !string.IsNullOrWhiteSpace(obj.ItemName);
        }

        public static bool ItemNumberValidation(ItemObject obj)
        {
            return obj.ItemNumber > 0;
        }
    }
}
