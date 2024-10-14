
namespace USB
{
    partial class QUANTIDADEARQUIVOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QUANTIDADEARQUIVOS));
            this.panelOK = new System.Windows.Forms.Panel();
            this.lblQuantidadeTestes = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBoxOK = new System.Windows.Forms.PictureBox();
            this.panelOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOK
            // 
            this.panelOK.BackColor = System.Drawing.Color.Teal;
            this.panelOK.Controls.Add(this.lblQuantidadeTestes);
            this.panelOK.Controls.Add(this.lblTime);
            this.panelOK.Controls.Add(this.pictureBoxOK);
            this.panelOK.Location = new System.Drawing.Point(-1, 64);
            this.panelOK.Name = "panelOK";
            this.panelOK.Size = new System.Drawing.Size(458, 413);
            this.panelOK.TabIndex = 17;
            this.panelOK.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOK_Paint);
            // 
            // lblQuantidadeTestes
            // 
            this.lblQuantidadeTestes.AutoSize = true;
            this.lblQuantidadeTestes.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidadeTestes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeTestes.ForeColor = System.Drawing.Color.Black;
            this.lblQuantidadeTestes.Location = new System.Drawing.Point(61, 290);
            this.lblQuantidadeTestes.Name = "lblQuantidadeTestes";
            this.lblQuantidadeTestes.Size = new System.Drawing.Size(317, 24);
            this.lblQuantidadeTestes.TabIndex = 15;
            this.lblQuantidadeTestes.Text = "QUANTIDADE TOTAL TESTADA";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(403, 290);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(21, 24);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "3";
            // 
            // pictureBoxOK
            // 
            this.pictureBoxOK.Image = global::USB.Properties.Resources.pendrive;
            this.pictureBoxOK.Location = new System.Drawing.Point(110, 40);
            this.pictureBoxOK.Name = "pictureBoxOK";
            this.pictureBoxOK.Size = new System.Drawing.Size(244, 191);
            this.pictureBoxOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOK.TabIndex = 13;
            this.pictureBoxOK.TabStop = false;
            // 
            // QUANTIDADEARQUIVOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 477);
            this.Controls.Add(this.panelOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QUANTIDADEARQUIVOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOTAL DE TESTES REALIZADOS";
            this.TopMost = true;
            this.panelOK.ResumeLayout(false);
            this.panelOK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOK;
        private System.Windows.Forms.PictureBox pictureBoxOK;
        private System.Windows.Forms.Label lblQuantidadeTestes;
        private System.Windows.Forms.Label lblTime;
    }
}