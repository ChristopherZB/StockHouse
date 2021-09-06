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

       
        public async Task<List<StockObject>> Get()//get list of Stock Objects
        {
            return await context.Stocks.ToListAsync();
        }

       
        public async Task<ActionResult<StockObject>> Get(int stockid)//get stock object through StockID; returns StockObject; params: stockid "stock ID"
        {
            var stock = await context.Stocks.FirstOrDefaultAsync(x => x.StockID == stockid);
            if (stock == null) { return null; }
            return stock;
        }


        
        public async Task<int> Add(StockObject stockobj)//add StockObjects to database; returns StockObject.StockID; params: stockobj "stock object"
        {
            context.Add(stockobj);
            await context.SaveChangesAsync();
            return stockobj.StockID;
        }

        
        public async Task Delete(int stockid)// delete StockObjects from database; params: stockid "stock ID"
        {
            var stock = await context.Stocks.FirstOrDefaultAsync(x => x.StockID == stockid);
            if (stock == null)
            {
                return ;
            }
            else
            {
                context.Remove(stock);
                await context.SaveChangesAsync();
                return ;
            }

        }

       

    }
}
