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
            string nomeImg = $"{Database.Usuarios.Count + 1} - {txtUser.Text}.jpg";
        }
    }
}
