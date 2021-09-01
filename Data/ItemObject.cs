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
        public string ItemName { get; set; }//name of item being stored EX: 'chicken tendies'

        public float ItemNumber { get; set; }//serial number or whatever from barcode
    }
}
