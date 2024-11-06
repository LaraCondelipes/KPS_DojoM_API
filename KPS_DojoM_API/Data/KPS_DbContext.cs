using KPS_DojoM_models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace KPS_DojoM_API.Data
{
    public class KPS_DbContext(DbContextOptions<KPS_DbContext> options) : DbContext(options)
    {
        public DbSet<Athletes> Athletes { get; set; } = default!;
        public DbSet<Association> Association{get; set;} = default!;
        public DbSet<Categories> Categories { get; set; } = default!;
        //public DbSet<EventCategories> EventCategories { get; set; } = default!; 
        //public DbSet<ResultCategories> ResultCategories { get; set; }
        public DbSet<Championships> Championships{ get; set; } = default!;
        public DbSet<Events> Events{ get; set; } = default!;
        public DbSet<Parents> Parents{ get; set; } = default!;
        public DbSet<TheResults> TheResults{ get; set; } = default!;
        public DbSet<Senseis> Senseis{ get; set; } = default!;


        //(OnModelCreating();) método que especifica como é que as classes(models)
        //devem ser traduzidas em tabelas e colunas no banco de dados.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Athletes>().HasKey(x => new { x.AssociationId, x.ParentId });

            //modelBuilder.Entity<Athletes>()
            //    .HasOne(x=>x.Parents)
            //    .WithOne(x=>x.Athlete)
            //    .
            //modelBuilder.Entity<ResultCategories>().HasKey(x => new{x.TheResultsId, x.CategoriesId});
            //modelBuilder.Entity<EventCategories>().HasKey(x => new { x.EventsId, x.CategoriesId });

            //Many-to-Many realations
            //modelBuilder.Entity<ResultCategories>().HasOne(c => c.TheResults).WithMany(c => c.ResultCategories).HasForeignKey(c => c.TheResultsId).OnDelete(DeleteBehavior.Restrict); //OnDelete() => config. behavior for define de value of the foreign key as NULL instead of deleting the related records and prevent cascading behaviour.
            //modelBuilder.Entity<ResultCategories>().HasOne(c => c.Categories).WithMany(c => c.ResultCategories).HasForeignKey(c => c.CategoriesId).OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<EventCategories>().HasOne(a => a.Events).WithMany(a => a.EventCategories).HasForeignKey(a => a.EventsId).OnDelete(DeleteBehavior.Restrict); 
            //modelBuilder.Entity<EventCategories>().HasOne(a => a.Categories).WithMany(a => a.EventCategories).HasForeignKey(a => a.CategoriesId).OnDelete(DeleteBehavior.Restrict);
        }

    }
}
