namespace TransformeseApp2.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbAlunos_Click(object sender, EventArgs e)
        {
            frmAlunos telaAlunos = new frmAlunos();
            telaAlunos.ShowDialog();
        }
    }
}
