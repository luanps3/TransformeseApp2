using Microsoft.Data.SqlClient;
using System.Data;
using TransformeseApp2.DTO;


namespace TransformeseApp2.DAL
{
    public class UsuarioDAL : Conexao
    {

        public void Create(UsuarioDTO usuario)
        {
            Conectar();
            if (conexao.State != ConnectionState.Open)
                throw new Exception("Conexão não foi aberta corretamente.");


            using (SqlTransaction transaction = conexao.BeginTransaction())
            {
                try
                {
                    // Inserir na tabela Pessoa
                    command = new SqlCommand(@"
                INSERT INTO Pessoa (Nome, Email, Telefone, DataNascimento, CPF, Sexo, UrlFoto)
                VALUES (@Nome, @Email, @Telefone, @DataNascimento, @CPF, @Sexo, @UrlFoto);
                SELECT CAST(SCOPE_IDENTITY() AS int);
            ", conexao, transaction);

                    command.Parameters.AddWithValue("@Nome", usuario.Nome);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                    command.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                    command.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
                    command.Parameters.AddWithValue("@CPF", usuario.CPF);
                    command.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                    command.Parameters.AddWithValue("@UrlFoto", (object)usuario.UrlFoto ?? DBNull.Value);

                    int idPessoa = Convert.ToInt32(command.ExecuteScalar());

                    // Inserir na tabela Usuario
                    command = new SqlCommand(@"
                INSERT INTO Usuario (Id, Usuario, Senha, TpUsuario)
                VALUES (@Id, @Usuario, @Senha, @TpUsuario);
            ", conexao, transaction);

                    command.Parameters.AddWithValue("@Id", idPessoa);
                    command.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                    command.Parameters.AddWithValue("@Senha", usuario.Senha);
                    command.Parameters.AddWithValue("@TpUsuario", usuario.TpUsuario);

                    command.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception erro)
                {
                    transaction.Rollback();
                    throw new Exception($"Erro ao cadastrar usuario, Erro do sistema: {erro.Message}");
                }
                finally
                {
                    Desconectar();
                }
            }
        }
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
						usuario.Usuario = dataReader["Usuario"].ToString();
						usuario.Senha = dataReader["Senha"].ToString();
						usuario.TpUsuario = (int)dataReader["TpUsuario"];
                    }
				}
				return usuario;

			}
			catch (Exception erro)
			{

				throw new Exception(erro.Message);
			}
        }

        public List<TipoUsuarioDTO> GetTipoUsuario()
        {
            List<TipoUsuarioDTO> tipos = new List<TipoUsuarioDTO>();

            try
            {
                Conectar();
                string sql = "SELECT IdTipoUsuario, DescricaoTipoUsuario FROM TipoUsuario";
                command = new SqlCommand(sql, conexao);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    tipos.Add(new TipoUsuarioDTO
                    {
                        IdTipoUsuario = Convert.ToInt32(dataReader["IdTipoUsuario"]),
                        DescricaoTipoUsuario = dataReader["DescricaoTipoUsuario"].ToString()
                    });
                }

                return tipos;
            }
            catch (Exception erro)
            {
                throw new Exception($"Erro ao listar tipos de usuário: {erro.Message}");
            }
            finally
            {
                Desconectar();
            }
        }


    }
}
