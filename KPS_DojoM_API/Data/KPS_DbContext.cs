using KPS_DojoM_models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace KPS_DojoM_API.Data
{
    public class KPS_DbContext : DbContext
    {
        public KPS_DbContext(DbContextOptions<KPS_DbContext> options) : base(options)
        {

        }

        public DbSet<Athletes> Athletes { get; set; } = default!;
        public DbSet<Association> Association{get; set;} = default!;
        public DbSet<Categories> Categories{get; set;} = default!;
        public DbSet<Championships> Championships{ get; set; } = default!;
        public DbSet<Events> Events{ get; set; } = default!;
        public DbSet<Parents> Parents{ get; set; } = default!;
        public DbSet<TheResults> TheResults{ get; set; } = default!;
        public DbSet<Senseis> Senseis{ get; set; } = default!;


        //(OnModelCreating();) método que especifica como é que as classes(models)
        //devem ser traduzidas em tabelas e colunas no banco de dados.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Athletes>().HasKey(x => new { x.AssociationId, x.CategoryId, x.ParentId });
        }

    }
}
