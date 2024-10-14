using System.Windows.Forms;

namespace AVELLCUSTOM1
{
    partial class ENVIAREPARO: Form
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblFalha1 = new System.Windows.Forms.Label();
            this.panelFalha = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirebase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelFalha.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::AVELLCUSTOM1.Properties.Resources.avell_icone;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 71);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(189, 109);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblFalha1
            // 
            this.lblFalha1.AutoSize = true;
            this.lblFalha1.BackColor = System.Drawing.Color.Transparent;
            this.lblFalha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalha1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFalha1.Location = new System.Drawing.Point(163, 75);
            this.lblFalha1.Name = "lblFalha1";
            this.lblFalha1.Size = new System.Drawing.Size(474, 29);
            this.lblFalha1.TabIndex = 18;
            this.lblFalha1.Text = "ENVIE ESTA MÁQUINA PARA REPARO";
            this.lblFalha1.Click += new System.EventHandler(this.lblFalha1_Click);
            // 
            // panelFalha
            // 
            this.panelFalha.BackColor = System.Drawing.Color.DarkRed;
            this.panelFalha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFalha.Controls.Add(this.label1);
            this.panelFalha.Controls.Add(this.lblFalha1);
            this.panelFalha.Location = new System.Drawing.Point(12, 186);
            this.panelFalha.Name = "panelFalha";
            this.panelFalha.Size = new System.Drawing.Size(656, 281);
            this.panelFalha.TabIndex = 19;
            this.panelFalha.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFalha_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(127, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "VERIFIQUE A DATA DA PASTA OEM DO CUSTOM";
            // 
            // lblFirebase
            // 
            this.lblFirebase.AutoSize = true;
            this.lblFirebase.BackColor = System.Drawing.Color.Transparent;
            this.lblFirebase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirebase.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFirebase.Location = new System.Drawing.Point(207, 71);
            this.lblFirebase.Name = "lblFirebase";
            this.lblFirebase.Size = new System.Drawing.Size(14, 20);
            this.lblFirebase.TabIndex = 38;
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
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ENVIAREPARO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelFalha.ResumeLayout(false);
            this.panelFalha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblFalha1;
        private System.Windows.Forms.Panel panelFalha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirebase;

        private void ENVIAREPARO_Load(object sender, System.EventArgs e)
        {

        }

        private void lblFalha1_Click(object sender, System.EventArgs e)
        {

        }

        private void panelFalha_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}