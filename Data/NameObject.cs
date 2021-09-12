using StockHouse.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Data
{
    public class NameObject
    {
        [Key]
        public int NameID { get; set; }
        [DisplayOnTable]
        public string Name { get; set; }

        public static bool NameValidation(NameObject obj)
        {
            return NameNameValidation(obj);
        }

        public static bool NameNameValidation(NameObject obj)
        {
            return !string.IsNullOrWhiteSpace(obj.Name);
        }
    }
}
