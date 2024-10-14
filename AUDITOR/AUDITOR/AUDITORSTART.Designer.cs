
namespace AUDITOR
{
    partial class AUDITORSTART
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AUDITORSTART));
            this.panelOK = new System.Windows.Forms.Panel();
            this.lblTesteLcd = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBoxOK = new System.Windows.Forms.PictureBox();
            this.panelOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOK
            // 
            this.panelOK.BackColor = System.Drawing.Color.Gainsboro;
            this.panelOK.Controls.Add(this.lblTesteLcd);
            this.panelOK.Controls.Add(this.lblTime);
            this.panelOK.Controls.Add(this.pictureBoxOK);
            this.panelOK.Location = new System.Drawing.Point(-1, 99);
            this.panelOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelOK.Name = "panelOK";
            this.panelOK.Size = new System.Drawing.Size(687, 635);
            this.panelOK.TabIndex = 19;
            // 
            // lblTesteLcd
            // 
            this.lblTesteLcd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblTesteLcd.AutoSize = true;
            this.lblTesteLcd.BackColor = System.Drawing.Color.Transparent;
            this.lblTesteLcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesteLcd.ForeColor = System.Drawing.Color.Black;
            this.lblTesteLcd.Location = new System.Drawing.Point(48, 509);
            this.lblTesteLcd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTesteLcd.Name = "lblTesteLcd";
            this.lblTesteLcd.Size = new System.Drawing.Size(483, 33);
            this.lblTesteLcd.TabIndex = 17;
            this.lblTesteLcd.Text = "AUDITOR DE CONFIGURAÇÕES";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(609, 509);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 33);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "5";
            // 
            // pictureBoxOK
            // 
            this.pictureBoxOK.Image = global::AUDITOR.Properties.Resources.auditImg21;
            this.pictureBoxOK.Location = new System.Drawing.Point(20, 48);
            this.pictureBoxOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxOK.Name = "pictureBoxOK";
            this.pictureBoxOK.Size = new System.Drawing.Size(650, 369);
            this.pictureBoxOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOK.TabIndex = 13;
            this.pictureBoxOK.TabStop = false;
            // 
            // AUDITORSTART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 734);
            this.Controls.Add(this.panelOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AUDITORSTART";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTIDOR DE EQUIPAMENTOS";
            this.panelOK.ResumeLayout(false);
            this.panelOK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOK;
        private System.Windows.Forms.Label lblTesteLcd;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBoxOK;
    }
}