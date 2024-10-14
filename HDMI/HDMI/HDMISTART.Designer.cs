
namespace HDMI
{
    partial class HDMISTART
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HDMISTART));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblConfirme = new System.Windows.Forms.Label();
            this.pictureBoxEstender = new System.Windows.Forms.PictureBox();
            this.pictureBoxConectar = new System.Windows.Forms.PictureBox();
            this.lblFnF3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConectar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(292, 548);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 24);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "15";
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblConfirme.Location = new System.Drawing.Point(43, 548);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(181, 24);
            this.lblConfirme.TabIndex = 20;
            this.lblConfirme.Text = "TESTES DE HDMI";
            // 
            // pictureBoxEstender
            // 
            this.pictureBoxEstender.Image = global::HDMI.Properties.Resources.selecioneEstender;
            this.pictureBoxEstender.Location = new System.Drawing.Point(43, 203);
            this.pictureBoxEstender.Name = "pictureBoxEstender";
            this.pictureBoxEstender.Size = new System.Drawing.Size(281, 329);
            this.pictureBoxEstender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEstender.TabIndex = 22;
            this.pictureBoxEstender.TabStop = false;
            // 
            // pictureBoxConectar
            // 
            this.pictureBoxConectar.Image = global::HDMI.Properties.Resources.conectHDMI;
            this.pictureBoxConectar.Location = new System.Drawing.Point(43, 94);
            this.pictureBoxConectar.Name = "pictureBoxConectar";
            this.pictureBoxConectar.Size = new System.Drawing.Size(281, 103);
            this.pictureBoxConectar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConectar.TabIndex = 19;
            this.pictureBoxConectar.TabStop = false;
            // 
            // lblFnF3
            // 
            this.lblFnF3.AutoSize = true;
            this.lblFnF3.BackColor = System.Drawing.Color.Transparent;
            this.lblFnF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFnF3.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFnF3.Location = new System.Drawing.Point(249, 377);
            this.lblFnF3.Name = "lblFnF3";
            this.lblFnF3.Size = new System.Drawing.Size(86, 24);
            this.lblFnF3.TabIndex = 23;
            this.lblFnF3.Text = "FN + F3";
            // 
            // HDMISTART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 610);
            this.Controls.Add(this.lblFnF3);
            this.Controls.Add(this.pictureBoxEstender);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblConfirme);
            this.Controls.Add(this.pictureBoxConectar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HDMISTART";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE HDMI";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConectar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.PictureBox pictureBoxConectar;
        private System.Windows.Forms.PictureBox pictureBoxEstender;
        private System.Windows.Forms.Label lblFnF3;
    }
}