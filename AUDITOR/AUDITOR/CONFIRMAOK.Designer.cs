namespace AUDITOR
{
    partial class CONFIRMAOK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONFIRMAOK));
            this.lblAuditoria = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.lblFirebase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAuditoria
            // 
            this.lblAuditoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuditoria.AutoSize = true;
            this.lblAuditoria.BackColor = System.Drawing.Color.Transparent;
            this.lblAuditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoria.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAuditoria.Location = new System.Drawing.Point(77, 76);
            this.lblAuditoria.Name = "lblAuditoria";
            this.lblAuditoria.Size = new System.Drawing.Size(297, 24);
            this.lblAuditoria.TabIndex = 14;
            this.lblAuditoria.Text = "SEGUIR PARA FINALIZAÇÃO?";
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.Location = new System.Drawing.Point(143, 121);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(156, 40);
            this.btnSim.TabIndex = 24;
            this.btnSim.Text = "SIM";
            this.btnSim.UseVisualStyleBackColor = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // lblFirebase
            // 
            this.lblFirebase.AutoSize = true;
            this.lblFirebase.BackColor = System.Drawing.Color.Transparent;
            this.lblFirebase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirebase.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFirebase.Location = new System.Drawing.Point(12, 9);
            this.lblFirebase.Name = "lblFirebase";
            this.lblFirebase.Size = new System.Drawing.Size(14, 20);
            this.lblFirebase.TabIndex = 35;
            this.lblFirebase.Text = ".";
            // 
            // CONFIRMAOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 182);
            this.Controls.Add(this.lblFirebase);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.lblAuditoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CONFIRMAOK";
            this.Text = "CONFIRMA AUDITORIA";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuditoria;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Label lblFirebase;
    }
}