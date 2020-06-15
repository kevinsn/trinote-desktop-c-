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
            this.btnNao = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.lblValidar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.picAnuncio = new System.Windows.Forms.PictureBox();
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
            this.dataTermino});
            this.lstAnuncios.FullRowSelect = true;
            this.lstAnuncios.GridLines = true;
            this.lstAnuncios.Location = new System.Drawing.Point(12, 12);
            this.lstAnuncios.Name = "lstAnuncios";
            this.lstAnuncios.Size = new System.Drawing.Size(589, 133);
            this.lstAnuncios.TabIndex = 5;
            this.lstAnuncios.UseCompatibleStateImageBehavior = false;
            this.lstAnuncios.View = System.Windows.Forms.View.Details;
            this.lstAnuncios.DoubleClick += new System.EventHandler(this.lstAnuncios_DoubleClick);
            // 
            // nome
            // 
            this.nome.Text = "Nome do Anunciante";
            this.nome.Width = 137;
            // 
            // id
            // 
            this.id.Text = "Número do Anúncio";
            this.id.Width = 126;
            // 
            // valor
            // 
            this.valor.Text = "Valor";
            this.valor.Width = 99;
            // 
            // validacao
            // 
            this.validacao.Text = "Validado?";
            this.validacao.Width = 103;
            // 
            // dataTermino
            // 
            this.dataTermino.Text = "Data Término";
            this.dataTermino.Width = 167;
            // 
            // btnNao
            // 
            this.btnNao.Location = new System.Drawing.Point(487, 366);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(75, 23);
            this.btnNao.TabIndex = 17;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(393, 366);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(75, 23);
            this.btnSim.TabIndex = 16;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // lblValidar
            // 
            this.lblValidar.AutoSize = true;
            this.lblValidar.Location = new System.Drawing.Point(390, 346);
            this.lblValidar.Name = "lblValidar";
            this.lblValidar.Size = new System.Drawing.Size(86, 13);
            this.lblValidar.TabIndex = 15;
            this.lblValidar.Text = "Validar anúncio?";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(89, 173);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(41, 13);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Título: ";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(390, 175);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 23;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(393, 199);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(169, 124);
            this.txtDescricao.TabIndex = 24;
            // 
            // picAnuncio
            // 
            this.picAnuncio.Location = new System.Drawing.Point(30, 199);
            this.picAnuncio.Name = "picAnuncio";
            this.picAnuncio.Size = new System.Drawing.Size(324, 190);
            this.picAnuncio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnuncio.TabIndex = 6;
            this.picAnuncio.TabStop = false;
            // 
            // FrmValida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 428);
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
    }
}