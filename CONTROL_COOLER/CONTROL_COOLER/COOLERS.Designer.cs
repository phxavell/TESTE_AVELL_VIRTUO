namespace CONTROL_COOLER
{
    partial class COOLERS
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COOLERS));
            this.picBoxInst = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblInfomacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInst)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxInst
            // 
            this.picBoxInst.Image = global::CONTROL_COOLER.Properties.Resources.AnimaControlCooler;
            this.picBoxInst.Location = new System.Drawing.Point(12, 77);
            this.picBoxInst.Name = "picBoxInst";
            this.picBoxInst.Size = new System.Drawing.Size(985, 557);
            this.picBoxInst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxInst.TabIndex = 0;
            this.picBoxInst.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTime.Location = new System.Drawing.Point(966, 637);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 24);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "45";
            // 
            // lblInfomacao
            // 
            this.lblInfomacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfomacao.AutoSize = true;
            this.lblInfomacao.BackColor = System.Drawing.Color.Transparent;
            this.lblInfomacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfomacao.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInfomacao.Location = new System.Drawing.Point(12, 641);
            this.lblInfomacao.Name = "lblInfomacao";
            this.lblInfomacao.Size = new System.Drawing.Size(813, 20);
            this.lblInfomacao.TabIndex = 5;
            this.lblInfomacao.Text = "O PROCESSO DE INSTALAÇÃO DO CUSTOM CONTROL E EXECUÇÃO ESTÁ SENDO REALIZADA";
            // 
            // COOLERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 670);
            this.Controls.Add(this.lblInfomacao);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picBoxInst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "COOLERS";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROLE DE COOLERS";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxInst;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblInfomacao;
    }
}

