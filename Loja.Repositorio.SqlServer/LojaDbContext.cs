using Loja.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using Loja.Repositorio.SqlServer.ModelConfiguration;

namespace Loja.Repositorio.SqlServer
{
    public class LojaDbContext : DbContext
    {
        public LojaDbContext() : base("LojaSqlServer")
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Produto> Pedidos { get; set; }
        public DbSet<Produto> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add();

            base.OnModelCreating(modelBuilder);
        }
    }
}
