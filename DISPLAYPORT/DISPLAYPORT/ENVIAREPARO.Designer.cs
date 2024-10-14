namespace DISPLAYPORT
{
    partial class ENVIAREPARO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ENVIAREPARO));
            this.panelFalha = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFalha = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblFirebase = new System.Windows.Forms.Label();
            this.panelFalha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFalha
            // 
            this.panelFalha.BackColor = System.Drawing.Color.White;
            this.panelFalha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFalha.Controls.Add(this.label1);
            this.panelFalha.Controls.Add(this.lblFalha);
            this.panelFalha.Location = new System.Drawing.Point(12, 189);
            this.panelFalha.Name = "panelFalha";
            this.panelFalha.Size = new System.Drawing.Size(656, 281);
            this.panelFalha.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(132, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "TESTE DE HDMI FALHOU.";
            // 
            // lblFalha
            // 
            this.lblFalha.AutoSize = true;
            this.lblFalha.BackColor = System.Drawing.Color.Transparent;
            this.lblFalha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFalha.Location = new System.Drawing.Point(34, 87);
            this.lblFalha.Name = "lblFalha";
            this.lblFalha.Size = new System.Drawing.Size(582, 33);
            this.lblFalha.TabIndex = 18;
            this.lblFalha.Text = "ENVIE ESTA MÁQUINA PARA REPARO!";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 74);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(189, 109);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 31;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblFirebase
            // 
            this.lblFirebase.AutoSize = true;
            this.lblFirebase.BackColor = System.Drawing.Color.Transparent;
            this.lblFirebase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirebase.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFirebase.Location = new System.Drawing.Point(207, 74);
            this.lblFirebase.Name = "lblFirebase";
            this.lblFirebase.Size = new System.Drawing.Size(14, 20);
            this.lblFirebase.TabIndex = 41;
            this.lblFirebase.Text = ".";
            // 
            // ENVIAREPARO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 480);
            this.Controls.Add(this.lblFirebase);
            this.Controls.Add(this.panelFalha);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ENVIAREPARO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENVIAR PARA REPARO";
            this.panelFalha.ResumeLayout(false);
            this.panelFalha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFalha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFalha;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblFirebase;
    }
}