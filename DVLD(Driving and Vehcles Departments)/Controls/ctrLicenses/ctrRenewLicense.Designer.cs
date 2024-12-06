namespace DVLD_Interface.Controls.ctrMISC
{
    partial class ctrRenewLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrRenewLicense));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnShowLicenseHistory = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.ctrFindLicense1 = new DVLD_Interface.Controls.ctrMISC.ctrFindLicense();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowNewLicenseInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRenewedLicenseID = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblReAppID = new System.Windows.Forms.Label();
            this.lblEpirtationDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbBox.SuspendLayout();
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
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Tomato;
            this.tabPage1.Controls.Add(this.btnShowLicenseHistory);
            this.tabPage1.Controls.Add(this.btnRenew);
            this.tabPage1.Controls.Add(this.ctrFindLicense1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find License";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.btnShowLicenseHistory.Click += new System.EventHandler(this.btnShowLicenseHistory_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Enabled = false;
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnRenew.ForeColor = System.Drawing.Color.Snow;
            this.btnRenew.Image = global::DVLD_Interface.Properties.Resources.refresh;
            this.btnRenew.Location = new System.Drawing.Point(554, 590);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(155, 56);
            this.btnRenew.TabIndex = 1;
            this.btnRenew.Text = "Renew License";
            this.btnRenew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
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
            this.ctrFindLicense1.Load += new System.EventHandler(this.ctrFindLicense1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tomato;
            this.tabPage2.Controls.Add(this.btnShowNewLicenseInfo);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.gbBox);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Renew License";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnShowNewLicenseInfo
            // 
            this.btnShowNewLicenseInfo.Enabled = false;
            this.btnShowNewLicenseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNewLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnShowNewLicenseInfo.ForeColor = System.Drawing.Color.Snow;
            this.btnShowNewLicenseInfo.Image = global::DVLD_Interface.Properties.Resources.refresh;
            this.btnShowNewLicenseInfo.Location = new System.Drawing.Point(261, 614);
            this.btnShowNewLicenseInfo.Name = "btnShowNewLicenseInfo";
            this.btnShowNewLicenseInfo.Size = new System.Drawing.Size(193, 32);
            this.btnShowNewLicenseInfo.TabIndex = 7;
            this.btnShowNewLicenseInfo.Text = "Show New License Info";
            this.btnShowNewLicenseInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowNewLicenseInfo.UseVisualStyleBackColor = true;
            this.btnShowNewLicenseInfo.Click += new System.EventHandler(this.btnShowNewLicenseInfo_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSave.ForeColor = System.Drawing.Color.Snow;
            this.btnSave.Image = global::DVLD_Interface.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(510, 614);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbBox
            // 
            this.gbBox.BorderRadius = 5;
            this.gbBox.Controls.Add(this.label1);
            this.gbBox.Controls.Add(this.txtNotes);
            this.gbBox.Controls.Add(this.lblTotalFees);
            this.gbBox.Controls.Add(this.label5);
            this.gbBox.Controls.Add(this.lblLicenseFees);
            this.gbBox.Controls.Add(this.label2);
            this.gbBox.Controls.Add(this.lblOldLicenseID);
            this.gbBox.Controls.Add(this.label3);
            this.gbBox.Controls.Add(this.lblUserName);
            this.gbBox.Controls.Add(this.lblRenewedLicenseID);
            this.gbBox.Controls.Add(this.label20);
            this.gbBox.Controls.Add(this.lblDate);
            this.gbBox.Controls.Add(this.label19);
            this.gbBox.Controls.Add(this.label18);
            this.gbBox.Controls.Add(this.lblReAppID);
            this.gbBox.Controls.Add(this.lblEpirtationDate);
            this.gbBox.Controls.Add(this.label13);
            this.gbBox.Controls.Add(this.lblIssueDate);
            this.gbBox.Controls.Add(this.label12);
            this.gbBox.Controls.Add(this.lblAppFees);
            this.gbBox.Controls.Add(this.label11);
            this.gbBox.Controls.Add(this.label8);
            this.gbBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBox.FillColor = System.Drawing.Color.Wheat;
            this.gbBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbBox.ForeColor = System.Drawing.Color.Snow;
            this.gbBox.Location = new System.Drawing.Point(3, 3);
            this.gbBox.Name = "gbBox";
            this.gbBox.ShadowDecoration.Parent = this.gbBox;
            this.gbBox.Size = new System.Drawing.Size(706, 611);
            this.gbBox.TabIndex = 5;
            this.gbBox.Text = "Interntaional Application Basic Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::DVLD_Interface.Properties.Resources.Notes_32;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Notes:       ";
            // 
            // txtNotes
            // 
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.Parent = this.txtNotes;
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.FocusedState.Parent = this.txtNotes;
            this.txtNotes.ForeColor = System.Drawing.Color.Snow;
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.HoverState.Parent = this.txtNotes;
            this.txtNotes.Location = new System.Drawing.Point(1, 553);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.ShadowDecoration.Parent = this.txtNotes;
            this.txtNotes.Size = new System.Drawing.Size(705, 58);
            this.txtNotes.TabIndex = 14;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalFees.Location = new System.Drawing.Point(253, 439);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(41, 22);
            this.lblTotalFees.TabIndex = 12;
            this.lblTotalFees.Text = "[??}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::DVLD_Interface.Properties.Resources.money_32;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(10, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Fees:                         ";
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLicenseFees.Location = new System.Drawing.Point(253, 391);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(41, 22);
            this.lblLicenseFees.TabIndex = 10;
            this.lblLicenseFees.Text = "[??}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::DVLD_Interface.Properties.Resources.money_32;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(10, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "License Fees:                     ";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOldLicenseID.Location = new System.Drawing.Point(253, 247);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(41, 22);
            this.lblOldLicenseID.TabIndex = 2;
            this.lblOldLicenseID.Text = "[??}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::DVLD_Interface.Properties.Resources.License_Type_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(10, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Old License ID:                   ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserName.Location = new System.Drawing.Point(253, 487);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 22);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "[??}";
            // 
            // lblRenewedLicenseID
            // 
            this.lblRenewedLicenseID.AutoSize = true;
            this.lblRenewedLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblRenewedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewedLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRenewedLicenseID.Location = new System.Drawing.Point(248, 295);
            this.lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            this.lblRenewedLicenseID.Size = new System.Drawing.Size(50, 22);
            this.lblRenewedLicenseID.TabIndex = 1;
            this.lblRenewedLicenseID.Text = "[???]";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Image = global::DVLD_Interface.Properties.Resources.User_32__2;
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(10, 487);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(228, 22);
            this.label20.TabIndex = 1;
            this.label20.Text = "Created By User:                ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(253, 103);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 22);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "[??}";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Image = global::DVLD_Interface.Properties.Resources.Renew_Driving_License_32;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Location = new System.Drawing.Point(10, 295);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(225, 22);
            this.label19.TabIndex = 1;
            this.label19.Text = "Renewed License ID:         ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(10, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(228, 22);
            this.label18.TabIndex = 1;
            this.label18.Text = "Date:                                   ";
            // 
            // lblReAppID
            // 
            this.lblReAppID.AutoSize = true;
            this.lblReAppID.BackColor = System.Drawing.Color.Transparent;
            this.lblReAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReAppID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReAppID.Location = new System.Drawing.Point(253, 55);
            this.lblReAppID.Name = "lblReAppID";
            this.lblReAppID.Size = new System.Drawing.Size(40, 22);
            this.lblReAppID.TabIndex = 1;
            this.lblReAppID.Text = "[??]";
            // 
            // lblEpirtationDate
            // 
            this.lblEpirtationDate.AutoSize = true;
            this.lblEpirtationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEpirtationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpirtationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEpirtationDate.Location = new System.Drawing.Point(253, 199);
            this.lblEpirtationDate.Name = "lblEpirtationDate";
            this.lblEpirtationDate.Size = new System.Drawing.Size(41, 22);
            this.lblEpirtationDate.TabIndex = 1;
            this.lblEpirtationDate.Text = "[??}";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(10, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 22);
            this.label13.TabIndex = 1;
            this.label13.Text = "Epirationa Date:                  ";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.BackColor = System.Drawing.Color.Transparent;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIssueDate.Location = new System.Drawing.Point(253, 151);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(41, 22);
            this.lblIssueDate.TabIndex = 1;
            this.lblIssueDate.Text = "[??}";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(10, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 22);
            this.label12.TabIndex = 1;
            this.label12.Text = "Issue Date:                          ";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.BackColor = System.Drawing.Color.Transparent;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAppFees.Location = new System.Drawing.Point(253, 343);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(41, 22);
            this.lblAppFees.TabIndex = 1;
            this.lblAppFees.Text = "[??}";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::DVLD_Interface.Properties.Resources.money_32;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(10, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Application Fees:               ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::DVLD_Interface.Properties.Resources.Number_32;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(10, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Re App ID:                          ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "License View 32.png");
            // 
            // ctrRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ctrRenewLicense";
            this.Size = new System.Drawing.Size(720, 680);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbBox.ResumeLayout(false);
            this.gbBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrFindLicense ctrFindLicense1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnShowLicenseHistory;
        private Guna.UI2.WinForms.Guna2GroupBox gbBox;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRenewedLicenseID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblReAppID;
        private System.Windows.Forms.Label lblEpirtationDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Button btnShowNewLicenseInfo;
    }
}
