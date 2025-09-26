using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class UsuarioBLL
    {
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
