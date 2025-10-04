using TransformeseApp2.DTO;

namespace TransformeseApp2.DAL
{
    //Simulação do banco de dados em memória
    public static class Database
    {
        public static List<AlunoDTO> Alunos { get; } = new() 
        { 
            new AlunoDTO {Id = 1, Nome = "Luan", CursoId = 1, UnidadeId = 1 },
            new AlunoDTO {Id = 2, Nome = "João", CursoId = 1, UnidadeId = 2 },
            new AlunoDTO {Id = 3, Nome = "Seu Jorge", CursoId = 2, UnidadeId = 1 },
            new AlunoDTO {Id = 4, Nome = "Paulo", CursoId = 2, UnidadeId = 1 },
            new AlunoDTO {Id = 5, Nome = "Enzo", CursoId = 1, UnidadeId = 2 }
        };
        public static List<CursoDTO> Cursos { get; } = new() 
        {
            new CursoDTO { Id = 1, Nome ="Transforme-se", CargaHoraria=280},
            new CursoDTO { Id = 2, Nome ="Programação em C#", CargaHoraria=72},
            new CursoDTO { Id = 3, Nome ="Banco de Dados SQL", CargaHoraria=80},
            new CursoDTO { Id = 4, Nome ="HTML", CargaHoraria=82},           
            new CursoDTO { Id = 5, Nome ="Lógica de Programação", CargaHoraria=82} ,          
            new CursoDTO { Id = 6, Nome ="Qualidade de Software", CargaHoraria=82},            
            new CursoDTO { Id = 7, Nome ="Cybersecurity", CargaHoraria=82}            
        };
        public static List<UnidadeDTO> Unidades { get; } = new() 
        {
        new UnidadeDTO{Id = 1, Nome="SMP - São Miguel Paulista", Endereco = "Av. Marechal Tito, 1500" },
        new UnidadeDTO{Id = 2, Nome="ITQ - Itaquera", Endereco = "Av. Itaquera, 8266" },
        new UnidadeDTO{Id = 3, Nome="ACL - Aclimação", Endereco = "Av. Aclimada, 999" },
        };

        public static List<UsuarioDTO> Usuarios { get; } = new() 
        {
            new UsuarioDTO {Id = 1, Nome = "Administrador", Login = "admin", Senha = "123"},
            new UsuarioDTO {Id = 2, Nome = "Professor", Login = "prof", Senha = "456"},
            new UsuarioDTO {Id = 3, Nome = "Aluno", Login = "aluno", Senha = "789"}
        }; 
    }
}
