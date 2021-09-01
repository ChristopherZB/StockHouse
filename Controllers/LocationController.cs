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

        [HttpGet]
        public async Task<ActionResult<List<LocationObject>>> Get()//get list of Location Objects
        {
            return await context.Locations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LocationObject>> Get(int locid)//get location object through LocationID; returns LocationObject; params: locid "location ID"
        {
            var location = await context.Locations.FirstOrDefaultAsync(x => x.LocationID == locid);
            if (location == null) { return NotFound(); }
            return location;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Add(LocationObject loc)//add LocationObject to database; returns LocationObject.LocationID; params: loc "location object"
        {
            context.Add(loc);
            await context.SaveChangesAsync();
            return loc.LocationID;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int locid)// delete LocationObjects from database; params: locid "location ID"
        {
            var location = await context.Locations.FirstOrDefaultAsync(x => x.LocationID == locid);
            if (location == null)
            {
                return NoContent();
            }
            else
            {
                context.Remove(location);
                await context.SaveChangesAsync();
                return NoContent();
            }

        }

        private ActionResult NoContent() //error handler for non-object return methods
        {
            throw new NotImplementedException();
        }

        private ActionResult<LocationObject> NotFound()//error handler for object return methods
        {
            throw new NotImplementedException();
        }


    }
}
