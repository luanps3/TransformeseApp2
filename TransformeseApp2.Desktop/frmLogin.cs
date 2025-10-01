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

namespace TransformeseApp2.Desktop
{
    public partial class frmLogin : Form
    {
        private readonly UsuarioBLL usuarioBLL = new();
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = usuarioBLL.Login(txtUsuario.Text, txtSenha.Text);

                MessageBox.Show($"Bem vindo(a) {txtUsuario.Text}");

                Form1 principal = new Form1();
                principal.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario obj = new();
            obj.ShowDialog();
        }
    }
}
