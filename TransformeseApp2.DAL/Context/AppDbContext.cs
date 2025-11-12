using Microsoft.EntityFrameworkCore;
using TransformeseApp2.DTO;

namespace TransformeseApp2.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public AppDbContext() { }

        public DbSet<PessoaDTO> Pessoas { get; set; } = default;
        public DbSet<CursoDTO> Cursos { get; set; } = default;
        public DbSet<UsuarioDTO> Usuarios { get; set; } = default;
        public DbSet<TipoUsuarioDTO> TipoUsuario{ get; set; } = default;
        public DbSet<UnidadeDTO> Unidades { get; set; } = default;

    }
}
