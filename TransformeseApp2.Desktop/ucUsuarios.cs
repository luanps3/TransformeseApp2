using System.Data;
using TransformeseApp2.BLL;
using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.Desktop
{
    public partial class ucUsuarios : UserControl
    {
        UsuarioBLL usuarioBLL = new();
        private int? usuarioSelecionadoId = null;

        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\transformese\usuarios";

        string diretorioImagens = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}";
        public ucUsuarios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = diretorioImagens;
            openFileDialog.Filter = "Arquivos de imagens |*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Escolha a imagem e se transforme";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = openFileDialog.FileName;

                //Exibe a imagem escolhida no pictureBox
                pbFoto.Image = Image.FromFile(nomeArquivoImagem);

                //Salva o caminho da foto
                txtFotoCaminho.Text = nomeArquivoImagem;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            //Nome da imagem a ser salva
            string nomeImg = $"{Database.Usuarios.Count + 1} - {txtUsuario.Text}.jpg";

            //verifica se o diretório para salvar as imagens existe.
            if (!Directory.Exists(diretorio))
            {
                //caso não exista, cria o diretório.
                Directory.CreateDirectory(diretorio);
            }

            //URL da Imagem
            string UrlImagem = Path.Combine(diretorio, nomeImg);

            Image imagem = pbFoto.Image;
            imagem.Save(UrlImagem);

            var usuario = new UsuarioDTO
            {
                Id = Database.Usuarios.Count + 1,
                Nome = txtNome.Text,
                Login = txtUsuario.Text,
                Senha = txtSenha.Text,
                UrlFoto = txtFotoCaminho.Text
            };

            usuarioBLL.CadastrarUsuario(usuario);

            MessageBox.Show($"Usuário {usuario.Nome} cadastrado com sucesso!");
            AtualizarGrid();


            txtNome.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
            pbFoto.Image = null;

        }

        private void ucUsuarios_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            
            dgUsuarios.Columns.Clear();
            dgUsuarios.AutoGenerateColumns = false;
            dgUsuarios.RowTemplate.Height = 60;
            dgUsuarios.AllowUserToAddRows = false;

            var colFoto = new DataGridViewImageColumn
            { 
                HeaderText = "Foto",
                Name = "Foto",
                DataPropertyName = "Foto",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
            };

            dgUsuarios.Columns.Add(colFoto);

            dgUsuarios.Columns.Add(new DataGridViewTextBoxColumn{ DataPropertyName = "Id", HeaderText="ID", Name="Id" });
            dgUsuarios.Columns.Add(new DataGridViewTextBoxColumn{ DataPropertyName = "Nome", HeaderText="Nome", Name="Nome" });
            dgUsuarios.Columns.Add(new DataGridViewTextBoxColumn{ DataPropertyName = "Login", HeaderText= "User", Name= "Login" });
            dgUsuarios.Columns.Add(new DataGridViewTextBoxColumn{ DataPropertyName = "Senha", HeaderText= "Senha", Name= "Senha" });
            dgUsuarios.Columns.Add(new DataGridViewTextBoxColumn{ DataPropertyName = "UrlFoto", HeaderText= "UrlFoto", Name= "UrlFoto" });

            var usuarios = usuarioBLL.ListarUsuarios();

            var dt = new DataTable();
            dt.Columns.Add("Foto", typeof(Image));
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Login", typeof(string));
            dt.Columns.Add("Senha", typeof(string));
            dt.Columns.Add("UrlFoto", typeof(string));

            foreach(var u in usuarios)
            {
                Image? img = null;

                if (!string.IsNullOrEmpty(u.UrlFoto) && File.Exists(u.UrlFoto))
                {
                    try
                    {
                        using(var fs = new FileStream(u.UrlFoto,FileMode.Open, FileAccess.Read))
                        {
                            img = Image.FromStream(fs);
                        }
                    }
                    catch (Exception)
                    {
                        img = null;
                    }
                }
                dt.Rows.Add(img, u.Id, u.Nome, u.Login, u.Senha, u.UrlFoto);
            }
            dgUsuarios.DataSource = dt;


            /*

            seu código

            */
        }




        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
                chkSenha.Text = "Ocultar";
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                chkSenha.Text = "Exibir";
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um aluno para excluir");
                return;
            }

            int id = dgUsuarios.SelectedRows[0].Cells["Id"]
                .Value.GetHashCode();

            string nome = dgUsuarios.SelectedRows[0].Cells["Nome"].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja excluir o aluno {nome}?",
                "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                usuarioBLL.RemoverUsuario(id);
                MessageBox.Show($"Usuário {nome} removido com sucesso!");
                AtualizarGrid();
            }

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario();
        }


        private void BuscarUsuario()
        {
            string termo = txtBusca.Text.Trim().ToLower();

            var filtrados = usuarioBLL.ListarUsuarios()
                                    .Where(usuario => usuario.Nome.ToLower().Contains(termo))
                                    .Select(usuario => new
                                    {
                                        usuario.Id,
                                        usuario.Nome,
                                        usuario.Login,
                                        usuario.Senha,
                                        usuario.UrlFoto

                                    }).ToList();

            dgUsuarios.DataSource = filtrados;
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgUsuarios.Rows[e.RowIndex];
                var dataRow = row.DataBoundItem as DataRowView;

                if (dataRow != null)
                {
                    usuarioSelecionadoId = Convert.ToInt32(dataRow["Id"]);
                    txtNome.Text = dataRow["Nome"].ToString();
                    txtUsuario.Text = dataRow["Login"].ToString();
                    txtSenha.Text = dataRow["Senha"].ToString();
                    txtFotoCaminho.Text = dataRow["UrlFoto"].ToString();


                    string caminho = dataRow["UrlFoto"].ToString();


                    pbFoto.Image = (!string.IsNullOrWhiteSpace(caminho) && File.Exists(caminho))
                        ? Image.FromFile(caminho)
                        : Properties.Resources.user;

                    btnAtualizar.Enabled = true;
                }
            }
        }
    }
}
