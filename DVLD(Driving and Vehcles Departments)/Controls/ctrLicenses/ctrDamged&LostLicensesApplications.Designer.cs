namespace DVLD_Interface.Controls.ctrMISC
{
    partial class ctrDamged_LostLicensesApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrDamged_LostLicensesApplications));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTitlte = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLostApp = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rbDamgedApp = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnShowLicenseHistory = new System.Windows.Forms.Button();
            this.ctrFindLicense2 = new DVLD_Interface.Controls.ctrMISC.ctrFindLicense();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnShowLicenseInfo = new System.Windows.Forms.Button();
            this.gbBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblNewLicense = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ImageList = this.imageList1;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(720, 762);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Violet;
            this.tabPage3.Controls.Add(this.lblTitlte);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.btnNext);
            this.tabPage3.Controls.Add(this.btnShowLicenseHistory);
            this.tabPage3.Controls.Add(this.ctrFindLicense2);
            this.tabPage3.ImageIndex = 0;
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(712, 731);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Find License";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // lblTitlte
            // 
            this.lblTitlte.AutoSize = true;
            this.lblTitlte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.lblTitlte.ForeColor = System.Drawing.Color.Snow;
            this.lblTitlte.Location = new System.Drawing.Point(135, 17);
            this.lblTitlte.Name = "lblTitlte";
            this.lblTitlte.Size = new System.Drawing.Size(443, 42);
            this.lblTitlte.TabIndex = 14;
            this.lblTitlte.Text = "Replace For Lost License";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLostApp);
            this.groupBox1.Controls.Add(this.rbDamgedApp);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(492, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 82);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application For";
            // 
            // rbLostApp
            // 
            this.rbLostApp.AutoSize = true;
            this.rbLostApp.Checked = true;
            this.rbLostApp.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rbLostApp.ImageKey = "Lost Driving License 32.png";
            this.rbLostApp.ImageList = this.imageList1;
            this.rbLostApp.Location = new System.Drawing.Point(9, 52);
            this.rbLostApp.Name = "rbLostApp";
            this.rbLostApp.Size = new System.Drawing.Size(119, 21);
            this.rbLostApp.TabIndex = 12;
            this.rbLostApp.TabStop = true;
            this.rbLostApp.Text = "Lost License";
            this.rbLostApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbLostApp.UseVisualStyleBackColor = true;
            this.rbLostApp.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "License View 32.png");
            this.imageList1.Images.SetKeyName(1, "License View 32.png");
            this.imageList1.Images.SetKeyName(2, "Renew Driving License 32.png");
            this.imageList1.Images.SetKeyName(3, "Damaged Driving License 32.png");
            this.imageList1.Images.SetKeyName(4, "Lost Driving License 32.png");
            // 
            // rbDamgedApp
            // 
            this.rbDamgedApp.AutoSize = true;
            this.rbDamgedApp.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rbDamgedApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbDamgedApp.ImageKey = "Damaged Driving License 32.png";
            this.rbDamgedApp.ImageList = this.imageList1;
            this.rbDamgedApp.Location = new System.Drawing.Point(9, 21);
            this.rbDamgedApp.Name = "rbDamgedApp";
            this.rbDamgedApp.Size = new System.Drawing.Size(152, 21);
            this.rbDamgedApp.TabIndex = 11;
            this.rbDamgedApp.Text = "Damaged License";
            this.rbDamgedApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbDamgedApp.UseVisualStyleBackColor = true;
            this.rbDamgedApp.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::DVLD_Interface.Properties.Resources.icons8_next_30;
            this.btnNext.Location = new System.Drawing.Point(512, 688);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(194, 40);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnShowLicenseHistory
            // 
            this.btnShowLicenseHistory.Enabled = false;
            this.btnShowLicenseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLicenseHistory.Location = new System.Drawing.Point(6, 688);
            this.btnShowLicenseHistory.Name = "btnShowLicenseHistory";
            this.btnShowLicenseHistory.Size = new System.Drawing.Size(194, 40);
            this.btnShowLicenseHistory.TabIndex = 10;
            this.btnShowLicenseHistory.Text = "Show License History";
            this.btnShowLicenseHistory.UseVisualStyleBackColor = true;
            this.btnShowLicenseHistory.Click += new System.EventHandler(this.btnShowLicenseHistory_Click);
            // 
            // ctrFindLicense2
            // 
            this.ctrFindLicense2.BackColor = System.Drawing.Color.Transparent;
            this.ctrFindLicense2.Location = new System.Drawing.Point(3, 88);
            this.ctrFindLicense2.Name = "ctrFindLicense2";
            this.ctrFindLicense2.Size = new System.Drawing.Size(706, 584);
            this.ctrFindLicense2.TabIndex = 6;
            this.ctrFindLicense2.onLicenseFound += new System.Action<string>(this.ctrFindLicense2_onLicenseFound);
            this.ctrFindLicense2.Load += new System.EventHandler(this.ctrFindLicense2_Load);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Tomato;
            this.tabPage4.Controls.Add(this.btnShowLicenseInfo);
            this.tabPage4.Controls.Add(this.gbBox);
            this.tabPage4.Controls.Add(this.btnSave);
            this.tabPage4.ImageIndex = 0;
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(712, 731);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Application Info";
            // 
            // btnShowLicenseInfo
            // 
            this.btnShowLicenseInfo.Enabled = false;
            this.btnShowLicenseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLicenseInfo.ForeColor = System.Drawing.Color.Snow;
            this.btnShowLicenseInfo.Location = new System.Drawing.Point(430, 585);
            this.btnShowLicenseInfo.Name = "btnShowLicenseInfo";
            this.btnShowLicenseInfo.Size = new System.Drawing.Size(110, 58);
            this.btnShowLicenseInfo.TabIndex = 8;
            this.btnShowLicenseInfo.Text = "Show License Info";
            this.btnShowLicenseInfo.UseVisualStyleBackColor = true;
            // 
            // gbBox
            // 
            this.gbBox.BorderRadius = 5;
            this.gbBox.Controls.Add(this.lblNewLicense);
            this.gbBox.Controls.Add(this.lblOldLicenseID);
            this.gbBox.Controls.Add(this.label1);
            this.gbBox.Controls.Add(this.label3);
            this.gbBox.Controls.Add(this.lblUserName);
            this.gbBox.Controls.Add(this.label20);
            this.gbBox.Controls.Add(this.lblDate);
            this.gbBox.Controls.Add(this.label18);
            this.gbBox.Controls.Add(this.lblAppID);
            this.gbBox.Controls.Add(this.lblFees);
            this.gbBox.Controls.Add(this.label11);
            this.gbBox.Controls.Add(this.label8);
            this.gbBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbBox.Location = new System.Drawing.Point(3, 3);
            this.gbBox.Name = "gbBox";
            this.gbBox.ShadowDecoration.Parent = this.gbBox;
            this.gbBox.Size = new System.Drawing.Size(706, 451);
            this.gbBox.TabIndex = 4;
            this.gbBox.Text = "Interntaional Application Basic Info";
            // 
            // lblNewLicense
            // 
            this.lblNewLicense.AutoSize = true;
            this.lblNewLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblNewLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLicense.ForeColor = System.Drawing.Color.Snow;
            this.lblNewLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNewLicense.Location = new System.Drawing.Point(210, 313);
            this.lblNewLicense.Name = "lblNewLicense";
            this.lblNewLicense.Size = new System.Drawing.Size(41, 22);
            this.lblNewLicense.TabIndex = 2;
            this.lblNewLicense.Text = "[??}";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ForeColor = System.Drawing.Color.Snow;
            this.lblOldLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOldLicenseID.Location = new System.Drawing.Point(549, 317);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(41, 22);
            this.lblOldLicenseID.TabIndex = 2;
            this.lblOldLicenseID.Text = "[??}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Image = global::DVLD_Interface.Properties.Resources.License_Type_32;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(4, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "R License ID:               ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Image = global::DVLD_Interface.Properties.Resources.License_Type_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(353, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Old License ID:           ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Snow;
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserName.Location = new System.Drawing.Point(549, 410);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 22);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "[??}";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Snow;
            this.label20.Image = global::DVLD_Interface.Properties.Resources.User_32__2;
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(353, 409);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(191, 25);
            this.label20.TabIndex = 1;
            this.label20.Text = "Created By User:          ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Snow;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(210, 221);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 22);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "[??}";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Snow;
            this.label18.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(4, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(187, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "App Date:                   ";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.BackColor = System.Drawing.Color.Transparent;
            this.lblAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppID.ForeColor = System.Drawing.Color.Snow;
            this.lblAppID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAppID.Location = new System.Drawing.Point(549, 224);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(40, 22);
            this.lblAppID.TabIndex = 1;
            this.lblAppID.Text = "[??]";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.Snow;
            this.lblFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFees.Location = new System.Drawing.Point(210, 405);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(41, 22);
            this.lblFees.TabIndex = 1;
            this.lblFees.Text = "[??}";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Image = global::DVLD_Interface.Properties.Resources.money_32;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(4, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Application Fees:         ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Image = global::DVLD_Interface.Properties.Resources.Number_32;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(353, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "L R app ID:                 ";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Snow;
            this.btnSave.Image = global::DVLD_Interface.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(594, 585);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 58);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrDamged_LostLicensesApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl2);
            this.Name = "ctrDamged_LostLicensesApplications";
            this.Size = new System.Drawing.Size(720, 762);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.gbBox.ResumeLayout(false);
            this.gbBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnShowLicenseHistory;
        private ctrFindLicense ctrFindLicense2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnShowLicenseInfo;
        private Guna.UI2.WinForms.Guna2GroupBox gbBox;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLostApp;
        private System.Windows.Forms.RadioButton rbDamgedApp;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblNewLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitlte;
    }
}
