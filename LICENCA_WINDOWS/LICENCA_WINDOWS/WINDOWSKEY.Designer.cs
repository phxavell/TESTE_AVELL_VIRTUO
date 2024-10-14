namespace LICENCA_WINDOWS
{
    partial class WINDOWSKEY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WINDOWSKEY));
            this.pictureBoxWin = new System.Windows.Forms.PictureBox();
            this.pictureBoxKey = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLicencaWindows = new System.Windows.Forms.Label();
            this.lblWinVer = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWin
            // 
            this.pictureBoxWin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWin.Image = global::LICENCA_WINDOWS.Properties.Resources.windows;
            this.pictureBoxWin.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxWin.Name = "pictureBoxWin";
            this.pictureBoxWin.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxWin.TabIndex = 1;
            this.pictureBoxWin.TabStop = false;
            // 
            // pictureBoxKey
            // 
            this.pictureBoxKey.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKey.Image = global::LICENCA_WINDOWS.Properties.Resources.chaves;
            this.pictureBoxKey.Location = new System.Drawing.Point(381, 105);
            this.pictureBoxKey.Name = "pictureBoxKey";
            this.pictureBoxKey.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxKey.TabIndex = 0;
            this.pictureBoxKey.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(30, 145);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(14, 20);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = ".";
            // 
            // lblLicencaWindows
            // 
            this.lblLicencaWindows.AutoSize = true;
            this.lblLicencaWindows.BackColor = System.Drawing.Color.Transparent;
            this.lblLicencaWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencaWindows.ForeColor = System.Drawing.Color.Black;
            this.lblLicencaWindows.Location = new System.Drawing.Point(100, 33);
            this.lblLicencaWindows.Name = "lblLicencaWindows";
            this.lblLicencaWindows.Size = new System.Drawing.Size(224, 24);
            this.lblLicencaWindows.TabIndex = 16;
            this.lblLicencaWindows.Text = "LICENÇA MICROSOFT";
            // 
            // lblWinVer
            // 
            this.lblWinVer.AutoSize = true;
            this.lblWinVer.BackColor = System.Drawing.Color.Transparent;
            this.lblWinVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinVer.ForeColor = System.Drawing.Color.Black;
            this.lblWinVer.Location = new System.Drawing.Point(31, 84);
            this.lblWinVer.Name = "lblWinVer";
            this.lblWinVer.Size = new System.Drawing.Size(11, 15);
            this.lblWinVer.TabIndex = 17;
            this.lblWinVer.Text = ".";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.BackColor = System.Drawing.Color.Transparent;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.Black;
            this.lblKey.Location = new System.Drawing.Point(31, 117);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(11, 16);
            this.lblKey.TabIndex = 18;
            this.lblKey.Text = ".";
            // 
            // WINDOWSKEY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 178);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblWinVer);
            this.Controls.Add(this.lblLicencaWindows);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBoxKey);
            this.Controls.Add(this.pictureBoxWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WINDOWSKEY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSERIR CHAVE WINDOWS";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKey;
        private System.Windows.Forms.PictureBox pictureBoxWin;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLicencaWindows;
        private System.Windows.Forms.Label lblWinVer;
        private System.Windows.Forms.Label lblKey;
    }
}

