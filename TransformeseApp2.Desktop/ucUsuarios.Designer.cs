namespace TransformeseApp2.Desktop
{
    partial class ucUsuarios
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            pbFoto = new PictureBox();
            txtFotoCaminho = new Label();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            txtBusca = new Guna.UI2.WinForms.Guna2TextBox();
            dgUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            chkSenha = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 17);
            label1.TabIndex = 0;
            label1.Text = "Selecione a foto:";
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.Fixed3D;
            pbFoto.Cursor = Cursors.Hand;
            pbFoto.Image = Properties.Resources.user;
            pbFoto.Location = new Point(7, 23);
            pbFoto.Margin = new Padding(4);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(241, 94);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 1;
            pbFoto.TabStop = false;
            pbFoto.Click += pbFoto_Click;
            // 
            // txtFotoCaminho
            // 
            txtFotoCaminho.AutoSize = true;
            txtFotoCaminho.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFotoCaminho.Location = new Point(7, 117);
            txtFotoCaminho.Margin = new Padding(4, 0, 4, 0);
            txtFotoCaminho.Name = "txtFotoCaminho";
            txtFotoCaminho.Size = new Size(98, 16);
            txtFotoCaminho.TabIndex = 0;
            txtFotoCaminho.Text = "caminho da foto";
            txtFotoCaminho.Visible = false;
            // 
            // txtNome
            // 
            txtNome.BorderRadius = 10;
            txtNome.CustomizableEdges = customizableEdges17;
            txtNome.DefaultText = "";
            txtNome.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNome.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNome.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNome.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNome.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Font = new Font("Segoe UI", 9F);
            txtNome.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Location = new Point(7, 137);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtNome.Size = new Size(241, 36);
            txtNome.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderRadius = 10;
            txtUsuario.CustomizableEdges = customizableEdges19;
            txtUsuario.DefaultText = "";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Segoe UI", 9F);
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Location = new Point(7, 179);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtUsuario.Size = new Size(241, 36);
            txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 10;
            txtSenha.CustomizableEdges = customizableEdges21;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(7, 221);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtSenha.Size = new Size(161, 36);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges23;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkGreen;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(10, 271);
            guna2Button1.Margin = new Padding(4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2Button1.Size = new Size(78, 47);
            guna2Button1.TabIndex = 5;
            guna2Button1.Text = "Cadastrar";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BorderRadius = 10;
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.CustomizableEdges = customizableEdges25;
            btnAtualizar.DisabledState.BorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAtualizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAtualizar.FillColor = Color.DodgerBlue;
            btnAtualizar.Font = new Font("Segoe UI", 9F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(90, 271);
            btnAtualizar.Margin = new Padding(4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnAtualizar.Size = new Size(78, 47);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar";
            // 
            // guna2Button3
            // 
            guna2Button3.BorderRadius = 10;
            guna2Button3.Cursor = Cursors.Hand;
            guna2Button3.CustomizableEdges = customizableEdges27;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.DarkRed;
            guna2Button3.Font = new Font("Segoe UI", 9F);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(170, 271);
            guna2Button3.Margin = new Padding(4);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges28;
            guna2Button3.Size = new Size(78, 47);
            guna2Button3.TabIndex = 5;
            guna2Button3.Text = "Excluir";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // txtBusca
            // 
            txtBusca.BorderRadius = 10;
            txtBusca.CustomizableEdges = customizableEdges29;
            txtBusca.DefaultText = "";
            txtBusca.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBusca.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBusca.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBusca.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBusca.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBusca.Font = new Font("Segoe UI", 9F);
            txtBusca.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBusca.Location = new Point(255, 23);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "";
            txtBusca.SelectedText = "";
            txtBusca.ShadowDecoration.CustomizableEdges = customizableEdges30;
            txtBusca.Size = new Size(204, 38);
            txtBusca.TabIndex = 6;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgUsuarios.ColumnHeadersHeight = 4;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgUsuarios.DefaultCellStyle = dataGridViewCellStyle6;
            dgUsuarios.GridColor = Color.FromArgb(231, 229, 255);
            dgUsuarios.Location = new Point(256, 69);
            dgUsuarios.Margin = new Padding(4);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.RowHeadersVisible = false;
            dgUsuarios.Size = new Size(302, 258);
            dgUsuarios.TabIndex = 8;
            dgUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgUsuarios.ThemeStyle.BackColor = Color.White;
            dgUsuarios.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgUsuarios.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgUsuarios.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgUsuarios.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgUsuarios.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgUsuarios.ThemeStyle.HeaderStyle.Height = 4;
            dgUsuarios.ThemeStyle.ReadOnly = false;
            dgUsuarios.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgUsuarios.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgUsuarios.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgUsuarios.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlText;
            dgUsuarios.ThemeStyle.RowsStyle.Height = 25;
            dgUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgUsuarios.CellClick += dgUsuarios_CellClick;
            // 
            // guna2Button4
            // 
            guna2Button4.BorderRadius = 10;
            guna2Button4.Cursor = Cursors.Hand;
            guna2Button4.CustomizableEdges = customizableEdges31;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.Font = new Font("Segoe UI", 9F);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.Location = new Point(466, 23);
            guna2Button4.Margin = new Padding(4);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges32;
            guna2Button4.Size = new Size(92, 38);
            guna2Button4.TabIndex = 5;
            guna2Button4.Text = "Pesquisar";
            // 
            // chkSenha
            // 
            chkSenha.AutoSize = true;
            chkSenha.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkSenha.CheckedState.BorderRadius = 0;
            chkSenha.CheckedState.BorderThickness = 0;
            chkSenha.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkSenha.Location = new Point(170, 226);
            chkSenha.Name = "chkSenha";
            chkSenha.Size = new Size(68, 25);
            chkSenha.TabIndex = 9;
            chkSenha.Text = "Exibir";
            chkSenha.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkSenha.UncheckedState.BorderRadius = 0;
            chkSenha.UncheckedState.BorderThickness = 0;
            chkSenha.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chkSenha.CheckedChanged += chkSenha_CheckedChanged;
            // 
            // ucUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkSenha);
            Controls.Add(dgUsuarios);
            Controls.Add(txtBusca);
            Controls.Add(guna2Button4);
            Controls.Add(guna2Button3);
            Controls.Add(btnAtualizar);
            Controls.Add(guna2Button1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            Controls.Add(pbFoto);
            Controls.Add(txtFotoCaminho);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "ucUsuarios";
            Size = new Size(574, 339);
            Load += ucUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbFoto;
        private Label txtFotoCaminho;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2TextBox txtBusca;
        private Guna.UI2.WinForms.Guna2DataGridView dgUsuarios;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2CheckBox chkSenha;
    }
}
