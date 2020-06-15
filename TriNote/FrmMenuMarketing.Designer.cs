namespace TriNote
{
    partial class FrmMenuMarketing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblRAnunciantes = new System.Windows.Forms.Label();
            this.lblAnunciantes = new System.Windows.Forms.Label();
            this.lblRAnuncios = new System.Windows.Forms.Label();
            this.lblAnuncios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnValidar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 260);
            this.panel1.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(3, 109);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(170, 80);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnValidar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValidar.Location = new System.Drawing.Point(3, 12);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(170, 80);
            this.btnValidar.TabIndex = 0;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblRAnunciantes
            // 
            this.lblRAnunciantes.AutoSize = true;
            this.lblRAnunciantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAnunciantes.Location = new System.Drawing.Point(299, 209);
            this.lblRAnunciantes.Name = "lblRAnunciantes";
            this.lblRAnunciantes.Size = new System.Drawing.Size(27, 29);
            this.lblRAnunciantes.TabIndex = 13;
            this.lblRAnunciantes.Text = "0";
            this.lblRAnunciantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnunciantes
            // 
            this.lblAnunciantes.AutoSize = true;
            this.lblAnunciantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnunciantes.Location = new System.Drawing.Point(236, 140);
            this.lblAnunciantes.Name = "lblAnunciantes";
            this.lblAnunciantes.Size = new System.Drawing.Size(153, 58);
            this.lblAnunciantes.TabIndex = 12;
            this.lblAnunciantes.Text = "Nº de \r\nAnunciantes";
            this.lblAnunciantes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRAnuncios
            // 
            this.lblRAnuncios.AutoSize = true;
            this.lblRAnuncios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAnuncios.Location = new System.Drawing.Point(503, 209);
            this.lblRAnuncios.Name = "lblRAnuncios";
            this.lblRAnuncios.Size = new System.Drawing.Size(27, 29);
            this.lblRAnuncios.TabIndex = 16;
            this.lblRAnuncios.Text = "0";
            this.lblRAnuncios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnuncios
            // 
            this.lblAnuncios.AutoSize = true;
            this.lblAnuncios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnuncios.Location = new System.Drawing.Point(457, 140);
            this.lblAnuncios.Name = "lblAnuncios";
            this.lblAnuncios.Size = new System.Drawing.Size(118, 58);
            this.lblAnuncios.TabIndex = 15;
            this.lblAnuncios.Text = "Nº de \r\nAnúncios";
            this.lblAnuncios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TriNote.Properties.Resources.anuncios;
            this.pictureBox1.Location = new System.Drawing.Point(456, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TriNote.Properties.Resources.anunciantes;
            this.pictureBox2.Location = new System.Drawing.Point(252, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMenuMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 260);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRAnuncios);
            this.Controls.Add(this.lblAnuncios);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRAnunciantes);
            this.Controls.Add(this.lblAnunciantes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMenuMarketing";
            this.Text = "Marketing";
            this.Load += new System.EventHandler(this.FrmMenuMarketing_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRAnunciantes;
        private System.Windows.Forms.Label lblAnunciantes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRAnuncios;
        private System.Windows.Forms.Label lblAnuncios;
    }
}