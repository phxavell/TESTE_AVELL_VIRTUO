namespace ROBOTESTE
{
    partial class TEMPORIZADOR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TEMPORIZADOR));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkAvancar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(210, 265);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 24);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "2700";
            // 
            // lblTimeInfo
            // 
            this.lblTimeInfo.AutoSize = true;
            this.lblTimeInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTimeInfo.Location = new System.Drawing.Point(8, 265);
            this.lblTimeInfo.Name = "lblTimeInfo";
            this.lblTimeInfo.Size = new System.Drawing.Size(196, 24);
            this.lblTimeInfo.TabIndex = 18;
            this.lblTimeInfo.Text = "TEMPO DE TESTE:";
            this.lblTimeInfo.Click += new System.EventHandler(this.lblTimeInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ROBOTESTE.Properties.Resources.burnin2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkAvancar
            // 
            this.linkAvancar.AutoSize = true;
            this.linkAvancar.BackColor = System.Drawing.Color.Transparent;
            this.linkAvancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkAvancar.Location = new System.Drawing.Point(12, 307);
            this.linkAvancar.Name = "linkAvancar";
            this.linkAvancar.Size = new System.Drawing.Size(43, 13);
            this.linkAvancar.TabIndex = 20;
            this.linkAvancar.TabStop = true;
            this.linkAvancar.Text = "Skip->>";
            this.linkAvancar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAvancar_LinkClicked);
            // 
            // TEMPORIZADOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 332);
            this.Controls.Add(this.linkAvancar);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimeInfo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TEMPORIZADOR";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TEMPORIZADOR BURNIN";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkAvancar;
    }
}