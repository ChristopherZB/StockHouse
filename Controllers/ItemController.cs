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

        [HttpGet]
        public async Task<ActionResult<List<ItemObject>>> Get()//get list of Item Objects
        {
            return await context.Items.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemObject>> Get(int itemid)//get item object through ItemID; returns ItemObject; params: itemid "item ID"
        {
            var item = await context.Items.FirstOrDefaultAsync(x => x.ItemID == itemid);
            if (item == null) { return NotFound(); }
            return item;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Add(ItemObject itm)//add ItemObject to database; returns ItemObject.ItemID; params: itm "item object"
        {
            context.Add(itm);
            await context.SaveChangesAsync();
            return itm.ItemID;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int itmid)// delete ItemObjects from database; params: itmid "item ID"
        {
            var item = await context.Items.FirstOrDefaultAsync(x => x.ItemID == itmid);
            if (item == null)
            {
                return NoContent();
            }
            else
            {
                context.Remove(item);
                await context.SaveChangesAsync();
                return NoContent();
            }

        }

        private ActionResult NoContent() //error handler for non-object return methods
        {
            throw new NotImplementedException();
        }

        private ActionResult<ItemObject> NotFound()//error handler for object return methods
        {
            throw new NotImplementedException();
        }


    }
}
