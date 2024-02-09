using AppVendasWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AppVendasWeb.Data
{
    public class AppVendasContext : DbContext
    {
        public AppVendasContext(DbContextOptions<AppVendasContext> options) : base(options)
        { }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemDaVenda> ItemDaVendas { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Venda>().ToTable("Venda");
            modelBuilder.Entity<ItemDaVenda>().ToTable("ItemDaVenda");

        }
    }
}
