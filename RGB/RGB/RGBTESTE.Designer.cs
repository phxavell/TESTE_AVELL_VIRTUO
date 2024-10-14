
namespace RGB
{
    partial class RGBTESTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RGBTESTE));
            this.timerRGB = new System.Windows.Forms.Timer(this.components);
            this.timerSTOP = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerRGB
            // 
            this.timerRGB.Interval = 1500;
            this.timerRGB.Tick += new System.EventHandler(this.timerRGB_Tick);
            // 
            // timerSTOP
            // 
            this.timerSTOP.Interval = 60000;
            this.timerSTOP.Tick += new System.EventHandler(this.timerSTOP_Tick);
            // 
            // RGBTESTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RGBTESTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE DE RGB";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerRGB;
        private System.Windows.Forms.Timer timerSTOP;
    }
}

