using KPS_DojoM_API.Data;
using KPS_DojoM_models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Validations;

namespace KPS_DojoM_API.Repository
{
    public class ParentsRepository : IRepository<Parents>
    {
        public readonly KPS_DbContext context;

        public ParentsRepository(KPS_DbContext context)
        {
            this.context = context;  
        }

        IEnumerable<Parents> IRepository<Parents>.All()
        { 
            return context
                .Parents
                .Include(x=>x.athlete)
                .ToList();
        }

        public Parents? GetValue(int id)
        {
            return context
                .Parents
                .Include(x=>x.athlete)
                .FirstOrDefault(x=>x.Id==id);
        }

        public Parents Add(Parents value)
        {
            context.Parents.Add(value);
            context.SaveChanges();

            return value;
        }

        public void Update(Parents value)
        { 
            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var value = GetValue(id);

            if (value != null)
            {
                context.Parents.Remove(value);
                context.SaveChanges();
            }
        }
    }
}
