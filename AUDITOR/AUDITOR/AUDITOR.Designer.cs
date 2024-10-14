
namespace AUDITOR
{
    partial class AUDITOR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AUDITOR));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAuditoria = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.webAudit = new System.Windows.Forms.WebBrowser();
            this.progressBarAudit = new System.Windows.Forms.ProgressBar();
            this.timerSegundos = new System.Windows.Forms.Timer(this.components);
            this.lblKeyInfo = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AUDITOR.Properties.Resources.avell_icone;
            this.pictureBox1.Location = new System.Drawing.Point(12, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAuditoria
            // 
            this.lblAuditoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuditoria.AutoSize = true;
            this.lblAuditoria.BackColor = System.Drawing.Color.Transparent;
            this.lblAuditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoria.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAuditoria.Location = new System.Drawing.Point(609, 88);
            this.lblAuditoria.Name = "lblAuditoria";
            this.lblAuditoria.Size = new System.Drawing.Size(619, 24);
            this.lblAuditoria.TabIndex = 13;
            this.lblAuditoria.Text = "CONFERÊNCIA DE CONFIGURAÇÃO X ORDEM DE PRODUÇÃO";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(1038, 126);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(21, 24);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "3";
            // 
            // webAudit
            // 
            this.webAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webAudit.Location = new System.Drawing.Point(12, 188);
            this.webAudit.MinimumSize = new System.Drawing.Size(20, 20);
            this.webAudit.Name = "webAudit";
            this.webAudit.Size = new System.Drawing.Size(1234, 568);
            this.webAudit.TabIndex = 16;
            this.webAudit.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // progressBarAudit
            // 
            this.progressBarAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarAudit.Location = new System.Drawing.Point(619, 134);
            this.progressBarAudit.Name = "progressBarAudit";
            this.progressBarAudit.Size = new System.Drawing.Size(413, 10);
            this.progressBarAudit.TabIndex = 17;
            // 
            // timerSegundos
            // 
            this.timerSegundos.Tick += new System.EventHandler(this.timerSegundos_Tick);
            // 
            // lblKeyInfo
            // 
            this.lblKeyInfo.AutoSize = true;
            this.lblKeyInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblKeyInfo.Location = new System.Drawing.Point(615, 32);
            this.lblKeyInfo.Name = "lblKeyInfo";
            this.lblKeyInfo.Size = new System.Drawing.Size(214, 24);
            this.lblKeyInfo.TabIndex = 21;
            this.lblKeyInfo.Text = "CHAVE MICROSOFT:";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.BackColor = System.Drawing.Color.Transparent;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.LightGray;
            this.lblKey.Location = new System.Drawing.Point(835, 32);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(16, 24);
            this.lblKey.TabIndex = 20;
            this.lblKey.Text = ".";
            // 
            // AUDITOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 768);
            this.Controls.Add(this.lblKeyInfo);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.progressBarAudit);
            this.Controls.Add(this.webAudit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblAuditoria);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AUDITOR";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUDITOR DE ORDEM DE PRODUÇÃO - AVELL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAuditoria;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.WebBrowser webAudit;
        private System.Windows.Forms.ProgressBar progressBarAudit;
        private System.Windows.Forms.Timer timerSegundos;
        private System.Windows.Forms.Label lblKeyInfo;
        private System.Windows.Forms.Label lblKey;
    }
}

