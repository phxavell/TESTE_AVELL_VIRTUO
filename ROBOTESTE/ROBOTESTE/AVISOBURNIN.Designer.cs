namespace ROBOTESTE
{
    partial class AVISOBURNIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVISOBURNIN));
            this.panelOK = new System.Windows.Forms.Panel();
            this.lblInforme2 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblInforme1 = new System.Windows.Forms.Label();
            this.pictureBoxOK = new System.Windows.Forms.PictureBox();
            this.panelOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOK
            // 
            this.panelOK.BackColor = System.Drawing.Color.DarkOrange;
            this.panelOK.Controls.Add(this.lblInforme2);
            this.panelOK.Controls.Add(this.btnFechar);
            this.panelOK.Controls.Add(this.pictureBoxOK);
            this.panelOK.Controls.Add(this.lblInforme1);
            this.panelOK.Location = new System.Drawing.Point(-1, 64);
            this.panelOK.Name = "panelOK";
            this.panelOK.Size = new System.Drawing.Size(458, 413);
            this.panelOK.TabIndex = 21;
            // 
            // lblInforme2
            // 
            this.lblInforme2.AutoSize = true;
            this.lblInforme2.BackColor = System.Drawing.Color.Transparent;
            this.lblInforme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme2.ForeColor = System.Drawing.Color.Black;
            this.lblInforme2.Location = new System.Drawing.Point(35, 295);
            this.lblInforme2.Name = "lblInforme2";
            this.lblInforme2.Size = new System.Drawing.Size(381, 24);
            this.lblInforme2.TabIndex = 15;
            this.lblInforme2.Text = "RETORNE ESTA MÁQUINA PARA IMG.";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(156, 356);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(150, 36);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblInforme1
            // 
            this.lblInforme1.AutoSize = true;
            this.lblInforme1.BackColor = System.Drawing.Color.Transparent;
            this.lblInforme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme1.ForeColor = System.Drawing.Color.Black;
            this.lblInforme1.Location = new System.Drawing.Point(28, 265);
            this.lblInforme1.Name = "lblInforme1";
            this.lblInforme1.Size = new System.Drawing.Size(393, 24);
            this.lblInforme1.TabIndex = 12;
            this.lblInforme1.Text = "PASTA DE BURNIN NÃO ENCONTRADA";
            // 
            // pictureBoxOK
            // 
            this.pictureBoxOK.Image = global::ROBOTESTE.Properties.Resources.burnin;
            this.pictureBoxOK.Location = new System.Drawing.Point(84, 44);
            this.pictureBoxOK.Name = "pictureBoxOK";
            this.pictureBoxOK.Size = new System.Drawing.Size(291, 203);
            this.pictureBoxOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOK.TabIndex = 13;
            this.pictureBoxOK.TabStop = false;
            // 
            // AVISOBURNIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 477);
            this.Controls.Add(this.panelOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AVISOBURNIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVISO BURNIN!";
            this.TopMost = true;
            this.panelOK.ResumeLayout(false);
            this.panelOK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOK;
        private System.Windows.Forms.Label lblInforme2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBoxOK;
        private System.Windows.Forms.Label lblInforme1;
    }
}