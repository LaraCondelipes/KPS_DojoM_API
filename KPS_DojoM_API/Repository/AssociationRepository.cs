using KPS_DojoM_API.Data;
using KPS_DojoM_models;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Core;

namespace KPS_DojoM_API.Repository
{
    public class AssociationRepository : IRepository<Association>
    {
        private readonly KPS_DbContext context;

        public AssociationRepository(KPS_DbContext context)
        {
            this.context = context;
        }

        IEnumerable<Association> IRepository<Association>.All()
        {
            return context
                .Association
                .Include(b =>  b.Athlete)
                .ToList();

        }
        public Association? Get(int id)
        { 
        return context 
                .Association
                .Include(b => b.Athlete)
                .FirstOrDefault(b => b.Id == id);
        }
        public Association Add(Association value)
        {
            context.Association.Add(value);
            context.SaveChanges();

            return value;
        }

        public void Update(Association value)
        { 
            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(int id)
        { 
        var value = Get(id);
            if (value != null)
            { 
                context.Association.Remove(value);
                context.SaveChanges();
            }
        }

        public Association? GetValue(int id)
        {
            throw new NotImplementedException();
        }
    }
}
