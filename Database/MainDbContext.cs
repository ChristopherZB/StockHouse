using Microsoft.EntityFrameworkCore;
using StockHouse.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Database
{
    public class MainDbContext : DbContext
    {

        public DbSet<ItemObject> Items { get; set; }
        public DbSet<LocationObject> Locations { get; set; }
        public DbSet<NameObject> Names { get; set; }
        public DbSet<StockObject> Stocks { get; set; }

    }
}
