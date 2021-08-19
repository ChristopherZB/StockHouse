using StockHouse.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Data
{
    public class TestObject
    {
        [DisplayOnTable]
        public string TestName { get; set; }
        [DisplayOnTable("Yeehaw")]
        public int TestInt { get; set; }
        public string AnotherTest { get; set; }
    }
}
