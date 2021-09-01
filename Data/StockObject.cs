using StockHouse.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Data
{
    public class StockObject
    {
        //stock object fields 
        [Key]
        public int StockID { get; set; }

        [DisplayOnTable("Name")]
        [Column("Name")]
        public string StockName { get; set; }//retrival from get method in NameObject


        [Column("ItemNumber")]
        public float StockItemNum { get; set; }//retrival from itemNum textfield


        [DisplayOnTable("Item Name")]
        [Column("ItemName")]
        public string StockItemName { get; set; }//retrival from itemName textfield

        [DisplayOnTable("Location")]
        [Column("Location")]
        public string StockLocation { get; set; }//retrival from get method in LocationObject


        [DisplayOnTable("Quantity")]
        [Column("Quantity")]
        public int StockQuantity { get; set; }// retrival from quantity counter thing???


        [DisplayOnTable("Time Added")]
        [Column("DateTime")]
        public DateTime StockDateTime { get; set; }
    }
}
