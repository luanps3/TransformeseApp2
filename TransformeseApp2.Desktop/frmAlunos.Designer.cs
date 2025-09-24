namespace TransformeseApp2.Desktop
{
    partial class frmAlunos
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
            txtNome = new TextBox();
            cboCurso = new ComboBox();
            cboUnidade = new ComboBox();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgAlunos = new DataGridView();
            txtBusca = new TextBox();
            btnBusca = new Button();
            pictureBox1 = new PictureBox();
            btnExcluir = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgAlunos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(19, 131);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(166, 23);
            txtNome.TabIndex = 0;
            // 
            // cboCurso
            // 
            cboCurso.FormattingEnabled = true;
            cboCurso.Location = new Point(22, 186);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(163, 23);
            cboCurso.TabIndex = 1;
            // 
            // cboUnidade
            // 
            cboUnidade.FormattingEnabled = true;
            cboUnidade.Location = new Point(22, 239);
            cboUnidade.Name = "cboUnidade";
            cboUnidade.Size = new Size(163, 23);
            cboUnidade.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.Transparent;
            btnCadastrar.Location = new Point(22, 268);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(77, 38);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 110);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 168);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 221);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Unidade:";
            // 
            // dgAlunos
            // 
            dgAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlunos.Location = new Point(191, 131);
            dgAlunos.Name = "dgAlunos";
            dgAlunos.Size = new Size(476, 175);
            dgAlunos.TabIndex = 4;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(191, 102);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(393, 23);
            txtBusca.TabIndex = 0;
            // 
            // btnBusca
            // 
            btnBusca.BackColor = Color.DodgerBlue;
            btnBusca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBusca.ForeColor = Color.Transparent;
            btnBusca.Location = new Point(590, 96);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(77, 32);
            btnBusca.TabIndex = 2;
            btnBusca.Text = "Pesquisar";
            btnBusca.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(255, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.DarkRed;
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(101, 268);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(84, 38);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 31);
            label4.Name = "label4";
            label4.Size = new Size(237, 32);
            label4.TabIndex = 7;
            label4.Text = "Cadastro de Alunos";
            // 
            // frmAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 330);
            Controls.Add(label4);
            Controls.Add(btnExcluir);
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
            Name = "frmAlunos";
            Text = "frmAlunos";
            Load += frmAlunos_Load;
            ((System.ComponentModel.ISupportInitialize)dgAlunos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private ComboBox cboCurso;
        private ComboBox cboUnidade;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgAlunos;
        private TextBox txtBusca;
        private Button btnBusca;
        private PictureBox pictureBox1;
        private Button btnExcluir;
        private Label label4;
    }
}