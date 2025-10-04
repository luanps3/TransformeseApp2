using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
