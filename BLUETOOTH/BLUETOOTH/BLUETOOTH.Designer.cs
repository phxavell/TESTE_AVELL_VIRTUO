namespace BLUETOOTH
{
    partial class BLUETOOTH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BLUETOOTH));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConect = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbDriversBluetooth = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BLUETOOTH.Properties.Resources.BluetoothLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblConect
            // 
            this.lblConect.AutoSize = true;
            this.lblConect.BackColor = System.Drawing.Color.Transparent;
            this.lblConect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConect.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblConect.Location = new System.Drawing.Point(259, 72);
            this.lblConect.Name = "lblConect";
            this.lblConect.Size = new System.Drawing.Size(155, 24);
            this.lblConect.TabIndex = 21;
            this.lblConect.Text = "CONECTANDO";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(426, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(21, 24);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "3";
            // 
            // lbDriversBluetooth
            // 
            this.lbDriversBluetooth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDriversBluetooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDriversBluetooth.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbDriversBluetooth.FormattingEnabled = true;
            this.lbDriversBluetooth.ItemHeight = 16;
            this.lbDriversBluetooth.Location = new System.Drawing.Point(142, 142);
            this.lbDriversBluetooth.Name = "lbDriversBluetooth";
            this.lbDriversBluetooth.Size = new System.Drawing.Size(297, 160);
            this.lbDriversBluetooth.TabIndex = 22;
            // 
            // BLUETOOTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 332);
            this.Controls.Add(this.lbDriversBluetooth);
            this.Controls.Add(this.lblConect);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BLUETOOTH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE FUNCIONAMENTO BLUETOOTH";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConect;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ListBox lbDriversBluetooth;
    }
}

