

using Microsoft.EntityFrameworkCore;
using RevendaVeiculos.Dominio.Entidades;
using RevendaVeiculos.Repositorio.Config;

namespace RevendaVeiculos.Repositorio.Contexto
{
    public class RevendaVeiculosContexto : DbContext
    {

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        public RevendaVeiculosContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new MarcaConfiguration());
            modelBuilder.ApplyConfiguration(new ProprietarioConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new VeiculoConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
