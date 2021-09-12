using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockHouse.Data;
using StockHouse.Database;
using StockHouse.Helpers;
using StockHouse.Helpers.DTOs;
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
                return;
            }
            else
            {
                context.Remove(stock);
                await context.SaveChangesAsync();
                return;
            }

        }

        public async Task<List<StockObject>> Sort(SortingDTO DTO)
        {

            List<StockObject> temp = await Get();
            if (DTO.IsAcend)
            {

                switch (DTO.Field)
                {
                    case StockFields.Name:
                        temp.OrderBy(x => x.StockName);

                        break;
                    case StockFields.Item:
                        temp.OrderBy(x => x.StockItemName);

                        break;
                    case StockFields.ItemNumber:
                        temp.OrderBy(x => x.StockItemNum);

                        break;
                    case StockFields.Location:
                        temp.OrderBy(x => x.StockLocation);

                        break;
                }

                return temp;
            }
            else
            {
                switch (DTO.Field)
                {
                    case StockFields.Name:
                        temp.OrderByDescending(x => x.StockName);

                        break;
                    case StockFields.Item:
                        temp.OrderByDescending(x => x.StockItemName);

                        break;
                    case StockFields.ItemNumber:
                        temp.OrderByDescending(x => x.StockItemNum);

                        break;
                    case StockFields.Location:
                        temp.OrderByDescending(x => x.StockLocation);

                        break;
                }

                return temp;
            }
        }
        public async Task<List<StockObject>> Filter(FilteringDTO DTO)
        {
            List<StockObject> temp = await Get();
            if (!string.IsNullOrWhiteSpace(DTO.LocFilter))
            {
                temp.Where(x => x.StockLocation == DTO.LocFilter);
            }
            if (!string.IsNullOrWhiteSpace(DTO.NameFilter))
            {
                temp.Where(x => x.StockLocation == DTO.NameFilter);
            }
            if (!string.IsNullOrWhiteSpace(DTO.ItemFilter))
            {
                temp.Where(x => x.StockLocation == DTO.ItemFilter);
            }
            if (!string.IsNullOrWhiteSpace(DTO.NumFilter))
            {
                temp.Where(x => x.StockLocation == DTO.NumFilter);
            }


            return temp;
        }



    }
}
