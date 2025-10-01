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
using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.Desktop
{
    public partial class frmCadastroUsuario : Form
    {
        UsuarioBLL usuarioBLL = new();

        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\transformese";

        string diretorioImagens = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}";

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = string.Empty;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = string.Empty;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //Nome da imagem a ser salva
            string nomeImg = $"{Database.Usuarios.Count + 1} - {txtUser.Text}.jpg";

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
                Login = txtUser.Text,
                Senha = txtSenha.Text,
                UrlFoto = txtFotoCaminho.Text
            };

            usuarioBLL.CadastrarUsuario(usuario);

            MessageBox.Show($"Usuário {usuario.Nome} cadastrado com sucesso!");

            txtNome.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtSenha.Text = string.Empty;
            pbFoto.Image = null;





        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtFotoCaminho.Text);
        }
    }
}
