namespace DVLD_Interface.Applications.Local_Drinving_License_Application
{
    partial class frmLocalDrivingLicenseApplication_Info
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
            this.ctrLocalDrivingLicenseApplicationInfo1 = new DVLD_Interface.Applications.Local_Drinving_License_Application.ctrLocalDrivingLicenseApplicationInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrLocalDrivingLicenseApplicationInfo1
            // 
            this.ctrLocalDrivingLicenseApplicationInfo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrLocalDrivingLicenseApplicationInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.ctrLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(0, 60);
            this.ctrLocalDrivingLicenseApplicationInfo1.Name = "ctrLocalDrivingLicenseApplicationInfo1";
            this.ctrLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(870, 340);
            this.ctrLocalDrivingLicenseApplicationInfo1.TabIndex = 0;
            this.ctrLocalDrivingLicenseApplicationInfo1.Load += new System.EventHandler(this.ctrLocalDrivingLicenseApplicationInfo1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(122, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local Driving License Application Info";
            // 
            // frmLocalDrivingLicenseApplication_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrLocalDrivingLicenseApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLocalDrivingLicenseApplication_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Application Info";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplication_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrLocalDrivingLicenseApplicationInfo ctrLocalDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Label label1;
    }
}