
namespace TECLADO
{
    partial class TESTETECLADO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TESTETECLADO));
            this.lblConfirme = new System.Windows.Forms.Label();
            this.pictureBoxTeclado = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeclado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblConfirme.Location = new System.Drawing.Point(22, 316);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(257, 24);
            this.lblConfirme.TabIndex = 11;
            this.lblConfirme.Text = "INICIAR TESTE TECLADO";
            this.lblConfirme.Click += new System.EventHandler(this.lblConfirme_Click);
            // 
            // pictureBoxTeclado
            // 
            this.pictureBoxTeclado.Image = global::TECLADO.Properties.Resources.TecladoLight;
            this.pictureBoxTeclado.Location = new System.Drawing.Point(12, 78);
            this.pictureBoxTeclado.Name = "pictureBoxTeclado";
            this.pictureBoxTeclado.Size = new System.Drawing.Size(436, 221);
            this.pictureBoxTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTeclado.TabIndex = 7;
            this.pictureBoxTeclado.TabStop = false;
            this.pictureBoxTeclado.Click += new System.EventHandler(this.pictureBoxTeclado_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(415, 316);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(21, 24);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "3";
            // 
            // TESTETECLADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 360);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblConfirme);
            this.Controls.Add(this.pictureBoxTeclado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TESTETECLADO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE DE TECLADOS";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeclado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.PictureBox pictureBoxTeclado;
        private System.Windows.Forms.Label lblTime;
    }
}