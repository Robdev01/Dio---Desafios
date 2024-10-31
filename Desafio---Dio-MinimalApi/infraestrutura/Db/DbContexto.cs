using Microsoft.EntityFrameworkCore;
using Minimalapi.Dominio.Entidades;

namespace MinimalApi.Infraestrutura.Db
{
    public class DbContexto : DbContext
    {
        private readonly IConfiguration _configuracaoAppSettings;
        
        public DbContexto(IConfiguration configuracaoAppSettings)
        {
            _configuracaoAppSettings = configuracaoAppSettings;
        }
        
        public DbSet<Administrador> Administradores { get; set; } = default!;
        public DbSet<Veiculo> Veiculos { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.Entity<Administrador>().HasData(
            new Administrador{
                Id = 1,
                Email = "administrador@test.com",
                Senha = "123456",
                Perfil = "Adm"

            }
          );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var stringConexao = _configuracaoAppSettings.GetConnectionString("mysql");
            
            if (!string.IsNullOrEmpty(stringConexao))
            {
                optionsBuilder.UseMySql(stringConexao, 
                    ServerVersion.AutoDetect(stringConexao));
            }
        }
    }
}
