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
            this.rbAdmin = new System.Windows.Forms.RadioButton();
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
            this.lstFuncionarios.Size = new System.Drawing.Size(365, 315);
            this.lstFuncionarios.TabIndex = 15;
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
            this.txtConfirmarSenha.Location = new System.Drawing.Point(972, 208);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(95, 20);
            this.txtConfirmarSenha.TabIndex = 10;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(830, 206);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(133, 20);
            this.lblConfirmarSenha.TabIndex = 32;
            this.lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAdmin);
            this.groupBox1.Controls.Add(this.rbSuporte);
            this.groupBox1.Controls.Add(this.rbGerencia);
            this.groupBox1.Controls.Add(this.rbMarketing);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(404, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Permissão:";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.Location = new System.Drawing.Point(333, 30);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(64, 20);
            this.rbAdmin.TabIndex = 6;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbSuporte
            // 
            this.rbSuporte.AutoSize = true;
            this.rbSuporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuporte.Location = new System.Drawing.Point(7, 30);
            this.rbSuporte.Name = "rbSuporte";
            this.rbSuporte.Size = new System.Drawing.Size(73, 20);
            this.rbSuporte.TabIndex = 3;
            this.rbSuporte.TabStop = true;
            this.rbSuporte.Text = "Suporte";
            this.rbSuporte.UseVisualStyleBackColor = true;
            // 
            // rbGerencia
            // 
            this.rbGerencia.AutoSize = true;
            this.rbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGerencia.Location = new System.Drawing.Point(223, 30);
            this.rbGerencia.Name = "rbGerencia";
            this.rbGerencia.Size = new System.Drawing.Size(81, 20);
            this.rbGerencia.TabIndex = 5;
            this.rbGerencia.TabStop = true;
            this.rbGerencia.Text = "Gerência";
            this.rbGerencia.UseVisualStyleBackColor = true;
            // 
            // rbMarketing
            // 
            this.rbMarketing.AutoSize = true;
            this.rbMarketing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMarketing.Location = new System.Drawing.Point(109, 30);
            this.rbMarketing.Name = "rbMarketing";
            this.rbMarketing.Size = new System.Drawing.Size(85, 20);
            this.rbMarketing.TabIndex = 4;
            this.rbMarketing.TabStop = true;
            this.rbMarketing.Text = "Marketing";
            this.rbMarketing.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAlterar.Location = new System.Drawing.Point(542, 318);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(113, 46);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(972, 175);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(95, 20);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(542, 183);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(128, 20);
            this.txtLogin.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(488, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(866, 173);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(100, 20);
            this.lblSenha.TabIndex = 26;
            this.lblSenha.Text = "Nova Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(484, 183);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(52, 20);
            this.lblLogin.TabIndex = 25;
            this.lblLogin.Text = "Login:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(427, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAtivo);
            this.groupBox2.Controls.Add(this.rbInativo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(475, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 63);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status do Funcionário:";
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtivo.Location = new System.Drawing.Point(59, 29);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(56, 20);
            this.rbAtivo.TabIndex = 11;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInativo.Location = new System.Drawing.Point(150, 29);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(65, 20);
            this.rbInativo.TabIndex = 12;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(972, 139);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(128, 20);
            this.txtSenhaAtual.TabIndex = 8;
            this.txtSenhaAtual.UseSystemPasswordChar = true;
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtual.Location = new System.Drawing.Point(865, 139);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(101, 20);
            this.lblSenhaAtual.TabIndex = 34;
            this.lblSenhaAtual.Text = "Senha Atual:";
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 373);
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