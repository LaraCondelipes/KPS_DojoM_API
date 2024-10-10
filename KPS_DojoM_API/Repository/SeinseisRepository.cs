using KPS_DojoM_API.Data;
using KPS_DojoM_models;
using Microsoft.EntityFrameworkCore;

namespace KPS_DojoM_API.Repository
{
    public class SeinseisRepository : IRepository<Senseis>
    {
        public readonly KPS_DbContext context;

        public SeinseisRepository(KPS_DbContext context)
        { 
            this.context = context;
        }

        IEnumerable<Senseis> IRepository<Senseis>.All()
        { 
            return context
                .Senseis
                .Include(x=>x.Association)
                .ToList();
        }

        public Senseis? GetValue(int id)
        { 
        return context
                .Senseis
                .Include(x=>x.Association)
                .FirstOrDefault(x=>x.Id == id);
        }

        public Senseis Add(Senseis value)
        { 
            context.Senseis.Add(value);
            context.SaveChanges();

            return value;
        }

        public void Update(Senseis value)
        { 
            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();

        }
        public void Delete(int id)
        {
            var value = GetValue(id);

            if (value != null)
            { 
                context .Senseis.Remove(value);
                context.SaveChanges();
            }
        }

        
    }
}
