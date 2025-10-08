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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            AtualizarUsuarioLogado();
            AbrirUserControl(new ucHome());
        }

        private void AbrirUserControl(UserControl uc)
        {
            //Limpa o que tiver no painel
            panelConteudo.Controls.Clear();

            // Configura o novo User Control
            uc.Dock = DockStyle.Fill;

            panelConteudo.Controls.Add(uc);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FecharMain();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            FecharMain();
        }

        private void FecharMain()
        {
            Close();
            frmLogin telaLogin = new();
            telaLogin.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            AbrirUserControl(new ucHome());
        }

        public void AtualizarUsuarioLogado()
        {
            //Centralizar Horizontalmente em relação a pbFoto
            lblUser.Left = pbFoto.Left + 4 + (pbFoto.Width - lblUser.Width) / 2;

            lblUser.Top = pbFoto.Bottom + 4;

            lblUser.Text = Session.UsuarioLogado.Nome ?? "Usuário";
            
        }

        private void pbNotification_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(npNotifica.Text, out int qtdNotifica))
                {
                    if (qtdNotifica > 0)
                    {
                        qtdNotifica--;
                        npNotifica.Text = qtdNotifica > 0 ?
                            qtdNotifica.ToString() : string.Empty;

                        npNotifica.FillColor = qtdNotifica > 0 ?
                            npNotifica.FillColor : Color.Transparent;

                        string mensagem = qtdNotifica > 0 ?
                            "Aqui serão exibidas as notificações" : "Não há notificações";

                        mdNotifica.Show(mensagem);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            AbrirUserControl(new ucUsuarios());
        }
    }
}
