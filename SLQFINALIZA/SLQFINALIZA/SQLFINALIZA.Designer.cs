
namespace SLQFINALIZA
{
    partial class SQLFINALIZA
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLFINALIZA));
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBoxAvell = new System.Windows.Forms.PictureBox();
            this.listBoxTeste = new System.Windows.Forms.ListBox();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvell)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 196);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(14, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = ".";
            // 
            // pictureBoxAvell
            // 
            this.pictureBoxAvell.Image = global::SLQFINALIZA.Properties.Resources.avell_icone;
            this.pictureBoxAvell.Location = new System.Drawing.Point(12, 73);
            this.pictureBoxAvell.Name = "pictureBoxAvell";
            this.pictureBoxAvell.Size = new System.Drawing.Size(155, 96);
            this.pictureBoxAvell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvell.TabIndex = 1;
            this.pictureBoxAvell.TabStop = false;
            // 
            // listBoxTeste
            // 
            this.listBoxTeste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTeste.FormattingEnabled = true;
            this.listBoxTeste.Location = new System.Drawing.Point(12, 230);
            this.listBoxTeste.Name = "listBoxTeste";
            this.listBoxTeste.Size = new System.Drawing.Size(419, 429);
            this.listBoxTeste.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(400, 73);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 24);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "10";
            // 
            // SQLFINALIZA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 680);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.listBoxTeste);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBoxAvell);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SQLFINALIZA";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FINALIZA TESTES";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvell;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox listBoxTeste;
        private System.Windows.Forms.Label lblTime;
    }
}

