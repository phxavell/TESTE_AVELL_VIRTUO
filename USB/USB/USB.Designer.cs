
namespace USB
{
    partial class USB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USB));
            this.lblNomeInfo = new System.Windows.Forms.Label();
            this.lblFormatoInfo = new System.Windows.Forms.Label();
            this.lblTipoDriverInfo = new System.Windows.Forms.Label();
            this.lblInfoStatus = new System.Windows.Forms.Label();
            this.lblInfoEspaco = new System.Windows.Forms.Label();
            this.lblEspacoLivre = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblFreeSpace = new System.Windows.Forms.Label();
            this.lblTotalSpace = new System.Windows.Forms.Label();
            this.lblReady = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPortas = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblUsb2 = new System.Windows.Forms.Label();
            this.listbArquivos1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeInfo
            // 
            this.lblNomeInfo.AutoSize = true;
            this.lblNomeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeInfo.Location = new System.Drawing.Point(8, 33);
            this.lblNomeInfo.Name = "lblNomeInfo";
            this.lblNomeInfo.Size = new System.Drawing.Size(193, 20);
            this.lblNomeInfo.TabIndex = 1;
            this.lblNomeInfo.Text = "Unidade do Dispositivo";
            // 
            // lblFormatoInfo
            // 
            this.lblFormatoInfo.AutoSize = true;
            this.lblFormatoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatoInfo.Location = new System.Drawing.Point(8, 83);
            this.lblFormatoInfo.Name = "lblFormatoInfo";
            this.lblFormatoInfo.Size = new System.Drawing.Size(237, 20);
            this.lblFormatoInfo.TabIndex = 2;
            this.lblFormatoInfo.Text = "Formato do Armazenamento";
            // 
            // lblTipoDriverInfo
            // 
            this.lblTipoDriverInfo.AutoSize = true;
            this.lblTipoDriverInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDriverInfo.Location = new System.Drawing.Point(8, 133);
            this.lblTipoDriverInfo.Name = "lblTipoDriverInfo";
            this.lblTipoDriverInfo.Size = new System.Drawing.Size(120, 20);
            this.lblTipoDriverInfo.TabIndex = 3;
            this.lblTipoDriverInfo.Text = "Tipo de Driver";
            // 
            // lblInfoStatus
            // 
            this.lblInfoStatus.AutoSize = true;
            this.lblInfoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoStatus.Location = new System.Drawing.Point(8, 183);
            this.lblInfoStatus.Name = "lblInfoStatus";
            this.lblInfoStatus.Size = new System.Drawing.Size(62, 20);
            this.lblInfoStatus.TabIndex = 4;
            this.lblInfoStatus.Text = "Status";
            // 
            // lblInfoEspaco
            // 
            this.lblInfoEspaco.AutoSize = true;
            this.lblInfoEspaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEspaco.Location = new System.Drawing.Point(10, 233);
            this.lblInfoEspaco.Name = "lblInfoEspaco";
            this.lblInfoEspaco.Size = new System.Drawing.Size(170, 20);
            this.lblInfoEspaco.TabIndex = 5;
            this.lblInfoEspaco.Text = "Espaço em Unidade";
            // 
            // lblEspacoLivre
            // 
            this.lblEspacoLivre.AutoSize = true;
            this.lblEspacoLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacoLivre.Location = new System.Drawing.Point(10, 283);
            this.lblEspacoLivre.Name = "lblEspacoLivre";
            this.lblEspacoLivre.Size = new System.Drawing.Size(112, 20);
            this.lblEspacoLivre.TabIndex = 6;
            this.lblEspacoLivre.Text = "Espaço Livre";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfo.Controls.Add(this.lblFreeSpace);
            this.panelInfo.Controls.Add(this.lblTotalSpace);
            this.panelInfo.Controls.Add(this.lblReady);
            this.panelInfo.Controls.Add(this.lblType);
            this.panelInfo.Controls.Add(this.lblFormat);
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Controls.Add(this.lblNomeInfo);
            this.panelInfo.Controls.Add(this.lblFormatoInfo);
            this.panelInfo.Controls.Add(this.lblTipoDriverInfo);
            this.panelInfo.Controls.Add(this.lblEspacoLivre);
            this.panelInfo.Controls.Add(this.lblInfoStatus);
            this.panelInfo.Controls.Add(this.lblInfoEspaco);
            this.panelInfo.Location = new System.Drawing.Point(12, 208);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(535, 349);
            this.panelInfo.TabIndex = 8;
            // 
            // lblFreeSpace
            // 
            this.lblFreeSpace.AutoSize = true;
            this.lblFreeSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeSpace.Location = new System.Drawing.Point(399, 283);
            this.lblFreeSpace.Name = "lblFreeSpace";
            this.lblFreeSpace.Size = new System.Drawing.Size(14, 20);
            this.lblFreeSpace.TabIndex = 12;
            this.lblFreeSpace.Text = ".";
            // 
            // lblTotalSpace
            // 
            this.lblTotalSpace.AutoSize = true;
            this.lblTotalSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSpace.Location = new System.Drawing.Point(399, 233);
            this.lblTotalSpace.Name = "lblTotalSpace";
            this.lblTotalSpace.Size = new System.Drawing.Size(14, 20);
            this.lblTotalSpace.TabIndex = 11;
            this.lblTotalSpace.Text = ".";
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReady.Location = new System.Drawing.Point(399, 183);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(14, 20);
            this.lblReady.TabIndex = 10;
            this.lblReady.Text = ".";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(399, 133);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(14, 20);
            this.lblType.TabIndex = 9;
            this.lblType.Text = ".";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat.Location = new System.Drawing.Point(399, 83);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(14, 20);
            this.lblFormat.TabIndex = 8;
            this.lblFormat.Text = ".";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(399, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(14, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = ".";
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortas.Location = new System.Drawing.Point(566, 206);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(180, 20);
            this.lblPortas.TabIndex = 13;
            this.lblPortas.Text = "ARQUIVOS ORIGEM";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.BackColor = System.Drawing.Color.Transparent;
            this.lblTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime2.Location = new System.Drawing.Point(450, 578);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(32, 24);
            this.lblTime2.TabIndex = 21;
            this.lblTime2.Text = "10";
            // 
            // lblUsb2
            // 
            this.lblUsb2.AutoSize = true;
            this.lblUsb2.BackColor = System.Drawing.Color.Transparent;
            this.lblUsb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsb2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUsb2.Location = new System.Drawing.Point(12, 578);
            this.lblUsb2.Name = "lblUsb2";
            this.lblUsb2.Size = new System.Drawing.Size(432, 24);
            this.lblUsb2.TabIndex = 20;
            this.lblUsb2.Text = "INSERIR DISPOSITIVO USB / SD/ MICRO-SD:";
            // 
            // listbArquivos1
            // 
            this.listbArquivos1.BackColor = System.Drawing.Color.Gainsboro;
            this.listbArquivos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbArquivos1.FormattingEnabled = true;
            this.listbArquivos1.ItemHeight = 18;
            this.listbArquivos1.Location = new System.Drawing.Point(570, 229);
            this.listbArquivos1.Name = "listbArquivos1";
            this.listbArquivos1.Size = new System.Drawing.Size(392, 328);
            this.listbArquivos1.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::USB.Properties.Resources.avell_icone;
            this.pictureBox2.Location = new System.Drawing.Point(800, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::USB.Properties.Resources.pendrive;
            this.pictureBox1.Location = new System.Drawing.Point(11, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // USB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 627);
            this.Controls.Add(this.listbArquivos1);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.lblUsb2);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "USB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE USB / SD / MICRO SD";
            this.TopMost = true;
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeInfo;
        private System.Windows.Forms.Label lblFormatoInfo;
        private System.Windows.Forms.Label lblTipoDriverInfo;
        private System.Windows.Forms.Label lblInfoStatus;
        private System.Windows.Forms.Label lblInfoEspaco;
        private System.Windows.Forms.Label lblEspacoLivre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFreeSpace;
        private System.Windows.Forms.Label lblTotalSpace;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPortas;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblUsb2;
        private System.Windows.Forms.ListBox listbArquivos1;
    }
}

