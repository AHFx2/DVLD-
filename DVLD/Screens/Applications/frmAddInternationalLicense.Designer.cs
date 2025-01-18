namespace DVLD_Interface.Screens.MISC
{
    partial class frmAddInternationalLicense
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
            this.ctrAddInternationalLicense1 = new DVLD_Interface.Controls.ctrMISC.ctrAddInternationalLicense();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pExit
            // 
            this.pExit.Location = new System.Drawing.Point(688, 0);
            this.pExit.Size = new System.Drawing.Size(32, 27);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.ctrAddInternationalLicense1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(720, 680);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.ctrAddInternationalLicense1, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.pExit, 0);
            // 
            // ctrAddInternationalLicense1
            // 
            this.ctrAddInternationalLicense1.BackColor = System.Drawing.Color.Transparent;
            this.ctrAddInternationalLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrAddInternationalLicense1.Location = new System.Drawing.Point(0, 0);
            this.ctrAddInternationalLicense1.Name = "ctrAddInternationalLicense1";
            this.ctrAddInternationalLicense1.Size = new System.Drawing.Size(720, 680);
            this.ctrAddInternationalLicense1.TabIndex = 1;
            this.ctrAddInternationalLicense1.Load += new System.EventHandler(this.ctrAddInternationalLicense1_Load);
            // 
            // frmAddInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 680);
            this.Name = "frmAddInternationalLicense";
            this.Text = "frmAddInternationalLicense";
            this.Load += new System.EventHandler(this.frmAddInternationalLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrMISC.ctrAddInternationalLicense ctrAddInternationalLicense1;
    }
}