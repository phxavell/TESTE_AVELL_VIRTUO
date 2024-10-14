
namespace TESTE_MAQUINAS
{
    partial class Sistema_Teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Teste));
            this.splOpcoes = new System.Windows.Forms.Splitter();
            this.lblSair = new MaterialSkin.Controls.MaterialLabel();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splOpcoes
            // 
            this.splOpcoes.BackColor = System.Drawing.Color.Black;
            this.splOpcoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splOpcoes.Location = new System.Drawing.Point(0, 0);
            this.splOpcoes.Name = "splOpcoes";
            this.splOpcoes.Size = new System.Drawing.Size(200, 641);
            this.splOpcoes.TabIndex = 0;
            this.splOpcoes.TabStop = false;
            // 
            // lblSair
            // 
            this.lblSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSair.AutoSize = true;
            this.lblSair.Depth = 0;
            this.lblSair.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSair.Location = new System.Drawing.Point(12, 613);
            this.lblSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(175, 19);
            this.lblSair.TabIndex = 1;
            this.lblSair.Text = "&Fechar Sistema de Teste";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblInfo1.Location = new System.Drawing.Point(6, 20);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(185, 16);
            this.lblInfo1.TabIndex = 3;
            this.lblInfo1.Text = "TESTES DE HARDWARE";
            // 
            // Sistema_Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TESTE_MAQUINAS.Properties.Resources.bakground_sistema2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 641);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.splOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sistema_Teste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMAS DE TESTES DE MÁQUINAS AVELL - AM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splOpcoes;
        private MaterialSkin.Controls.MaterialLabel lblSair;
        private System.Windows.Forms.Label lblInfo1;
    }
}

