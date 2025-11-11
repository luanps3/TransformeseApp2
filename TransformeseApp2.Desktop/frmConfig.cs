using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransformeseApp2.BLL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.Desktop
{
    public partial class frmConfig : Form
    {
        private readonly UsuarioBLL usuarioBLL = new();

        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\transformese\usuarios";

        string diretorioImagens = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}";
        public frmConfig()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {


            try
            {
                var usuarioAtualizado = new UsuarioDTO
                {
                    Id = Session.UsuarioLogado.Id,
                    Nome = txtNome.Text,
                    Usuario = txtUsuario.Text,
                    Senha = txtSenha.Text,
                    UrlFoto = lblFotoCaminho.Text
                };

                usuarioBLL.AtualizarUsuario(usuarioAtualizado);
                MessageBox.Show($"Usuário {usuarioAtualizado.Nome} atualizado com sucesso!");
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro: {ex.Message}");
            }

        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtNome.Text = Session.UsuarioLogado.Nome;
            txtUsuario.Text = Session.UsuarioLogado.Usuario;
            txtSenha.Text = Session.UsuarioLogado.Senha;

            if (!string.IsNullOrEmpty(Session.UsuarioLogado.UrlFoto)
                &&
                File.Exists(Session.UsuarioLogado.UrlFoto))
            {
                pbFoto.Image = Image.FromFile(Session.UsuarioLogado.UrlFoto);
            }
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
                lblFotoCaminho.Text = nomeArquivoImagem;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var usuario = Session.UsuarioLogado;

            if (usuario == null)
            {
                MessageBox.Show("Nenhum usuário encontrado");
                return;
            }

            var confirma = MessageBox.Show("Exclusão de conta",
                $"{usuario.Nome}, tem certeza que deseja remover sua conta permanentemente," +
                $" você será desconectado da sessão, deseja continuar?",
                MessageBoxButtons.YesNo);

            if (confirma == DialogResult.Yes)
            {
                try
                {
                    usuarioBLL.RemoverUsuario(usuario.Id);
                    MessageBox.Show($"{usuario.Nome}" +
                        $", sua conta foi removida com sucesso! " +
                        $"vaza!");

                    Session.UsuarioLogado = null;
                    Session.user = null;

                    this.Hide();

                    Application.OpenForms
                        .OfType<frmMain>()
                        .FirstOrDefault()
                        ?.Close();

                    new frmLogin().Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir sua conta {ex.Message}");
                }
            }


        }
    }
}
