using Ristorante.Mamma.Carielo.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ristorante.Mamma.Carielo.Persistence.Context
{
    public class RistoranteMammaCarieloDbContext : DbContext
    {
        public RistoranteMammaCarieloDbContext()
            : base("RistoranteMammaCarieloDbContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Cliente>().HasKey(p => p.ClienteId);
            modelBuilder.Entity<Despesa>().HasKey(p => p.DespesaId);
            modelBuilder.Entity<Faturamento>().HasKey(p => p.FaturamentoId);
            modelBuilder.Entity<Mercado>().HasKey(p => p.MercadoId);
        }
    }
}
