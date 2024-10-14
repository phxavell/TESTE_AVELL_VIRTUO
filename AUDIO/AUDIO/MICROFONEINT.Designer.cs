
namespace AUDIO
{
    partial class MICROFONEINT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MICROFONEINT));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblConfirme2 = new System.Windows.Forms.Label();
            this.lblConfirme = new System.Windows.Forms.Label();
            this.progressBarAudio = new System.Windows.Forms.ProgressBar();
            this.timerCronometro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(528, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "TEMPO:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(631, 71);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(28, 24);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "...";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AUDIO.Properties.Resources.micronone;
            this.pictureBox3.Location = new System.Drawing.Point(499, 270);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::AUDIO.Properties.Resources.avell_icone1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 71);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(189, 109);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 25;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblConfirme2
            // 
            this.lblConfirme2.AutoSize = true;
            this.lblConfirme2.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblConfirme2.Location = new System.Drawing.Point(119, 358);
            this.lblConfirme2.Name = "lblConfirme2";
            this.lblConfirme2.Size = new System.Drawing.Size(275, 24);
            this.lblConfirme2.TabIndex = 31;
            this.lblConfirme2.Text = "CAPTURA SOM AMBIENTE.";
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblConfirme.Location = new System.Drawing.Point(93, 295);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(339, 24);
            this.lblConfirme.TabIndex = 30;
            this.lblConfirme.Text = "TESTE DE MICROFONE INTERNO";
            // 
            // progressBarAudio
            // 
            this.progressBarAudio.BackColor = System.Drawing.Color.DarkCyan;
            this.progressBarAudio.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.progressBarAudio.Location = new System.Drawing.Point(12, 450);
            this.progressBarAudio.Name = "progressBarAudio";
            this.progressBarAudio.Size = new System.Drawing.Size(656, 18);
            this.progressBarAudio.TabIndex = 32;
            // 
            // timerCronometro
            // 
            this.timerCronometro.Tick += new System.EventHandler(this.timerCronometro_Tick);
            // 
            // MICROFONEINT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 480);
            this.Controls.Add(this.progressBarAudio);
            this.Controls.Add(this.lblConfirme2);
            this.Controls.Add(this.lblConfirme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MICROFONEINT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MICROFONE INTERNO  - V1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblConfirme2;
        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.ProgressBar progressBarAudio;
        private System.Windows.Forms.Timer timerCronometro;
    }
}