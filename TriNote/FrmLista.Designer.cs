namespace TriNote
{
    partial class FrmLista
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
            this.lstFuncionarios = new System.Windows.Forms.ListView();
            this.funcionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.permissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ativo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSuporte = new System.Windows.Forms.RadioButton();
            this.rbGerencia = new System.Windows.Forms.RadioButton();
            this.rbMarketing = new System.Windows.Forms.RadioButton();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFuncionarios
            // 
            this.lstFuncionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.funcionario,
            this.id,
            this.login,
            this.permissao,
            this.ativo});
            this.lstFuncionarios.FullRowSelect = true;
            this.lstFuncionarios.GridLines = true;
            this.lstFuncionarios.Location = new System.Drawing.Point(12, 49);
            this.lstFuncionarios.Name = "lstFuncionarios";
            this.lstFuncionarios.Size = new System.Drawing.Size(365, 276);
            this.lstFuncionarios.TabIndex = 5;
            this.lstFuncionarios.UseCompatibleStateImageBehavior = false;
            this.lstFuncionarios.View = System.Windows.Forms.View.Details;
            this.lstFuncionarios.DoubleClick += new System.EventHandler(this.lstFuncionarios_DoubleClick);
            // 
            // funcionario
            // 
            this.funcionario.Text = "Funcionário";
            this.funcionario.Width = 107;
            // 
            // id
            // 
            this.id.Text = "Código";
            this.id.Width = 54;
            // 
            // login
            // 
            this.login.Text = "Login";
            this.login.Width = 75;
            // 
            // permissao
            // 
            this.permissao.Text = "Permissão";
            this.permissao.Width = 77;
            // 
            // ativo
            // 
            this.ativo.Text = "Ativo?";
            this.ativo.Width = 48;
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.AutoSize = true;
            this.lblFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarios.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFuncionarios.Location = new System.Drawing.Point(112, 9);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Size = new System.Drawing.Size(136, 25);
            this.lblFuncionarios.TabIndex = 6;
            this.lblFuncionarios.Text = "Funcionários";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(703, 180);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(95, 20);
            this.txtConfirmarSenha.TabIndex = 33;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(580, 183);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(117, 13);
            this.lblConfirmarSenha.TabIndex = 32;
            this.lblConfirmarSenha.Text = "Confirmar Nova Senha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAdmin);
            this.groupBox1.Controls.Add(this.rbSuporte);
            this.groupBox1.Controls.Add(this.rbGerencia);
            this.groupBox1.Controls.Add(this.rbMarketing);
            this.groupBox1.Location = new System.Drawing.Point(416, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 53);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Permissão:";
            // 
            // rbSuporte
            // 
            this.rbSuporte.AutoSize = true;
            this.rbSuporte.Location = new System.Drawing.Point(30, 19);
            this.rbSuporte.Name = "rbSuporte";
            this.rbSuporte.Size = new System.Drawing.Size(62, 17);
            this.rbSuporte.TabIndex = 18;
            this.rbSuporte.TabStop = true;
            this.rbSuporte.Text = "Suporte";
            this.rbSuporte.UseVisualStyleBackColor = true;
            // 
            // rbGerencia
            // 
            this.rbGerencia.AutoSize = true;
            this.rbGerencia.Location = new System.Drawing.Point(208, 19);
            this.rbGerencia.Name = "rbGerencia";
            this.rbGerencia.Size = new System.Drawing.Size(68, 17);
            this.rbGerencia.TabIndex = 20;
            this.rbGerencia.TabStop = true;
            this.rbGerencia.Text = "Gerência";
            this.rbGerencia.UseVisualStyleBackColor = true;
            // 
            // rbMarketing
            // 
            this.rbMarketing.AutoSize = true;
            this.rbMarketing.Location = new System.Drawing.Point(114, 19);
            this.rbMarketing.Name = "rbMarketing";
            this.rbMarketing.Size = new System.Drawing.Size(72, 17);
            this.rbMarketing.TabIndex = 19;
            this.rbMarketing.TabStop = true;
            this.rbMarketing.Text = "Marketing";
            this.rbMarketing.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAlterar.Location = new System.Drawing.Point(550, 293);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(113, 32);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(703, 147);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(95, 20);
            this.txtSenha.TabIndex = 29;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(465, 147);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(95, 20);
            this.txtLogin.TabIndex = 28;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(529, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 20);
            this.txtNome.TabIndex = 27;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(626, 150);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 13);
            this.lblSenha.TabIndex = 26;
            this.lblSenha.Text = "Nova Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(423, 147);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 25;
            this.lblLogin.Text = "Login:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(484, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAtivo);
            this.groupBox2.Controls.Add(this.rbInativo);
            this.groupBox2.Location = new System.Drawing.Point(448, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 53);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status do Funcionário:";
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(70, 19);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 18;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(161, 19);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 19;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(298, 19);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbAdmin.TabIndex = 21;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(465, 180);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(95, 20);
            this.txtSenhaAtual.TabIndex = 35;
            this.txtSenhaAtual.UseSystemPasswordChar = true;
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Location = new System.Drawing.Point(391, 183);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(68, 13);
            this.lblSenhaAtual.TabIndex = 34;
            this.lblSenhaAtual.Text = "Senha Atual:";
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 337);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.lblSenhaAtual);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblFuncionarios);
            this.Controls.Add(this.lstFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLista";
            this.Text = "Editar Cadastro";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFuncionarios;
        private System.Windows.Forms.ColumnHeader funcionario;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader permissao;
        private System.Windows.Forms.Label lblFuncionarios;
        private System.Windows.Forms.ColumnHeader ativo;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSuporte;
        private System.Windows.Forms.RadioButton rbGerencia;
        private System.Windows.Forms.RadioButton rbMarketing;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.ColumnHeader login;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label lblSenhaAtual;
    }
}