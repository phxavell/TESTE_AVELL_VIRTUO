
namespace USB
{
    partial class UNIDADEOK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UNIDADEOK));
            this.panelOK = new System.Windows.Forms.Panel();
            this.listbArquivos2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfirme3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBoxOK = new System.Windows.Forms.PictureBox();
            this.lblConfirme = new System.Windows.Forms.Label();
            this.panelOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOK
            // 
            this.panelOK.BackColor = System.Drawing.Color.ForestGreen;
            this.panelOK.Controls.Add(this.listbArquivos2);
            this.panelOK.Controls.Add(this.label1);
            this.panelOK.Controls.Add(this.lblConfirme3);
            this.panelOK.Controls.Add(this.btnOk);
            this.panelOK.Controls.Add(this.pictureBoxOK);
            this.panelOK.Controls.Add(this.lblConfirme);
            this.panelOK.Location = new System.Drawing.Point(-1, 64);
            this.panelOK.Name = "panelOK";
            this.panelOK.Size = new System.Drawing.Size(458, 596);
            this.panelOK.TabIndex = 17;
            this.panelOK.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOK_Paint);
            // 
            // listbArquivos2
            // 
            this.listbArquivos2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.listbArquivos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbArquivos2.FormattingEnabled = true;
            this.listbArquivos2.ItemHeight = 18;
            this.listbArquivos2.Location = new System.Drawing.Point(32, 241);
            this.listbArquivos2.Name = "listbArquivos2";
            this.listbArquivos2.Size = new System.Drawing.Size(392, 202);
            this.listbArquivos2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "ARQUIVOS TESTE COPIADOS:";
            // 
            // lblConfirme3
            // 
            this.lblConfirme3.AutoSize = true;
            this.lblConfirme3.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirme3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme3.ForeColor = System.Drawing.Color.White;
            this.lblConfirme3.Location = new System.Drawing.Point(131, 493);
            this.lblConfirme3.Name = "lblConfirme3";
            this.lblConfirme3.Size = new System.Drawing.Size(168, 24);
            this.lblConfirme3.TabIndex = 17;
            this.lblConfirme3.Text = "PRESSIONE OK.";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(140, 532);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 36);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "OK!";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBoxOK
            // 
            this.pictureBoxOK.Image = global::USB.Properties.Resources.pendrive;
            this.pictureBoxOK.Location = new System.Drawing.Point(124, 16);
            this.pictureBoxOK.Name = "pictureBoxOK";
            this.pictureBoxOK.Size = new System.Drawing.Size(218, 194);
            this.pictureBoxOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOK.TabIndex = 13;
            this.pictureBoxOK.TabStop = false;
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme.ForeColor = System.Drawing.Color.White;
            this.lblConfirme.Location = new System.Drawing.Point(25, 454);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(403, 24);
            this.lblConfirme.TabIndex = 12;
            this.lblConfirme.Text = "VERIFIQUE LISTA DE ARQUIVOS ACIMA.";
            // 
            // UNIDADEOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 659);
            this.Controls.Add(this.panelOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UNIDADEOK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIDADE DETECTADA!";
            this.TopMost = true;
            this.panelOK.ResumeLayout(false);
            this.panelOK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOK;
        private System.Windows.Forms.PictureBox pictureBoxOK;
        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblConfirme3;
        private System.Windows.Forms.ListBox listbArquivos2;
        private System.Windows.Forms.Label label1;
    }
}