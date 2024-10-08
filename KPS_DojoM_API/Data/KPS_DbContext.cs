using KPS_DojoM_models;
using Microsoft.EntityFrameworkCore;

namespace KPS_DojoM_API.Data
{
    public class KPS_DbContext : DbContext
    {
        public KPS_DbContext(DbContextOptions<KPS_DbContext> options) : base(options)
        {

        }

        public DbSet<Athletes> athletes { get; set; } = default!;
        public DbSet<Association> association{get; set;} = default!;
        public DbSet<Categories> categories{get; set;} = default!;
        public DbSet<Championships> championships{ get; set; } = default!;
        public DbSet<Events> events{ get; set; } = default!;
        public DbSet<Parents> parents{ get; set; } = default!;
        public DbSet<TheResults> theResults{ get; set; } = default!;
        public DbSet<Senseis> senseis{ get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Athletes>().HasKey(e => new { e.ParentId, e.AssociationId});
        }

    }
}
