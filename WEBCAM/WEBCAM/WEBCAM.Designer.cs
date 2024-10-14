
namespace WEBCAM
{
    partial class WEBCAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WEBCAM));
            this.lblConfirme = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBoxRecFace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecFace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblConfirme.Location = new System.Drawing.Point(66, 274);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(221, 24);
            this.lblConfirme.TabIndex = 15;
            this.lblConfirme.Text = "TESTES DE WEBCAM";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(368, 274);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(21, 24);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "3";
            // 
            // pictureBoxRecFace
            // 
            this.pictureBoxRecFace.Image = global::WEBCAM.Properties.Resources.reconhecimentoFacial;
            this.pictureBoxRecFace.Location = new System.Drawing.Point(70, 82);
            this.pictureBoxRecFace.Name = "pictureBoxRecFace";
            this.pictureBoxRecFace.Size = new System.Drawing.Size(319, 173);
            this.pictureBoxRecFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRecFace.TabIndex = 0;
            this.pictureBoxRecFace.TabStop = false;
            // 
            // WEBCAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 345);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblConfirme);
            this.Controls.Add(this.pictureBoxRecFace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WEBCAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTES WEBCAM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRecFace;
        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.Label lblTime;
    }
}