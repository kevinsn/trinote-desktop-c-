namespace TriNote
{
    partial class FrmChat
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
            this.lstFilaEspera = new System.Windows.Forms.ListView();
            this.usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.solicitacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.motivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtRecebe = new System.Windows.Forms.RichTextBox();
            this.txtEnvia = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lstEmAtendimento = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstFilaEspera
            // 
            this.lstFilaEspera.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usuario,
            this.id,
            this.solicitacao,
            this.motivo});
            this.lstFilaEspera.FullRowSelect = true;
            this.lstFilaEspera.GridLines = true;
            this.lstFilaEspera.Location = new System.Drawing.Point(12, 41);
            this.lstFilaEspera.Name = "lstFilaEspera";
            this.lstFilaEspera.Size = new System.Drawing.Size(249, 415);
            this.lstFilaEspera.TabIndex = 4;
            this.lstFilaEspera.UseCompatibleStateImageBehavior = false;
            this.lstFilaEspera.View = System.Windows.Forms.View.Details;
            this.lstFilaEspera.DoubleClick += new System.EventHandler(this.lstFilaEspera_DoubleClick);
            // 
            // usuario
            // 
            this.usuario.Text = "Usuário";
            this.usuario.Width = 72;
            // 
            // id
            // 
            this.id.Text = "Código";
            this.id.Width = 48;
            // 
            // solicitacao
            // 
            this.solicitacao.Text = "Nº Chat";
            this.solicitacao.Width = 50;
            // 
            // motivo
            // 
            this.motivo.Text = "Motivo";
            this.motivo.Width = 75;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(7, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Fila de Espera";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRecebe
            // 
            this.txtRecebe.Location = new System.Drawing.Point(267, 98);
            this.txtRecebe.Name = "txtRecebe";
            this.txtRecebe.ReadOnly = true;
            this.txtRecebe.Size = new System.Drawing.Size(547, 289);
            this.txtRecebe.TabIndex = 6;
            this.txtRecebe.Text = "";
            // 
            // txtEnvia
            // 
            this.txtEnvia.Location = new System.Drawing.Point(267, 393);
            this.txtEnvia.Multiline = true;
            this.txtEnvia.Name = "txtEnvia";
            this.txtEnvia.Size = new System.Drawing.Size(479, 63);
            this.txtEnvia.TabIndex = 8;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(752, 393);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(62, 63);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lstEmAtendimento
            // 
            this.lstEmAtendimento.Location = new System.Drawing.Point(267, 25);
            this.lstEmAtendimento.Name = "lstEmAtendimento";
            this.lstEmAtendimento.Size = new System.Drawing.Size(547, 67);
            this.lstEmAtendimento.TabIndex = 10;
            this.lstEmAtendimento.UseCompatibleStateImageBehavior = false;
            this.lstEmAtendimento.Click += new System.EventHandler(this.lstEmAtendimento_Click);
            this.lstEmAtendimento.DoubleClick += new System.EventHandler(this.lstEmAtendimento_DoubleClick);
            // 
            // FrmChat
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(826, 462);
            this.Controls.Add(this.lstEmAtendimento);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEnvia);
            this.Controls.Add(this.txtRecebe);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstFilaEspera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmChat";
            this.Text = "Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmChat_FormClosed);
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFilaEspera;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RichTextBox txtRecebe;
        private System.Windows.Forms.TextBox txtEnvia;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListView lstEmAtendimento;
        private System.Windows.Forms.ColumnHeader usuario;
        private System.Windows.Forms.ColumnHeader solicitacao;
        private System.Windows.Forms.ColumnHeader motivo;
    }
}