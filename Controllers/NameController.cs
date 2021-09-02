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

     
        public async Task<List<NameObject>> Get()//get list of Name Objects
        {
            return await context.Names.ToListAsync();
        }

        
        public async Task<ActionResult<NameObject>> Get(int nameid)//get name object through NameID; returns NameObject; params: nameid "name ID"
        {
            var name = await context.Names.FirstOrDefaultAsync(x => x.NameID == nameid);
            if (name == null) { return null; }
            return name;
        }


       
        public async Task<int> Add(NameObject nameobj)//add NameObjects to database; returns NameObject.NameID; params: nameobj "name object"
        {
            context.Add(nameobj);
            await context.SaveChangesAsync();
            return nameobj.NameID;
        }

        
        public async Task<List<NameObject>> Delete(int nameid)// delete NameObjects from database; params: nameid "name ID"
        {
            var name = await context.Names.FirstOrDefaultAsync(x => x.NameID == nameid);
            if (name == null)
            {
                return null;
            }
            else
            {
                context.Remove(name);
                await context.SaveChangesAsync();
                return null;
            }

        }

    }
}
