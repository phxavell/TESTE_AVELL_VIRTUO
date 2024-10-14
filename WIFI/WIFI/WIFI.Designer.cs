
namespace WIFI
{
    partial class WIFI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIFI));
            this.panelTesteWifi = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblConect = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.pictureBoxAvell = new System.Windows.Forms.PictureBox();
            this.panelTesteWifi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvell)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTesteWifi
            // 
            this.panelTesteWifi.BackColor = System.Drawing.Color.Transparent;
            this.panelTesteWifi.Controls.Add(this.pictureBoxStatus);
            this.panelTesteWifi.Controls.Add(this.lblStatus);
            this.panelTesteWifi.Location = new System.Drawing.Point(12, 180);
            this.panelTesteWifi.Name = "panelTesteWifi";
            this.panelTesteWifi.Size = new System.Drawing.Size(433, 135);
            this.panelTesteWifi.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(424, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(21, 24);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "3";
            // 
            // lblConect
            // 
            this.lblConect.AutoSize = true;
            this.lblConect.BackColor = System.Drawing.Color.Transparent;
            this.lblConect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConect.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblConect.Location = new System.Drawing.Point(257, 72);
            this.lblConect.Name = "lblConect";
            this.lblConect.Size = new System.Drawing.Size(155, 24);
            this.lblConect.TabIndex = 19;
            this.lblConect.Text = "CONECTANDO";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(148, 76);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(23, 31);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = ".";
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Location = new System.Drawing.Point(18, 12);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(109, 109);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStatus.TabIndex = 20;
            this.pictureBoxStatus.TabStop = false;
            // 
            // pictureBoxAvell
            // 
            this.pictureBoxAvell.Image = global::WIFI.Properties.Resources.avell_icone;
            this.pictureBoxAvell.Location = new System.Drawing.Point(12, 72);
            this.pictureBoxAvell.Name = "pictureBoxAvell";
            this.pictureBoxAvell.Size = new System.Drawing.Size(155, 96);
            this.pictureBoxAvell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvell.TabIndex = 0;
            this.pictureBoxAvell.TabStop = false;
            // 
            // WIFI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 332);
            this.Controls.Add(this.lblConect);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panelTesteWifi);
            this.Controls.Add(this.pictureBoxAvell);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WIFI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE CONEXÃO WI-FI";
            this.TopMost = true;
            this.panelTesteWifi.ResumeLayout(false);
            this.panelTesteWifi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvell;
        private System.Windows.Forms.Panel panelTesteWifi;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblConect;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}

