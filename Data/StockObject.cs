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

        public string StockName { get; set; }//retrival from get method in NameObject

        public string StockItemNum { get; set; }//retrival from itemNum textfield
        
        public string StockItemName { get; set; }//retrival from itemName textfield

        public string StockLocation { get; set; }//retrival from get method in LocationObject

        public int StockQuantity { get; set; }// retrival from quantity counter thing???

        public DateTime StockDateTime { get; set; }
    }
}
