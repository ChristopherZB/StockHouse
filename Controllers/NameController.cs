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
    public class NameController
    {
        private readonly MainDbContext context;

        public NameController(MainDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<NameObject>>> Get()//get list of Name Objects
        {
            return await context.Names.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NameObject>> Get(int nameid)//get name object through NameID; returns NameObject; params: nameid "name ID"
        {
            var name = await context.Names.FirstOrDefaultAsync(x => x.NameID == nameid);
            if (name == null) { return NotFound(); }
            return name;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Add(NameObject nameobj)//add NameObjects to database; returns NameObject.NameID; params: nameobj "name object"
        {
            context.Add(nameobj);
            await context.SaveChangesAsync();
            return nameobj.NameID;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int nameid)// delete NameObjects from database; params: nameid "name ID"
        {
            var name = await context.Names.FirstOrDefaultAsync(x => x.NameID == nameid);
            if (name == null)
            {
                return NoContent();
            }
            else
            {
                context.Remove(name);
                await context.SaveChangesAsync();
                return NoContent();
            }

        }

        private ActionResult NoContent() //error handler for non-object return methods
        {
            throw new NotImplementedException();
        }

        private ActionResult<NameObject> NotFound()//error handler for object return methods
        {
            throw new NotImplementedException();
        }


    }
}
