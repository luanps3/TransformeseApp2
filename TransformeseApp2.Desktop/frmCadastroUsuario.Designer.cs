namespace TransformeseApp2.Desktop
{
    partial class frmCadastroUsuario
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pbFoto = new PictureBox();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            txtFotoCaminho = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(26, 35);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(243, 32);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Cadastro de usuário";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Century Gothic", 12F);
            guna2HtmlLabel2.Location = new Point(26, 91);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(132, 23);
            guna2HtmlLabel2.TabIndex = 0;
            guna2HtmlLabel2.Text = "Selecione a foto:";
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Cursor = Cursors.Hand;
            pbFoto.Location = new Point(26, 120);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(167, 171);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 1;
            pbFoto.TabStop = false;
            pbFoto.Click += pbFoto_Click;
            // 
            // txtNome
            // 
            txtNome.BorderRadius = 8;
            txtNome.CustomizableEdges = customizableEdges1;
            txtNome.DefaultText = "Nome";
            txtNome.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNome.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNome.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNome.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNome.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Font = new Font("Segoe UI", 9F);
            txtNome.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Location = new Point(206, 120);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "";
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtNome.Size = new Size(140, 36);
            txtNome.TabIndex = 2;
            txtNome.Click += guna2TextBox1_Click;
            // 
            // txtUser
            // 
            txtUser.BorderRadius = 8;
            txtUser.CustomizableEdges = customizableEdges3;
            txtUser.DefaultText = "Username";
            txtUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Font = new Font("Segoe UI", 9F);
            txtUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Location = new Point(206, 162);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "";
            txtUser.SelectedText = "";
            txtUser.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUser.Size = new Size(140, 36);
            txtUser.TabIndex = 2;
            txtUser.Click += txtUser_Click;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 8;
            txtSenha.CustomizableEdges = customizableEdges5;
            txtSenha.DefaultText = "Senha";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(206, 204);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSenha.Size = new Size(140, 36);
            txtSenha.TabIndex = 2;
            txtSenha.Click += txtSenha_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BorderRadius = 8;
            btnCadastrar.CustomizableEdges = customizableEdges7;
            btnCadastrar.DisabledState.BorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadastrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadastrar.FillColor = Color.FromArgb(140, 10, 126);
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(206, 246);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCadastrar.Size = new Size(140, 45);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.FromArgb(140, 10, 126);
            btnFechar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(322, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(30, 30);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.Click += btnFechar_Click;
            // 
            // txtFotoCaminho
            // 
            txtFotoCaminho.BackColor = Color.Transparent;
            txtFotoCaminho.Font = new Font("Century Gothic", 12F);
            txtFotoCaminho.Location = new Point(26, 297);
            txtFotoCaminho.Name = "txtFotoCaminho";
            txtFotoCaminho.Size = new Size(134, 23);
            txtFotoCaminho.TabIndex = 0;
            txtFotoCaminho.Text = "caminho da foto";
            txtFotoCaminho.Visible = false;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.AnimationInterval = 250;
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(364, 330);
            Controls.Add(btnFechar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            Controls.Add(txtNome);
            Controls.Add(pbFoto);
            Controls.Add(txtFotoCaminho);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCadastroUsuario";
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private PictureBox pbFoto;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtFotoCaminho;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}