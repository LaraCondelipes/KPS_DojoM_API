using KPS_DojoM_API.Data;
using KPS_DojoM_models;
using Microsoft.EntityFrameworkCore;

namespace KPS_DojoM_API.Repository
{
    public class AthletesRepository : IRepository<Athletes>
    {
        private readonly KPS_DbContext context;

        public AthletesRepository(KPS_DbContext context)
        { 
            this.context = context;
        }

        IEnumerable<Athletes> IRepository<Athletes>.All()
        {
            return context
                .Athletes
                .Include(x => x.Categories)
                .ToList();
        }


        public Athletes? GetValue(int id)
        {
            return context
                .Athletes
                .Include(x => x.Categories)
                .FirstOrDefault(x => x.Id == id);
        }

        public Athletes Add(Athletes entity)
        {
           context.Athletes.Add(entity);
            context.SaveChanges();

            return entity;
        }

        public void Update(Athletes entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetValue(id);

            if (entity != null)
            { 
                context.Athletes.Remove(entity);
                context.SaveChanges();
            }
        }

        
    }
}
