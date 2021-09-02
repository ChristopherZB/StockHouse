using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockHouse.Data;
using StockHouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Controllers
{
    public class ItemController
    {
        private readonly MainDbContext context;

        public ItemController(MainDbContext context)
        {
            this.context = context;
        }

        
        public async Task<List<ItemObject>> Get()//get list of Item Objects
        {
            return await context.Items.ToListAsync();
        }

       
        public async Task<ItemObject> Get(int itemid)//get item object through ItemID; returns ItemObject; params: itemid "item ID"
        {
            var item = await context.Items.FirstOrDefaultAsync(x => x.ItemID == itemid);
            if (item == null) { return null; }
            return item;
        }


        
        public async Task<int> Add(ItemObject itm)//add ItemObject to database; returns ItemObject.ItemID; params: itm "item object"
        {
            context.Add(itm);
            await context.SaveChangesAsync();
            return itm.ItemID;
        }

       
        public async Task<List<ItemObject>> Delete(int itmid)// delete ItemObjects from database; params: itmid "item ID"
        {
            var item = await context.Items.FirstOrDefaultAsync(x => x.ItemID == itmid);
            if (item == null)
            {
                return null;
            }
            else
            {
                context.Remove(item);
                await context.SaveChangesAsync();
                return null;
            }

        }

        

    }
}
