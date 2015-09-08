using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Denis.LojaVirtual.Dominio.Entidade;

namespace Denis.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }




    }
}
