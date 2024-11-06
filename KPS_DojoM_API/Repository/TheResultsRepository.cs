using KPS_DojoM_API.Data;
using KPS_DojoM_models;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Core;


namespace KPS_DojoM_API.Repository
{
    public class TheResultsRepository : IRepository<TheResults>
    {
        public readonly KPS_DbContext context;

        public TheResultsRepository(KPS_DbContext context)
        {
            this.context = context;
        }

        IEnumerable<TheResults> IRepository<TheResults>.All()
        {
            return context
                .TheResults
                .Include(x=>x.Athletes)
                .Include(x=>x.Categories)
                .ToList();
        }

        public TheResults? GetValue(int id)
        { 
            return context
                .TheResults
                .Include(x => x.Athletes)
                .Include(x => x.Categories)
                .FirstOrDefault();
        }

        public TheResults Add(TheResults value)
        { 
            context.TheResults .Add(value);
            context.SaveChanges();

            return value;
        }

        public void Update(TheResults value)
        { 
            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();  
        }
        public void Delete(int id)
        {
           var value = GetValue(id);

            if (value != null)
            { 
                context.TheResults .Remove(value);  
                context.SaveChanges();
            }
        }
    }
}
