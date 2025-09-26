using TransformeseApp2.DTO;

namespace TransformeseApp2.DAL
{
    //Simulação do banco de dados em memória
    public static class Database
    {
        public static List<AlunoDTO> Alunos { get; } = new();
        public static List<CursoDTO> Cursos { get; } = new();
        public static List<UnidadeDTO> Unidades { get; } = new();

        public static List<UsuarioDTO> Usuarios { get; } = new() 
        {
            new UsuarioDTO {Id = 1, Nome = "Administrador", Login = "admin", Senha = "123"},
            new UsuarioDTO {Id = 2, Nome = "Professor", Login = "prof", Senha = "456"},
            new UsuarioDTO {Id = 3, Nome = "Aluno", Login = "aluno", Senha = "789"}
        }; 
    }
}
