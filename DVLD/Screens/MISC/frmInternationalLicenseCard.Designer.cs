namespace DVLD_Interface.Screens.MISC
{
    partial class frmInternationalLicenseCard
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
            this.ctrInterntionalLiceneCard1 = new DVLD_Interface.Controls.ctrMISC.ctrInterntionalLiceneCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pExit
            // 
            this.pExit.Location = new System.Drawing.Point(689, 0);
            this.pExit.Size = new System.Drawing.Size(28, 37);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.ctrInterntionalLiceneCard1);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Cyan;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Cyan;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Cyan;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(720, 642);
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.pExit, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.ctrInterntionalLiceneCard1, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.label1, 0);
            // 
            // ctrInterntionalLiceneCard1
            // 
            this.ctrInterntionalLiceneCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrInterntionalLiceneCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrInterntionalLiceneCard1.Location = new System.Drawing.Point(0, 149);
            this.ctrInterntionalLiceneCard1.Name = "ctrInterntionalLiceneCard1";
            this.ctrInterntionalLiceneCard1.Size = new System.Drawing.Size(720, 493);
            this.ctrInterntionalLiceneCard1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_Interface.Properties.Resources.LicenseView_400;
            this.pictureBox1.Location = new System.Drawing.Point(283, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(116, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Driver International License";
            // 
            // frmInternationalLicenseCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 642);
            this.Name = "frmInternationalLicenseCard";
            this.Text = "frmInternationalLicenseCard";
            this.Load += new System.EventHandler(this.frmInternationalLicenseCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.ctrMISC.ctrInterntionalLiceneCard ctrInterntionalLiceneCard1;
        private System.Windows.Forms.Label label1;
    }
}