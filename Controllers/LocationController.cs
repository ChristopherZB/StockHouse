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
    public class LocationController
    {
        private readonly MainDbContext context;

        public LocationController(MainDbContext context)
        {
            this.context = context;
        }

     
        public async Task<List<LocationObject>> Get()//get list of Location Objects
        {
            return await context.Locations.ToListAsync();
        }

       
        public async Task<LocationObject> Get(int locid)//get location object through LocationID; returns LocationObject; params: locid "location ID"
        {
            var location = await context.Locations.FirstOrDefaultAsync(x => x.LocationID == locid);
            if (location == null) { return null; }
            return location;
        }


       
        public async Task<int> Add(LocationObject loc)//add LocationObject to database; returns LocationObject.LocationID; params: loc "location object"
        {
            context.Add(loc);
            await context.SaveChangesAsync();
            return loc.LocationID;
        }

       
        public async Task Delete(int locid)// delete LocationObjects from database; params: locid "location ID"
        {
            var location = await context.Locations.FirstOrDefaultAsync(x => x.LocationID == locid);
            if (location == null)
            {
                return ;
            }
            else
            {
                context.Remove(location);
                await context.SaveChangesAsync();
                return ;

        }

    }
}
