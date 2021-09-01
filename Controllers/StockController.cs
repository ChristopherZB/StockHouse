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
    public class StockController
    {
        private readonly MainDbContext context;

        public StockController(MainDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<StockObject>>> Get()//get list of Stock Objects
        {
            return await context.Stocks.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StockObject>> Get(int stockid)//get stock object through StockID; returns StockObject; params: stockid "stock ID"
        {
            var stock = await context.Stocks.FirstOrDefaultAsync(x => x.StockID == stockid);
            if (stock == null) { return NotFound(); }
            return stock;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Add(StockObject stockobj)//add StockObjects to database; returns StockObject.StockID; params: stockobj "stock object"
        {
            context.Add(stockobj);
            await context.SaveChangesAsync();
            return stockobj.StockID;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int stockid)// delete StockObjects from database; params: stockid "stock ID"
        {
            var stock = await context.Stocks.FirstOrDefaultAsync(x => x.StockID == stockid);
            if (stock == null)
            {
                return NoContent();
            }
            else
            {
                context.Remove(stock);
                await context.SaveChangesAsync();
                return NoContent();
            }

        }

        private ActionResult NoContent() //error handler for non-object return methods
        {
            throw new NotImplementedException();
        }

        private ActionResult<StockObject> NotFound()//error handler for object return methods
        {
            throw new NotImplementedException();
        }


    }
}
