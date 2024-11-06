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
                .Include(b => b.Athletes)
                .ToList();

        }
        public Association? GetValue(int id)
        {
            return context
                    .Association
                    .Include(b => b.Athletes)
                    .FirstOrDefault(b => b.AssociationId == id);
        }
        public Association Add(Association entity)
        {
            context.Association.Add(entity);
            context.SaveChanges();

            return entity;
        }

        public void Update(Association entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = GetValue(id);

            if (entity != null)
            {
                context.Association.Remove(entity);
                context.SaveChanges();
            }
        }


    }
}
