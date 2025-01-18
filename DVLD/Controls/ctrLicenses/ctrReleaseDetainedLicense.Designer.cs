namespace DVLD_Interface.Controls.ctrLicenses
{
    partial class ctrReleaseDetainedLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrReleaseDetainedLicense));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnShowLicenseHistory = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAppdate = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReAppID = new System.Windows.Forms.Label();
            this.lblReleasseDate = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDetaineID = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnShowNewLicenseInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ctrFindLicense1 = new DVLD_Interface.Controls.ctrMISC.ctrFindLicense();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 680);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Tomato;
            this.tabPage1.Controls.Add(this.btnShowLicenseHistory);
            this.tabPage1.Controls.Add(this.btnRelease);
            this.tabPage1.Controls.Add(this.ctrFindLicense1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find License";
            // 
            // btnShowLicenseHistory
            // 
            this.btnShowLicenseHistory.Enabled = false;
            this.btnShowLicenseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnShowLicenseHistory.ForeColor = System.Drawing.Color.Snow;
            this.btnShowLicenseHistory.Image = global::DVLD_Interface.Properties.Resources.refresh;
            this.btnShowLicenseHistory.Location = new System.Drawing.Point(6, 590);
            this.btnShowLicenseHistory.Name = "btnShowLicenseHistory";
            this.btnShowLicenseHistory.Size = new System.Drawing.Size(155, 56);
            this.btnShowLicenseHistory.TabIndex = 1;
            this.btnShowLicenseHistory.Text = "Show License History";
            this.btnShowLicenseHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowLicenseHistory.UseVisualStyleBackColor = true;
            // 
            // btnRelease
            // 
            this.btnRelease.Enabled = false;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnRelease.ForeColor = System.Drawing.Color.Snow;
            this.btnRelease.Image = global::DVLD_Interface.Properties.Resources.Release_Detained_License_32;
            this.btnRelease.Location = new System.Drawing.Point(554, 590);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(155, 56);
            this.btnRelease.TabIndex = 1;
            this.btnRelease.Text = "Release Detained License";
            this.btnRelease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnDetained_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tomato;
            this.tabPage2.Controls.Add(this.guna2GroupBox1);
            this.tabPage2.Controls.Add(this.btnShowNewLicenseInfo);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Release Detained License";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.lblFineFees);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.lblAppdate);
            this.guna2GroupBox1.Controls.Add(this.lblUserName);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.lblReAppID);
            this.guna2GroupBox1.Controls.Add(this.lblReleasseDate);
            this.guna2GroupBox1.Controls.Add(this.lblDetainDate);
            this.guna2GroupBox1.Controls.Add(this.lblTotalFees);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.lblAppFees);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.label16);
            this.guna2GroupBox1.Controls.Add(this.label17);
            this.guna2GroupBox1.Controls.Add(this.lblDetaineID);
            this.guna2GroupBox1.Controls.Add(this.lblLicenseID);
            this.guna2GroupBox1.Controls.Add(this.label15);
            this.guna2GroupBox1.Controls.Add(this.label19);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Wheat;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Snow;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(706, 586);
            this.guna2GroupBox1.TabIndex = 19;
            this.guna2GroupBox1.Text = "Detain Information ";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFineFees.Location = new System.Drawing.Point(240, 301);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(41, 22);
            this.lblFineFees.TabIndex = 12;
            this.lblFineFees.Text = "[??}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::DVLD_Interface.Properties.Resources.money_32;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fine Fees:               ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::DVLD_Interface.Properties.Resources.money_32;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(342, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Fees:                  ";
            // 
            // lblAppdate
            // 
            this.lblAppdate.AutoSize = true;
            this.lblAppdate.BackColor = System.Drawing.Color.Transparent;
            this.lblAppdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAppdate.Location = new System.Drawing.Point(587, 218);
            this.lblAppdate.Name = "lblAppdate";
            this.lblAppdate.Size = new System.Drawing.Size(41, 22);
            this.lblAppdate.TabIndex = 1;
            this.lblAppdate.Text = "[??}";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserName.Location = new System.Drawing.Point(239, 383);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 22);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "[??}";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(342, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "App Date:                    ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::DVLD_Interface.Properties.Resources.User_32__2;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(12, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Created By User:     ";
            // 
            // lblReAppID
            // 
            this.lblReAppID.AutoSize = true;
            this.lblReAppID.BackColor = System.Drawing.Color.Transparent;
            this.lblReAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReAppID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReAppID.Location = new System.Drawing.Point(240, 219);
            this.lblReAppID.Name = "lblReAppID";
            this.lblReAppID.Size = new System.Drawing.Size(40, 22);
            this.lblReAppID.TabIndex = 1;
            this.lblReAppID.Text = "[??]";
            // 
            // lblReleasseDate
            // 
            this.lblReleasseDate.AutoSize = true;
            this.lblReleasseDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReleasseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleasseDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReleasseDate.Location = new System.Drawing.Point(587, 136);
            this.lblReleasseDate.Name = "lblReleasseDate";
            this.lblReleasseDate.Size = new System.Drawing.Size(41, 22);
            this.lblReleasseDate.TabIndex = 1;
            this.lblReleasseDate.Text = "[??}";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDetainDate.Location = new System.Drawing.Point(587, 54);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(41, 22);
            this.lblDetainDate.TabIndex = 1;
            this.lblDetainDate.Text = "[??}";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalFees.Location = new System.Drawing.Point(587, 386);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(41, 22);
            this.lblTotalFees.TabIndex = 1;
            this.lblTotalFees.Text = "[??}";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(342, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Release Date:         ";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.BackColor = System.Drawing.Color.Transparent;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAppFees.Location = new System.Drawing.Point(587, 300);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(41, 22);
            this.lblAppFees.TabIndex = 1;
            this.lblAppFees.Text = "[??}";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(342, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Detained Date:        ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Image = global::DVLD_Interface.Properties.Resources.money_32;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Location = new System.Drawing.Point(342, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(228, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Application Fees:        ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Image = global::DVLD_Interface.Properties.Resources.Number_32;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Location = new System.Drawing.Point(12, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(205, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "App ID:                    ";
            // 
            // lblDetaineID
            // 
            this.lblDetaineID.AutoSize = true;
            this.lblDetaineID.BackColor = System.Drawing.Color.Transparent;
            this.lblDetaineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetaineID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDetaineID.Location = new System.Drawing.Point(240, 55);
            this.lblDetaineID.Name = "lblDetaineID";
            this.lblDetaineID.Size = new System.Drawing.Size(40, 22);
            this.lblDetaineID.TabIndex = 1;
            this.lblDetaineID.Text = "[??]";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLicenseID.Location = new System.Drawing.Point(240, 139);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(41, 22);
            this.lblLicenseID.TabIndex = 1;
            this.lblLicenseID.Text = "[??}";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(9, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "License ID:              ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Image = global::DVLD_Interface.Properties.Resources.Number_32;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Location = new System.Drawing.Point(12, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(204, 25);
            this.label19.TabIndex = 1;
            this.label19.Text = "Detained ID:            ";
            // 
            // btnShowNewLicenseInfo
            // 
            this.btnShowNewLicenseInfo.Enabled = false;
            this.btnShowNewLicenseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNewLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnShowNewLicenseInfo.ForeColor = System.Drawing.Color.Snow;
            this.btnShowNewLicenseInfo.Image = global::DVLD_Interface.Properties.Resources.refresh;
            this.btnShowNewLicenseInfo.Location = new System.Drawing.Point(261, 595);
            this.btnShowNewLicenseInfo.Name = "btnShowNewLicenseInfo";
            this.btnShowNewLicenseInfo.Size = new System.Drawing.Size(193, 51);
            this.btnShowNewLicenseInfo.TabIndex = 7;
            this.btnShowNewLicenseInfo.Text = "ShowLicense Info";
            this.btnShowNewLicenseInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowNewLicenseInfo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSave.ForeColor = System.Drawing.Color.Snow;
            this.btnSave.Image = global::DVLD_Interface.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(513, 595);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 51);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "License View 32.png");
            this.imageList1.Images.SetKeyName(1, "Release Detained License 32.png");
            // 
            // ctrFindLicense1
            // 
            this.ctrFindLicense1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFindLicense1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrFindLicense1.Location = new System.Drawing.Point(3, 3);
            this.ctrFindLicense1.Name = "ctrFindLicense1";
            this.ctrFindLicense1.Size = new System.Drawing.Size(706, 584);
            this.ctrFindLicense1.TabIndex = 0;
            this.ctrFindLicense1.onLicenseFound += new System.Action<string>(this.ctrFindLicense1_onLicenseFound);
            // 
            // ctrReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ctrReleaseDetainedLicense";
            this.Size = new System.Drawing.Size(720, 680);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnShowLicenseHistory;
        private System.Windows.Forms.Button btnRelease;
        private ctrMISC.ctrFindLicense ctrFindLicense1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShowNewLicenseInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAppdate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReAppID;
        private System.Windows.Forms.Label lblReleasseDate;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDetaineID;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
    }
}
