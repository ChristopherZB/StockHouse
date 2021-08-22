using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Data
{
    public class ItemObject
    {
        public int ItemID { get; set; }

        public string ItemName { get; set; }//name of item being stored EX: 'chicken tendies'

        public float ItemNumber { get; set; }//serial number or whatever from barcode
    }
}
