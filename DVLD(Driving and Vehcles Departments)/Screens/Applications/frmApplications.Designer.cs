namespace DVLD_Interface.Screens.MISC
{
    partial class frmApplications
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApplications = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTests = new Guna.UI2.WinForms.Guna2GradientButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mangeApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivngLicenesApplicantionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivngLicenesApplicantionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLiceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.replacementLiceneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivngLicenesServisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaineLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(769, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tests Types";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(115, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Applications Types";
            // 
            // btnApplications
            // 
            this.btnApplications.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnApplications.BackColor = System.Drawing.Color.Transparent;
            this.btnApplications.CheckedState.Parent = this.btnApplications;
            this.btnApplications.CustomImages.Parent = this.btnApplications;
            this.btnApplications.FillColor = System.Drawing.Color.Transparent;
            this.btnApplications.FillColor2 = System.Drawing.Color.Transparent;
            this.btnApplications.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApplications.ForeColor = System.Drawing.Color.White;
            this.btnApplications.HoverState.Parent = this.btnApplications;
            this.btnApplications.Image = global::DVLD_Interface.Properties.Resources.Application_Types_512;
            this.btnApplications.ImageSize = new System.Drawing.Size(180, 180);
            this.btnApplications.Location = new System.Drawing.Point(108, 228);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.ShadowDecoration.Parent = this.btnApplications;
            this.btnApplications.Size = new System.Drawing.Size(230, 230);
            this.btnApplications.TabIndex = 7;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // btnTests
            // 
            this.btnTests.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTests.BackColor = System.Drawing.Color.Transparent;
            this.btnTests.CheckedState.Parent = this.btnTests;
            this.btnTests.CustomImages.Parent = this.btnTests;
            this.btnTests.FillColor = System.Drawing.Color.Transparent;
            this.btnTests.FillColor2 = System.Drawing.Color.Transparent;
            this.btnTests.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTests.ForeColor = System.Drawing.Color.White;
            this.btnTests.HoverState.Parent = this.btnTests;
            this.btnTests.Image = global::DVLD_Interface.Properties.Resources.TestType_512;
            this.btnTests.ImageSize = new System.Drawing.Size(180, 180);
            this.btnTests.Location = new System.Drawing.Point(725, 228);
            this.btnTests.Name = "btnTests";
            this.btnTests.ShadowDecoration.Parent = this.btnTests;
            this.btnTests.Size = new System.Drawing.Size(230, 230);
            this.btnTests.TabIndex = 8;
            this.btnTests.Click += new System.EventHandler(this.btnTests_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mangeApplicationsToolStripMenuItem,
            this.dToolStripMenuItem,
            this.drivngLicenesServisesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 40);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mangeApplicationsToolStripMenuItem
            // 
            this.mangeApplicationsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.mangeApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivngLicenesApplicantionsToolStripMenuItem,
            this.internationalDrivngLicenesApplicantionsToolStripMenuItem});
            this.mangeApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.mangeApplicationsToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Manage_Applications_32;
            this.mangeApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mangeApplicationsToolStripMenuItem.Name = "mangeApplicationsToolStripMenuItem";
            this.mangeApplicationsToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.mangeApplicationsToolStripMenuItem.Text = "Mange Applications";
            // 
            // localDrivngLicenesApplicantionsToolStripMenuItem
            // 
            this.localDrivngLicenesApplicantionsToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.LocalDriving_License;
            this.localDrivngLicenesApplicantionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localDrivngLicenesApplicantionsToolStripMenuItem.Name = "localDrivngLicenesApplicantionsToolStripMenuItem";
            this.localDrivngLicenesApplicantionsToolStripMenuItem.Size = new System.Drawing.Size(383, 38);
            this.localDrivngLicenesApplicantionsToolStripMenuItem.Text = "Local Drivng Licenes Applicantions";
            this.localDrivngLicenesApplicantionsToolStripMenuItem.Click += new System.EventHandler(this.localDrivngLicenesApplicantionsToolStripMenuItem_Click);
            // 
            // internationalDrivngLicenesApplicantionsToolStripMenuItem
            // 
            this.internationalDrivngLicenesApplicantionsToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.International_32;
            this.internationalDrivngLicenesApplicantionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalDrivngLicenesApplicantionsToolStripMenuItem.Name = "internationalDrivngLicenesApplicantionsToolStripMenuItem";
            this.internationalDrivngLicenesApplicantionsToolStripMenuItem.Size = new System.Drawing.Size(383, 38);
            this.internationalDrivngLicenesApplicantionsToolStripMenuItem.Text = "International Drivng Licenes Applicantions";
            this.internationalDrivngLicenesApplicantionsToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivngLicenesApplicantionsToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseApplicationsToolStripMenuItem,
            this.renewDrivingLiceneToolStripMenuItem,
            this.toolStripSeparator1,
            this.replacementLiceneeToolStripMenuItem,
            this.toolStripSeparator2,
            this.releaseDetainedLicenseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.dToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.dToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.LocalDriving_License;
            this.dToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(211, 36);
            this.dToolStripMenuItem.Text = "Driving License Servises";
            // 
            // newDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.newDrivingLicenseApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseApplicationsToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.New_Driving_License_32;
            this.newDrivingLicenseApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newDrivingLicenseApplicationsToolStripMenuItem.Name = "newDrivingLicenseApplicationsToolStripMenuItem";
            this.newDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.newDrivingLicenseApplicationsToolStripMenuItem.Text = "New Driving License";
            this.newDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.newDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Local_32;
            this.localToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            this.localToolStripMenuItem.Text = "Local License";
            this.localToolStripMenuItem.Click += new System.EventHandler(this.localToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.International_321;
            this.internationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLiceneToolStripMenuItem
            // 
            this.renewDrivingLiceneToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Renew_Driving_License_32;
            this.renewDrivingLiceneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewDrivingLiceneToolStripMenuItem.Name = "renewDrivingLiceneToolStripMenuItem";
            this.renewDrivingLiceneToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.renewDrivingLiceneToolStripMenuItem.Text = "Renew Driving Licene";
            this.renewDrivingLiceneToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLiceneToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // replacementLiceneeToolStripMenuItem
            // 
            this.replacementLiceneeToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Damaged_Driving_License_32;
            this.replacementLiceneeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replacementLiceneeToolStripMenuItem.Name = "replacementLiceneeToolStripMenuItem";
            this.replacementLiceneeToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.replacementLiceneeToolStripMenuItem.Text = "Replacement Licenee";
            this.replacementLiceneeToolStripMenuItem.Click += new System.EventHandler(this.replacementLiceneeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(269, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Detained_Driving_License_32;
            this.releaseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Retake_Test_32;
            this.retakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // drivngLicenesServisesToolStripMenuItem
            // 
            this.drivngLicenesServisesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mangeDetainedLicensesToolStripMenuItem,
            this.detaineLicenseToolStripMenuItem,
            this.releToolStripMenuItem});
            this.drivngLicenesServisesToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.drivngLicenesServisesToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Detain_32;
            this.drivngLicenesServisesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drivngLicenesServisesToolStripMenuItem.Name = "drivngLicenesServisesToolStripMenuItem";
            this.drivngLicenesServisesToolStripMenuItem.Size = new System.Drawing.Size(169, 36);
            this.drivngLicenesServisesToolStripMenuItem.Text = "Detained License";
            // 
            // mangeDetainedLicensesToolStripMenuItem
            // 
            this.mangeDetainedLicensesToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Detain_32;
            this.mangeDetainedLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mangeDetainedLicensesToolStripMenuItem.Name = "mangeDetainedLicensesToolStripMenuItem";
            this.mangeDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.mangeDetainedLicensesToolStripMenuItem.Text = "Mange Detained Licenses";
            this.mangeDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.mangeDetainedLicensesToolStripMenuItem_Click);
            // 
            // detaineLicenseToolStripMenuItem
            // 
            this.detaineLicenseToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Detain_32;
            this.detaineLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detaineLicenseToolStripMenuItem.Name = "detaineLicenseToolStripMenuItem";
            this.detaineLicenseToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.detaineLicenseToolStripMenuItem.Text = "Detaine License";
            this.detaineLicenseToolStripMenuItem.Click += new System.EventHandler(this.detaineLicenseToolStripMenuItem_Click);
            // 
            // releToolStripMenuItem
            // 
            this.releToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Detain_32;
            this.releToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releToolStripMenuItem.Name = "releToolStripMenuItem";
            this.releToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.releToolStripMenuItem.Text = "Release License";
            this.releToolStripMenuItem.Click += new System.EventHandler(this.releToolStripMenuItem_Click);
            // 
            // frmApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1062, 748);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnTests);
            this.Controls.Add(this.btnApplications);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmApplications";
            this.Text = "frmApplications";
            this.Load += new System.EventHandler(this.frmApplications_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnApplications;
        private Guna.UI2.WinForms.Guna2GradientButton btnTests;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mangeApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivngLicenesApplicantionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivngLicenesApplicantionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLiceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem replacementLiceneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivngLicenesServisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaineLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releToolStripMenuItem;
    }
}