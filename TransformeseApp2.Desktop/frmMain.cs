using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            if (!string.IsNullOrEmpty(Session.UsuarioLogado.UrlFoto)
                && File.Exists(Session.UsuarioLogado.UrlFoto))
            {
                pbFoto.Image = Image.FromFile(Session.UsuarioLogado.UrlFoto);
            }

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

        private void pbColorMode_Click(object sender, EventArgs e)
        {
            bool isDarkMode = this.BackColor == Color.FromArgb(32, 32, 32);
            //bool estaChovendo = true;
            //string sairDeCasa = estaChovendo ? "Com Guarda chuva" : "sem guarda chuva";

            if (isDarkMode)
            {
                //Modo Claro - LigthMode
                Color ligthBackColor = SystemColors.ButtonHighlight;
                Color ligthPanelColor = Color.WhiteSmoke;

                this.BackColor = ligthBackColor;
                this.ForeColor = ligthPanelColor;

                panelConteudo.BackColor = ligthPanelColor;
                pbColorMode.Image = Properties.Resources.darkmode;

            }
            else
            {
                //Modo Escuro - DarkMode
                Color darkBackColor = Color.FromArgb(32, 32, 32);
                Color darkPanelColor = Color.FromArgb(45, 45, 45);

                this.BackColor = darkBackColor;
                this.ForeColor = darkPanelColor;

                panelConteudo.BackColor = darkPanelColor;
                pbColorMode.Image = Properties.Resources.ligthmode;
            }
        }

        private void pbSerasa_Click(object sender, EventArgs e)
        {
            AbrirLink("http://www.serasa.com.br/,");
        }

        private void pbSenac_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.sp.senac.br/");
        }

        private void pbGerando_Click(object sender, EventArgs e)
        {
            AbrirLink("https://gerandofalcoes.com/");
        }

        private void AbrirLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url)
                { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                mdNotifica.Show("Erro", $"erro: {ex.Message}");
            }
        }

        private void pbDiretorio_Click(object sender, EventArgs e)
        {
            string publica = @"T:\Publica\TRANSFORME-SE";

            try
            {
                if (Directory.Exists(publica))
                {
                    Process.Start("explorer.exe", publica);
                }
                else
                {
                    mdErro.Show("O diretorio não foi encontrado ou está inacessível");
                }
            }
            catch (Exception ex)
            {
                mdErro.Show($"Erro: {ex.Message}");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var confirmacao = mdConfirma.Show("Tem certeza que deseja encerrar sua sessão?");
            if (confirmacao == DialogResult.Yes)
            {
                FecharMain();
            }
        }
    }
}
