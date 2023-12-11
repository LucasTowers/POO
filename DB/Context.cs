using AppTorresVendas.Models;
using Microsoft.EntityFrameworkCore;


namespace AppTorresVendas.DB
{
    public class Context : DbContext
    {
        public DbSet<CategoriaModel>? Categorias { get; set; }
        public DbSet<ClienteModel>? Clientes { get; set; }
        public DbSet<PedidoModel>? Pedidos { get; set; }
        public DbSet<PedidoProdutoModel>? PedidosProdutos { get; set; }
        public DbSet<ProdutoModel>? Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = ServerVersion.AutoDetect("server=localhost;user=root;password=root123;database=sozinho");
            optionsBuilder.UseMySql("server=localhost;user=root;password=root123;database=sozinho", serverVersion);
        }     

    }
}
