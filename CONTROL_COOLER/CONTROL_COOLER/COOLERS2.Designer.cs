namespace CONTROL_COOLER
{
    partial class COOLERS2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COOLERS2));
            this.picBoxAviso = new System.Windows.Forms.PictureBox();
            this.lblInfomacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAviso)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxAviso
            // 
            this.picBoxAviso.Image = global::CONTROL_COOLER.Properties.Resources.FalhaCooler;
            this.picBoxAviso.Location = new System.Drawing.Point(12, 172);
            this.picBoxAviso.Name = "picBoxAviso";
            this.picBoxAviso.Size = new System.Drawing.Size(986, 458);
            this.picBoxAviso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAviso.TabIndex = 0;
            this.picBoxAviso.TabStop = false;
            // 
            // lblInfomacao
            // 
            this.lblInfomacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfomacao.AutoSize = true;
            this.lblInfomacao.BackColor = System.Drawing.Color.Transparent;
            this.lblInfomacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblInfomacao.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfomacao.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblInfomacao.Location = new System.Drawing.Point(4, 111);
            this.lblInfomacao.Name = "lblInfomacao";
            this.lblInfomacao.Size = new System.Drawing.Size(1002, 58);
            this.lblInfomacao.TabIndex = 6;
            this.lblInfomacao.Text = "EM CASO DE FALHAS: (Exceção do ventilador) ENCAMINHAR PARA A ÁREA TÉCNICA\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "OBSERVAÇÃO:";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTime.Location = new System.Drawing.Point(966, 76);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 24);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "10";
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblModelo.Location = new System.Drawing.Point(12, 637);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(16, 24);
            this.lblModelo.TabIndex = 9;
            this.lblModelo.Text = ".";
            // 
            // COOLERS2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 670);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfomacao);
            this.Controls.Add(this.picBoxAviso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "COOLERS2";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATENÇÃO!";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAviso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAviso;
        private System.Windows.Forms.Label lblInfomacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblModelo;
    }
}