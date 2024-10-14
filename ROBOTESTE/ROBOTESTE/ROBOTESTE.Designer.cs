namespace ROBOTESTE
{
    partial class ROBOTESTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROBOTESTE));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblTituloModelo = new System.Windows.Forms.Label();
            this.llabelSair = new System.Windows.Forms.LinkLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pBoxAvell_Logo = new System.Windows.Forms.PictureBox();
            this.pBoxAvell = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvell_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvell)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(253, 203);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(24, 20);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "...";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(92, 182);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(19, 13);
            this.lblModelo.TabIndex = 13;
            this.lblModelo.Text = "...";
            // 
            // lblTituloModelo
            // 
            this.lblTituloModelo.AutoSize = true;
            this.lblTituloModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModelo.ForeColor = System.Drawing.Color.White;
            this.lblTituloModelo.Location = new System.Drawing.Point(14, 176);
            this.lblTituloModelo.Name = "lblTituloModelo";
            this.lblTituloModelo.Size = new System.Drawing.Size(72, 20);
            this.lblTituloModelo.TabIndex = 12;
            this.lblTituloModelo.Text = "Modelo:";
            // 
            // llabelSair
            // 
            this.llabelSair.AutoSize = true;
            this.llabelSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llabelSair.Location = new System.Drawing.Point(245, 421);
            this.llabelSair.Name = "llabelSair";
            this.llabelSair.Size = new System.Drawing.Size(37, 20);
            this.llabelSair.TabIndex = 11;
            this.llabelSair.TabStop = true;
            this.llabelSair.Text = "&Sair";
            this.llabelSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llabelSair_LinkClicked);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 141);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(262, 24);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "AUTOMAÇÃO DE TESTES";
            // 
            // pBoxAvell_Logo
            // 
            this.pBoxAvell_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pBoxAvell_Logo.Image = global::ROBOTESTE.Properties.Resources.AvellRobo;
            this.pBoxAvell_Logo.Location = new System.Drawing.Point(17, 11);
            this.pBoxAvell_Logo.Name = "pBoxAvell_Logo";
            this.pBoxAvell_Logo.Size = new System.Drawing.Size(259, 125);
            this.pBoxAvell_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAvell_Logo.TabIndex = 9;
            this.pBoxAvell_Logo.TabStop = false;
            // 
            // pBoxAvell
            // 
            this.pBoxAvell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxAvell.BackColor = System.Drawing.Color.Transparent;
            this.pBoxAvell.Image = global::ROBOTESTE.Properties.Resources.robo2;
            this.pBoxAvell.Location = new System.Drawing.Point(19, 226);
            this.pBoxAvell.Name = "pBoxAvell";
            this.pBoxAvell.Size = new System.Drawing.Size(258, 187);
            this.pBoxAvell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAvell.TabIndex = 8;
            this.pBoxAvell.TabStop = false;
            this.pBoxAvell.Click += new System.EventHandler(this.pBoxAvell_Click);
            // 
            // ROBOTESTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(293, 448);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblTituloModelo);
            this.Controls.Add(this.llabelSair);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pBoxAvell_Logo);
            this.Controls.Add(this.pBoxAvell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ROBOTESTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ROBO DE TESTES AVELL";
            this.Load += new System.EventHandler(this.ROBOTESTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvell_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblTituloModelo;
        private System.Windows.Forms.LinkLabel llabelSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pBoxAvell_Logo;
        private System.Windows.Forms.PictureBox pBoxAvell;
    }
}

