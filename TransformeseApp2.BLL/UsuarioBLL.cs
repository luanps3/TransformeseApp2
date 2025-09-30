using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class UsuarioBLL
    {
        public void CadastrarUsuario(UsuarioDTO usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nome))
                throw new Exception("Nome é obrigatório.");
              
            
            if (string.IsNullOrWhiteSpace(usuario.Login))
                throw new Exception("Username é obrigatório.");

            
            if (string.IsNullOrWhiteSpace(usuario.Senha))
                throw new Exception("Senha é obrigatório.");
            
            Database.Usuarios.Add(usuario);

        }

        public UsuarioDTO? Login(string login, string senha)
        {
            var usuario = Database.Usuarios
                .FirstOrDefault(u => u.Login == login && u.Senha == senha);

            if (usuario == null)
            {
                throw new Exception("Usuário ou senha inválidos.");
            }

            return usuario;
        } 
    }
}
