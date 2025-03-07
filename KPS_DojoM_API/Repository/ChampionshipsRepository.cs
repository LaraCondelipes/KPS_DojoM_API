﻿using KPS_DojoM_API.Data;
using KPS_DojoM_models;
using Microsoft.EntityFrameworkCore;

namespace KPS_DojoM_API.Repository
{
    public class ChampionshipsRepository : IRepository<Championships>
    {
        private readonly KPS_DbContext context;

        public ChampionshipsRepository(KPS_DbContext context)
        { 
            this.context = context;
        }
        IEnumerable<Championships> IRepository<Championships>.All()
        { 
         return context
                .Championships
                .Include(x => x.Association)
                .Include(x => x.Events)
                .ToList();
        }

        public Championships? GetValue(int id)
        {
            return context
                .Championships
                .Include(x => x.Association)
                .Include(x => x.Events)
                .FirstOrDefault(x => x.ChampionshipsId == id); 
        }

        public Championships Add(Championships value)
        { 
            context.Championships.Add(value);   
            context.SaveChanges();

            return value;
        }

        public void Update(Championships value)
        { 
            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            var value = GetValue(id);

            if (value != null)
            {
                context.Championships.Remove(value);
                context.SaveChanges();  
            }
        }
    }
}
