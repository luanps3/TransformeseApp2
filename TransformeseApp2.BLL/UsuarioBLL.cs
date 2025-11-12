using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL usuarioDAL = new();
        // ============================================================
        // MÉTODO: CADASTRAR USUÁRIO
        // ============================================================
        public void CadastrarUsuario(UsuarioDTO usuario)
        {
            //ValidarCamposObrigatorios(usuario);

            //var usuarios = Database.Usuarios;

            //// Verifica duplicidade de login (case-insensitive)
            //if (usuarios.Any(u => u.Usuario.Equals(usuario.Usuario, StringComparison.OrdinalIgnoreCase)))
            //    throw new Exception("Este login já está em uso.");

            //// Gera um novo ID incremental
            //usuario.Id = usuarios.Count > 0 ? usuarios.Max(u => u.Id) + 1 : 1;

            //usuarios.Add(usuario);
            //Database.Usuarios = usuarios; // Salva no JSON
            usuarioDAL.Create(usuario);
        }

        // ============================================================
        // MÉTODO: LOGIN
        // ============================================================
        public UsuarioDTO Login(string login, string senha)
        {
            //if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            //    throw new Exception("Informe o login e a senha.");

            //var usuario = Database.Usuarios
            //    .FirstOrDefault(u =>
            //        u.Usuario.Equals(login, StringComparison.OrdinalIgnoreCase) &&
            //        u.Senha == senha);

            //if (usuario == null)
            //    throw new Exception("Usuário ou senha inválidos.");

            //return usuario;
            return usuarioDAL.Autenticar(login, senha);
        }

        public List<TipoUsuarioDTO> GetTipoUsuario()
        {
            return usuarioDAL.GetTipoUsuario();
        }

        // ============================================================
        // MÉTODO: LISTAR TODOS OS USUÁRIOS
        // ============================================================
        public List<UsuarioDTO> ListarUsuarios()
        {
            return Database.Usuarios.OrderBy(u => u.Nome).ToList();
        }

        // ============================================================
        // MÉTODO: BUSCAR POR ID
        // ============================================================
        public UsuarioDTO BuscarPorId(int id)
        {
            var usuario = Database.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null)
                throw new Exception("Usuário não encontrado.");
            return usuario;
        }

        // ============================================================
        // MÉTODO: ATUALIZAR USUÁRIO
        // ============================================================
        public void AtualizarUsuario(UsuarioDTO usuarioDTO)
        {
            ValidarCamposObrigatorios(usuarioDTO);

            var usuarios = Database.Usuarios;
            var usuarioExistente = usuarios.FirstOrDefault(u => u.Id == usuarioDTO.Id);

            if (usuarioExistente == null)
                throw new Exception("Usuário não encontrado.");

            // Verifica duplicidade de login (outro usuário com o mesmo login)
            if (usuarios.Any(u =>
                    u.Usuario.Equals(usuarioDTO.Usuario, StringComparison.OrdinalIgnoreCase) &&
                    u.Id != usuarioDTO.Id))
                throw new Exception("Já existe outro usuário com este login.");

            // Atualiza dados
            usuarioExistente.Nome = usuarioDTO.Nome;
            usuarioExistente.Usuario = usuarioDTO.Usuario;
            usuarioExistente.Senha = usuarioDTO.Senha;
            usuarioExistente.UrlFoto = usuarioDTO.UrlFoto;

            Database.Usuarios = usuarios; // Salva alterações
            
        }

        // ============================================================
        // MÉTODO: REMOVER USUÁRIO
        // ============================================================
        public void RemoverUsuario(int id)
        {
            var usuarios = Database.Usuarios;
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            usuarios.Remove(usuario);
            Database.Usuarios = usuarios;
        }

        // ============================================================
        // MÉTODO: VALIDAR CAMPOS
        // ============================================================
        private static void ValidarCamposObrigatorios(UsuarioDTO usuario)
        {
            if (usuario == null)
                throw new Exception("Objeto usuário inválido.");

            if (string.IsNullOrWhiteSpace(usuario.Nome))
                throw new Exception("Nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(usuario.Usuario))
                throw new Exception("Login é obrigatório.");

            if (string.IsNullOrWhiteSpace(usuario.Senha))
                throw new Exception("Senha é obrigatória.");
        }
    }
}
