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

        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\transformese\usuarios";

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
            txtUsuario.Text = string.Empty;
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
                Nome = txtNome.Text,
                Usuario = txtUsuario.Text,
                Senha = txtSenha.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                CPF = txtCPF.Text,
                DataNascimento = dtpData.Value,
                Sexo = cboSexo.Text,
                UrlFoto = txtFotoCaminho.Text,
                TpUsuario = (int)cboTipoUsuario.SelectedValue 
            };



            usuarioBLL.CadastrarUsuario(usuario);

            MessageBox.Show($"Usuário {usuario.Nome} cadastrado com sucesso!");

            txtNome.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtCPF.Text = string.Empty;
            cboSexo.Text = string.Empty;
            pbFoto.Image = null;





        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtFotoCaminho.Text);
        }
        bool bloqueandoEvento = false;
        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            var tipoUsuarioList = usuarioBLL.GetTipoUsuario();

            // Define o DataSource
            cboTipoUsuario.DataSource = tipoUsuarioList;
            cboTipoUsuario.DisplayMember = "DescricaoTipoUsuario";
            cboTipoUsuario.ValueMember = "IdTipoUsuario";

            // Opcional: adiciona um placeholder
            cboTipoUsuario.SelectedIndex = -1;
            cboTipoUsuario.Text = "Selecione o tipo";
        }
    }
}
