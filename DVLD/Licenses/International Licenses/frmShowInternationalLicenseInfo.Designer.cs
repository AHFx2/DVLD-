namespace DVLD_Interface.Licenses.International_Licenses
{
    partial class frmShowInternationalLicenseInfo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbTestTypeImage = new System.Windows.Forms.PictureBox();
            this.ctrDriverInternationalLicenseInfo1 = new DVLD_Interface.Licenses.International_Licenses.Controls.ctrDriverInternationalLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.lblTitle.Location = new System.Drawing.Point(172, 123);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(520, 39);
            this.lblTitle.TabIndex = 140;
            this.lblTitle.Text = "Driver International License Info";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbTestTypeImage
            // 
            this.pbTestTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTestTypeImage.Image = global::DVLD_Interface.Properties.Resources.License_View_32;
            this.pbTestTypeImage.InitialImage = null;
            this.pbTestTypeImage.Location = new System.Drawing.Point(369, 14);
            this.pbTestTypeImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbTestTypeImage.Name = "pbTestTypeImage";
            this.pbTestTypeImage.Size = new System.Drawing.Size(113, 104);
            this.pbTestTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestTypeImage.TabIndex = 139;
            this.pbTestTypeImage.TabStop = false;
            // 
            // ctrDriverInternationalLicenseInfo1
            // 
            this.ctrDriverInternationalLicenseInfo1.Location = new System.Drawing.Point(-10, 175);
            this.ctrDriverInternationalLicenseInfo1.Name = "ctrDriverInternationalLicenseInfo1";
            this.ctrDriverInternationalLicenseInfo1.Size = new System.Drawing.Size(869, 273);
            this.ctrDriverInternationalLicenseInfo1.TabIndex = 0;
            // 
            // frmShowInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 445);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbTestTypeImage);
            this.Controls.Add(this.ctrDriverInternationalLicenseInfo1);
            this.Name = "frmShowInternationalLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show International License Info";
            this.Load += new System.EventHandler(this.frmShowInternationalLicenseInfo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrDriverInternationalLicenseInfo ctrDriverInternationalLicenseInfo1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
    }
}