namespace DVLD_Interface.Screens.MISC
{
    partial class frmReleaseDetain
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
            this.ctrReleaseDetainedLicense1 = new DVLD_Interface.Controls.ctrLicenses.ctrReleaseDetainedLicense();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pExit
            // 
            this.pExit.Location = new System.Drawing.Point(687, 0);
            this.pExit.Size = new System.Drawing.Size(30, 30);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.ctrReleaseDetainedLicense1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(720, 680);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.ctrReleaseDetainedLicense1, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.pExit, 0);
            // 
            // ctrReleaseDetainedLicense1
            // 
            this.ctrReleaseDetainedLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrReleaseDetainedLicense1.Location = new System.Drawing.Point(0, 0);
            this.ctrReleaseDetainedLicense1.Name = "ctrReleaseDetainedLicense1";
            this.ctrReleaseDetainedLicense1.Size = new System.Drawing.Size(720, 680);
            this.ctrReleaseDetainedLicense1.TabIndex = 1;
            // 
            // frmReleaseDetain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 680);
            this.Name = "frmReleaseDetain";
            this.Text = "frmReleaseDetain";
            this.Load += new System.EventHandler(this.frmReleaseDetain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrLicenses.ctrReleaseDetainedLicense ctrReleaseDetainedLicense1;
    }
}