namespace TransformeseApp2.Desktop
{
    partial class frmCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAtualizar = new Button();
            label4 = new Label();
            btnExcluir = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dgAlunos = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBusca = new Button();
            btnCadastrar = new Button();
            cboUnidade = new ComboBox();
            cboCurso = new ComboBox();
            txtBusca = new TextBox();
            txtNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgAlunos).BeginInit();
            SuspendLayout();
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.DodgerBlue;
            btnAtualizar.Enabled = false;
            btnAtualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(138, 334);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(77, 38);
            btnAtualizar.TabIndex = 23;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(150, 105);
            label4.Name = "label4";
            label4.Size = new Size(82, 30);
            label4.TabIndex = 22;
            label4.Text = "Alunos";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.DarkRed;
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(221, 334);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(84, 38);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.aluno;
            pictureBox2.Location = new Point(52, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(311, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // dgAlunos
            // 
            dgAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlunos.Location = new Point(311, 197);
            dgAlunos.Name = "dgAlunos";
            dgAlunos.Size = new Size(438, 175);
            dgAlunos.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 287);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 15;
            label3.Text = "Unidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 234);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 16;
            label2.Text = "Curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 176);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 17;
            label1.Text = "Nome:";
            // 
            // btnBusca
            // 
            btnBusca.BackColor = Color.DodgerBlue;
            btnBusca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBusca.ForeColor = Color.Transparent;
            btnBusca.Location = new Point(623, 162);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(126, 32);
            btnBusca.TabIndex = 13;
            btnBusca.Text = "Pesquisar";
            btnBusca.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.Transparent;
            btnCadastrar.Location = new Point(55, 334);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(77, 38);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // cboUnidade
            // 
            cboUnidade.FormattingEnabled = true;
            cboUnidade.Location = new Point(55, 305);
            cboUnidade.Name = "cboUnidade";
            cboUnidade.Size = new Size(250, 23);
            cboUnidade.TabIndex = 11;
            // 
            // cboCurso
            // 
            cboCurso.FormattingEnabled = true;
            cboCurso.Location = new Point(55, 252);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(250, 23);
            cboCurso.TabIndex = 12;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(311, 168);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(306, 23);
            txtBusca.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(52, 197);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(253, 23);
            txtNome.TabIndex = 10;
            // 
            // frmCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(label4);
            Controls.Add(btnExcluir);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dgAlunos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBusca);
            Controls.Add(btnCadastrar);
            Controls.Add(cboUnidade);
            Controls.Add(cboCurso);
            Controls.Add(txtBusca);
            Controls.Add(txtNome);
            Name = "frmCursos";
            Text = "frmCursos";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtualizar;
        private Label label4;
        private Button btnExcluir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridView dgAlunos;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBusca;
        private Button btnCadastrar;
        private ComboBox cboUnidade;
        private ComboBox cboCurso;
        private TextBox txtBusca;
        private TextBox txtNome;
    }
}