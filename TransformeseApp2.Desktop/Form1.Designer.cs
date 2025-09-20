namespace TransformeseApp2.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLogo = new PictureBox();
            pbCursos = new PictureBox();
            pbUnidades = new PictureBox();
            pbAlunos = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUnidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAlunos).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(312, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pbCursos
            // 
            pbCursos.Image = Properties.Resources.curso;
            pbCursos.Location = new Point(118, 134);
            pbCursos.Name = "pbCursos";
            pbCursos.Size = new Size(100, 100);
            pbCursos.SizeMode = PictureBoxSizeMode.Zoom;
            pbCursos.TabIndex = 1;
            pbCursos.TabStop = false;
            // 
            // pbUnidades
            // 
            pbUnidades.Image = Properties.Resources.escola;
            pbUnidades.Location = new Point(224, 134);
            pbUnidades.Name = "pbUnidades";
            pbUnidades.Size = new Size(100, 100);
            pbUnidades.SizeMode = PictureBoxSizeMode.Zoom;
            pbUnidades.TabIndex = 1;
            pbUnidades.TabStop = false;
            // 
            // pbAlunos
            // 
            pbAlunos.Image = Properties.Resources.aluno;
            pbAlunos.Location = new Point(12, 134);
            pbAlunos.Name = "pbAlunos";
            pbAlunos.Size = new Size(100, 100);
            pbAlunos.TabIndex = 1;
            pbAlunos.TabStop = false;
            pbAlunos.Click += pbAlunos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 261);
            Controls.Add(pbUnidades);
            Controls.Add(pbAlunos);
            Controls.Add(pbCursos);
            Controls.Add(pbLogo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUnidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAlunos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private PictureBox pbCursos;
        private PictureBox pbUnidades;
        private PictureBox pbAlunos;
    }
}
