using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransformeseApp2.DAL;

namespace TransformeseApp2.Desktop
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            CircleProgress();
            ContarAlunos();
            ContarCursos();
            ContarUnidades();
        }

        private void ContarAlunos()
        {
            lblAlunos.Text = Database.Alunos.Count.ToString();
        }

        private void ContarCursos()
        {
            lblCursos.Text = Database.Cursos.Count.ToString();
        }

        private void ContarUnidades()
        {
            lblUnidades.Text = Database.Unidades.Count.ToString();
        }

        public void CircleProgress()
        {
            timer.Interval = 50; // Velocidade da animação
            timer.Start();

            cpbAlunos.Minimum = 0;
            cpbAlunos.Maximum = 100;
            cpbAlunos.Value = Database.Alunos.Count;
    

            cpbCursos.Minimum = 0;
            cpbCursos.Maximum = 100;
            cpbCursos.Value = Database.Cursos.Count;

            cpbUnidades.Minimum = 0;
            cpbUnidades.Maximum = 100;
            cpbUnidades.Value = Database.Unidades.Count;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }


    }
}
