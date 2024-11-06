using KPS_DojoM_API.Data;
using KPS_DojoM_models;
using Microsoft.EntityFrameworkCore;

namespace KPS_DojoM_API.Repository
{
    public class EventsRepository : IRepository<Events>
    {
        public readonly KPS_DbContext context;

        public EventsRepository(KPS_DbContext context)
        {
            this.context = context;
        }

        IEnumerable<Events> IRepository<Events>.All()
        {
            return context
                .Events
                .Include(x => x.Categories)
                .Include(x => x.Championships)
                .ToList();
        }

        public Events? GetValue(int id)
        { 
            return context
                .Events
                .Include(x => x.Categories)
                .Include(x => x.Championships)
                .FirstOrDefault(x => x.Id == id);
        }

        public Events Add(Events value)
        { 
            context.Events.Add(value);
            context.SaveChanges();

            return value;
        }

        public void Update(Events value)
        { 
            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = GetValue(id);
            if (value != null)
            { 
                context.Events.Remove(value);
                context.SaveChanges();  
            }
        }
    }
}
