using StockHouse.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Data
{
    public class StockObject
    {
        //stock object fields 
        public int StockID { get; set; }

        [DisplayOnTable("Name")]
        public string StockName { get; set; }//retrival from get method in NameObject


        
        public string StockItemNum { get; set; }//retrival from itemNum textfield


        [DisplayOnTable("Item Name")]
        public string StockItemName { get; set; }//retrival from itemName textfield

        [DisplayOnTable("Location")]

        public string StockLocation { get; set; }//retrival from get method in LocationObject


        [DisplayOnTable("Quantity")]
        public int StockQuantity { get; set; }// retrival from quantity counter thing???


        [DisplayOnTable("Time Added")]
        public DateTime StockDateTime { get; set; }
    }
}
