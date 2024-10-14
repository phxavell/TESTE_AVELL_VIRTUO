
namespace TOUCHPAD
{
    partial class TOUCHPAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TOUCHPAD));
            this.panelTouch = new System.Windows.Forms.Panel();
            this.panelTouchPad = new System.Windows.Forms.Panel();
            this.btnTouch = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelBotaoEsq2 = new System.Windows.Forms.Panel();
            this.btnEsq2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelBotaoDir2 = new System.Windows.Forms.Panel();
            this.btnDir2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelBotaoEsq = new System.Windows.Forms.Panel();
            this.btnEsq = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelBotaoDir = new System.Windows.Forms.Panel();
            this.btnDir = new MaterialSkin.Controls.MaterialFlatButton();
            this.timerCursor = new System.Windows.Forms.Timer(this.components);
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.labelxy = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblConfirme = new System.Windows.Forms.Label();
            this.panelTouch.SuspendLayout();
            this.panelTouchPad.SuspendLayout();
            this.panelBotaoEsq2.SuspendLayout();
            this.panelBotaoDir2.SuspendLayout();
            this.panelBotaoEsq.SuspendLayout();
            this.panelBotaoDir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTouch
            // 
            this.panelTouch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTouch.Controls.Add(this.panelTouchPad);
            this.panelTouch.Controls.Add(this.panelBotaoEsq2);
            this.panelTouch.Controls.Add(this.panelBotaoDir2);
            this.panelTouch.Location = new System.Drawing.Point(12, 156);
            this.panelTouch.Name = "panelTouch";
            this.panelTouch.Size = new System.Drawing.Size(985, 427);
            this.panelTouch.TabIndex = 1;
            // 
            // panelTouchPad
            // 
            this.panelTouchPad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTouchPad.Controls.Add(this.btnTouch);
            this.panelTouchPad.Location = new System.Drawing.Point(252, 219);
            this.panelTouchPad.Name = "panelTouchPad";
            this.panelTouchPad.Size = new System.Drawing.Size(488, 48);
            this.panelTouchPad.TabIndex = 5;
            this.panelTouchPad.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTouchPad_Paint);
            // 
            // btnTouch
            // 
            this.btnTouch.AutoSize = true;
            this.btnTouch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTouch.Depth = 0;
            this.btnTouch.Location = new System.Drawing.Point(134, 4);
            this.btnTouch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTouch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTouch.Name = "btnTouch";
            this.btnTouch.Primary = false;
            this.btnTouch.Size = new System.Drawing.Size(201, 36);
            this.btnTouch.TabIndex = 1;
            this.btnTouch.Text = "5-CLIQUE AQUI COM O TOUCH";
            this.btnTouch.UseVisualStyleBackColor = true;
            this.btnTouch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTouch_MouseDown);
            // 
            // panelBotaoEsq2
            // 
            this.panelBotaoEsq2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBotaoEsq2.Controls.Add(this.btnEsq2);
            this.panelBotaoEsq2.Location = new System.Drawing.Point(491, 3);
            this.panelBotaoEsq2.Name = "panelBotaoEsq2";
            this.panelBotaoEsq2.Size = new System.Drawing.Size(488, 48);
            this.panelBotaoEsq2.TabIndex = 3;
            // 
            // btnEsq2
            // 
            this.btnEsq2.AutoSize = true;
            this.btnEsq2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEsq2.Depth = 0;
            this.btnEsq2.Location = new System.Drawing.Point(123, 4);
            this.btnEsq2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEsq2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEsq2.Name = "btnEsq2";
            this.btnEsq2.Primary = false;
            this.btnEsq2.Size = new System.Drawing.Size(261, 36);
            this.btnEsq2.TabIndex = 1;
            this.btnEsq2.Text = "2-CLIQUE AQUI COM BOTÃO ESQUERDO";
            this.btnEsq2.UseVisualStyleBackColor = true;
            this.btnEsq2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEsq2_MouseClick);
            // 
            // panelBotaoDir2
            // 
            this.panelBotaoDir2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBotaoDir2.Controls.Add(this.btnDir2);
            this.panelBotaoDir2.Location = new System.Drawing.Point(2, 3);
            this.panelBotaoDir2.Name = "panelBotaoDir2";
            this.panelBotaoDir2.Size = new System.Drawing.Size(488, 48);
            this.panelBotaoDir2.TabIndex = 3;
            // 
            // btnDir2
            // 
            this.btnDir2.AutoSize = true;
            this.btnDir2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDir2.Depth = 0;
            this.btnDir2.Location = new System.Drawing.Point(119, 4);
            this.btnDir2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDir2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDir2.Name = "btnDir2";
            this.btnDir2.Primary = false;
            this.btnDir2.Size = new System.Drawing.Size(255, 36);
            this.btnDir2.TabIndex = 1;
            this.btnDir2.Text = "1-CLIQUE AQUI COM O BOTÃO DIREITO";
            this.btnDir2.UseVisualStyleBackColor = true;
            this.btnDir2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDir2_MouseDown);
            // 
            // panelBotaoEsq
            // 
            this.panelBotaoEsq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBotaoEsq.Controls.Add(this.btnEsq);
            this.panelBotaoEsq.Location = new System.Drawing.Point(12, 589);
            this.panelBotaoEsq.Name = "panelBotaoEsq";
            this.panelBotaoEsq.Size = new System.Drawing.Size(488, 48);
            this.panelBotaoEsq.TabIndex = 2;
            // 
            // btnEsq
            // 
            this.btnEsq.AutoSize = true;
            this.btnEsq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEsq.Depth = 0;
            this.btnEsq.Location = new System.Drawing.Point(112, 4);
            this.btnEsq.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEsq.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEsq.Name = "btnEsq";
            this.btnEsq.Primary = false;
            this.btnEsq.Size = new System.Drawing.Size(261, 36);
            this.btnEsq.TabIndex = 0;
            this.btnEsq.Text = "3-CLIQUE AQUI COM BOTÃO ESQUERDO";
            this.btnEsq.UseVisualStyleBackColor = true;
            this.btnEsq.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEsq_MouseClick);
            // 
            // panelBotaoDir
            // 
            this.panelBotaoDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBotaoDir.Controls.Add(this.btnDir);
            this.panelBotaoDir.Location = new System.Drawing.Point(509, 589);
            this.panelBotaoDir.Name = "panelBotaoDir";
            this.panelBotaoDir.Size = new System.Drawing.Size(488, 48);
            this.panelBotaoDir.TabIndex = 3;
            // 
            // btnDir
            // 
            this.btnDir.AutoSize = true;
            this.btnDir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDir.Depth = 0;
            this.btnDir.Location = new System.Drawing.Point(114, 4);
            this.btnDir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDir.Name = "btnDir";
            this.btnDir.Primary = false;
            this.btnDir.Size = new System.Drawing.Size(255, 36);
            this.btnDir.TabIndex = 0;
            this.btnDir.Text = "4-CLIQUE AQUI COM O BOTÃO DIREITO";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDir_MouseDown);
            // 
            // timerCursor
            // 
            this.timerCursor.Interval = 1000;
            this.timerCursor.Tick += new System.EventHandler(this.timerCursor_Tick);
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.BackColor = System.Drawing.Color.Transparent;
            this.lblCoordenadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordenadas.ForeColor = System.Drawing.Color.Gold;
            this.lblCoordenadas.Location = new System.Drawing.Point(599, 29);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(41, 31);
            this.lblCoordenadas.TabIndex = 6;
            this.lblCoordenadas.Text = "...";
            // 
            // labelxy
            // 
            this.labelxy.AutoSize = true;
            this.labelxy.BackColor = System.Drawing.Color.Transparent;
            this.labelxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxy.ForeColor = System.Drawing.Color.Gold;
            this.labelxy.Location = new System.Drawing.Point(313, 29);
            this.labelxy.Name = "labelxy";
            this.labelxy.Size = new System.Drawing.Size(260, 31);
            this.labelxy.TabIndex = 7;
            this.labelxy.Text = "Coordenadas X, Y:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(678, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(315, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "SIGA A SEQUENCIA NUMÉRICA DOS BOTÕES";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::TOUCHPAD.Properties.Resources.avell_icone;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 68);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(148, 82);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(961, 126);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 24);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "20";
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblConfirme.Location = new System.Drawing.Point(866, 126);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(89, 24);
            this.lblConfirme.TabIndex = 16;
            this.lblConfirme.Text = "TEMPO:";
            // 
            // TOUCHPAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 650);
            this.Controls.Add(this.lblConfirme);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.labelxy);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblCoordenadas);
            this.Controls.Add(this.panelBotaoDir);
            this.Controls.Add(this.panelBotaoEsq);
            this.Controls.Add(this.panelTouch);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TOUCHPAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE DE TOUCHPAD";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TOUCHPAD_Load);
            this.panelTouch.ResumeLayout(false);
            this.panelTouchPad.ResumeLayout(false);
            this.panelTouchPad.PerformLayout();
            this.panelBotaoEsq2.ResumeLayout(false);
            this.panelBotaoEsq2.PerformLayout();
            this.panelBotaoDir2.ResumeLayout(false);
            this.panelBotaoDir2.PerformLayout();
            this.panelBotaoEsq.ResumeLayout(false);
            this.panelBotaoEsq.PerformLayout();
            this.panelBotaoDir.ResumeLayout(false);
            this.panelBotaoDir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelTouch;
        private System.Windows.Forms.Panel panelBotaoEsq;
        private System.Windows.Forms.Panel panelBotaoDir;
        private MaterialSkin.Controls.MaterialFlatButton btnEsq;
        private MaterialSkin.Controls.MaterialFlatButton btnDir;
        private System.Windows.Forms.Timer timerCursor;
        private System.Windows.Forms.Label lblCoordenadas;
        private System.Windows.Forms.Label labelxy;
        private MaterialSkin.Controls.MaterialFlatButton btnDir2;
        private MaterialSkin.Controls.MaterialFlatButton btnEsq2;
        private System.Windows.Forms.Panel panelBotaoEsq2;
        private System.Windows.Forms.Panel panelBotaoDir2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panelTouchPad;
        private MaterialSkin.Controls.MaterialFlatButton btnTouch;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblConfirme;
    }
}

