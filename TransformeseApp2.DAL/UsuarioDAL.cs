using Microsoft.Data.SqlClient;
using TransformeseApp2.DTO;


namespace TransformeseApp2.DAL
{
    public class UsuarioDAL : Conexao
    {
        public UsuarioDTO Autenticar(string login, string senha)
        {
			try
			{
				Conectar();
				command = new SqlCommand(
			"SELECT * FROM Usuario WHERE Usuario = @Usuario AND Senha = @Senha", conexao);

				command.Parameters.AddWithValue("@Usuario", login);
				command.Parameters.AddWithValue("@Senha", senha);
				dataReader = command.ExecuteReader();

				UsuarioDTO usuario = null;
				if (dataReader.Read())
				{
					{
						usuario = new UsuarioDTO();
						usuario.Login = dataReader["Usuario"].ToString();
						usuario.Senha = dataReader["Senha"].ToString();
						usuario.TpUsuario = dataReader["TpUsuario"].ToString();
                    }
				}
				return usuario;

			}
			catch (Exception erro)
			{

				throw new Exception(erro.Message);
			}
        }

    }
}
