using KPS_DojoM_API.Data;
using KPS_DojoM_models;
using Microsoft.EntityFrameworkCore;

namespace KPS_DojoM_API.Repository
{
    public class CategoriesRepository : IRepository<Categories>
    {
        private readonly KPS_DbContext context;

        public CategoriesRepository(KPS_DbContext context)
        {
            this.context = context;
        }

        IEnumerable<Categories> IRepository<Categories>.All()
        {
            return context
                .Categories
                .Include(x => x.Events)
                .Include(x => x.TheResults)
                .ToList();
        }

        public Categories? GetValue(int id)
        {
           return context
                .Categories
                .Include(x => x.Events)
                .Include(x => x.TheResults)
                .FirstOrDefault(x => x.CategoriesId == id);
        }
        public Categories Add(Categories entity)
        {
            context.Categories.Add(entity);
            context.SaveChanges();

            return entity;
        }

        public void Update(Categories entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();  
        }


        public void Delete(int id)
        {
           var entity = GetValue(id);

            if (entity != null)
            { 
                context.Categories.Remove(entity);
                context.SaveChanges();  
            }
        }

      

       
    }
}
