namespace TriNote
{
    partial class FrmValida
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
            this.lstAnuncios = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.validacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataTermino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNao = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.lblValidar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.picAnuncio = new System.Windows.Forms.PictureBox();
            this.lblCausa = new System.Windows.Forms.Label();
            this.txtCausa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAnuncio)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAnuncios
            // 
            this.lstAnuncios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.id,
            this.valor,
            this.validacao,
            this.dataTermino,
            this.nomeFuncionario});
            this.lstAnuncios.FullRowSelect = true;
            this.lstAnuncios.GridLines = true;
            this.lstAnuncios.Location = new System.Drawing.Point(12, 12);
            this.lstAnuncios.Name = "lstAnuncios";
            this.lstAnuncios.Size = new System.Drawing.Size(812, 133);
            this.lstAnuncios.TabIndex = 4;
            this.lstAnuncios.UseCompatibleStateImageBehavior = false;
            this.lstAnuncios.View = System.Windows.Forms.View.Details;
            this.lstAnuncios.DoubleClick += new System.EventHandler(this.lstAnuncios_DoubleClick);
            // 
            // nome
            // 
            this.nome.Text = "Nome do Anunciante";
            this.nome.Width = 214;
            // 
            // id
            // 
            this.id.Text = "Número do Anúncio";
            this.id.Width = 114;
            // 
            // valor
            // 
            this.valor.Text = "Valor do Anúncio";
            this.valor.Width = 110;
            // 
            // validacao
            // 
            this.validacao.Text = "Situação";
            this.validacao.Width = 104;
            // 
            // dataTermino
            // 
            this.dataTermino.Text = "Data Término";
            this.dataTermino.Width = 132;
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.Text = "Funcionário que Validou";
            this.nomeFuncionario.Width = 134;
            // 
            // btnNao
            // 
            this.btnNao.BackColor = System.Drawing.SystemColors.Control;
            this.btnNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnNao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNao.Location = new System.Drawing.Point(205, 458);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(120, 32);
            this.btnNao.TabIndex = 17;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = false;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.SystemColors.Control;
            this.btnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSim.Location = new System.Drawing.Point(45, 458);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(120, 32);
            this.btnSim.TabIndex = 16;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // lblValidar
            // 
            this.lblValidar.AutoSize = true;
            this.lblValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblValidar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblValidar.Location = new System.Drawing.Point(41, 413);
            this.lblValidar.Name = "lblValidar";
            this.lblValidar.Size = new System.Drawing.Size(151, 24);
            this.lblValidar.TabIndex = 15;
            this.lblValidar.Text = "Validar anúncio?";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(26, 162);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(66, 24);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Título: ";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDescricao.Location = new System.Drawing.Point(379, 162);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(99, 24);
            this.lblDescricao.TabIndex = 23;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(383, 200);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(428, 98);
            this.txtDescricao.TabIndex = 24;
            // 
            // picAnuncio
            // 
            this.picAnuncio.Location = new System.Drawing.Point(30, 200);
            this.picAnuncio.Name = "picAnuncio";
            this.picAnuncio.Size = new System.Drawing.Size(324, 190);
            this.picAnuncio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnuncio.TabIndex = 6;
            this.picAnuncio.TabStop = false;
            // 
            // lblCausa
            // 
            this.lblCausa.AutoSize = true;
            this.lblCausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCausa.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCausa.Location = new System.Drawing.Point(379, 319);
            this.lblCausa.Name = "lblCausa";
            this.lblCausa.Size = new System.Drawing.Size(117, 24);
            this.lblCausa.TabIndex = 25;
            this.lblCausa.Text = "Observação:";
            // 
            // txtCausa
            // 
            this.txtCausa.Location = new System.Drawing.Point(383, 362);
            this.txtCausa.Multiline = true;
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(428, 108);
            this.txtCausa.TabIndex = 26;
            // 
            // FrmValida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(836, 516);
            this.Controls.Add(this.txtCausa);
            this.Controls.Add(this.lblCausa);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.lblValidar);
            this.Controls.Add(this.picAnuncio);
            this.Controls.Add(this.lstAnuncios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmValida";
            this.Text = "Validar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmValida_FormClosed);
            this.Load += new System.EventHandler(this.FrmValida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnuncio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstAnuncios;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.ColumnHeader validacao;
        private System.Windows.Forms.ColumnHeader dataTermino;
        private System.Windows.Forms.PictureBox picAnuncio;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Label lblValidar;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblCausa;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.ColumnHeader nomeFuncionario;
    }
}