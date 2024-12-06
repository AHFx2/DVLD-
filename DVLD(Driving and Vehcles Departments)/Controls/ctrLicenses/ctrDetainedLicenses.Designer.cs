namespace DVLD_Interface.Controls.ctrLicenses
{
    partial class ctrDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrDetainedLicenses));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctrFindLicense1 = new DVLD_Interface.Controls.ctrMISC.ctrFindLicense();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDetainedDate = new System.Windows.Forms.Label();
            this.lblDetainedID = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnShowLicenseHistory = new System.Windows.Forms.Button();
            this.btnDetained = new System.Windows.Forms.Button();
            this.btnShowNewLicenseInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFees = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Tomato;
            this.tabPage1.Controls.Add(this.btnShowLicenseHistory);
            this.tabPage1.Controls.Add(this.btnDetained);
            this.tabPage1.Controls.Add(this.ctrFindLicense1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find License";
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
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detain License";
            // 
            // gbBox
            // 
            this.gbBox.BorderRadius = 5;
            this.gbBox.Controls.Add(this.txtFees);
            this.gbBox.Controls.Add(this.label3);
            this.gbBox.Controls.Add(this.label1);
            this.gbBox.Controls.Add(this.txtNotes);
            this.gbBox.Controls.Add(this.lblUserName);
            this.gbBox.Controls.Add(this.label20);
            this.gbBox.Controls.Add(this.lblDetainedDate);
            this.gbBox.Controls.Add(this.label18);
            this.gbBox.Controls.Add(this.lblDetainedID);
            this.gbBox.Controls.Add(this.lblLicenseID);
            this.gbBox.Controls.Add(this.label12);
            this.gbBox.Controls.Add(this.label8);
            this.gbBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBox.FillColor = System.Drawing.Color.Wheat;
            this.gbBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbBox.ForeColor = System.Drawing.Color.Snow;
            this.gbBox.Location = new System.Drawing.Point(3, 3);
            this.gbBox.Name = "gbBox";
            this.gbBox.ShadowDecoration.Parent = this.gbBox;
            this.gbBox.Size = new System.Drawing.Size(706, 586);
            this.gbBox.TabIndex = 5;
            this.gbBox.Text = "Detain Information ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserName.Location = new System.Drawing.Point(258, 257);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 22);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "[??}";
            // 
            // lblDetainedDate
            // 
            this.lblDetainedDate.AutoSize = true;
            this.lblDetainedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDetainedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainedDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDetainedDate.Location = new System.Drawing.Point(258, 123);
            this.lblDetainedDate.Name = "lblDetainedDate";
            this.lblDetainedDate.Size = new System.Drawing.Size(41, 22);
            this.lblDetainedDate.TabIndex = 1;
            this.lblDetainedDate.Text = "[??}";
            // 
            // lblDetainedID
            // 
            this.lblDetainedID.AutoSize = true;
            this.lblDetainedID.BackColor = System.Drawing.Color.Transparent;
            this.lblDetainedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainedID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDetainedID.Location = new System.Drawing.Point(258, 56);
            this.lblDetainedID.Name = "lblDetainedID";
            this.lblDetainedID.Size = new System.Drawing.Size(40, 22);
            this.lblDetainedID.TabIndex = 1;
            this.lblDetainedID.Text = "[??]";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLicenseID.Location = new System.Drawing.Point(258, 190);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(41, 22);
            this.lblLicenseID.TabIndex = 1;
            this.lblLicenseID.Text = "[??}";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "License View 32.png");
            this.imageList1.Images.SetKeyName(1, "Detain 32.png");
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
            // btnDetained
            // 
            this.btnDetained.Enabled = false;
            this.btnDetained.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetained.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnDetained.ForeColor = System.Drawing.Color.Snow;
            this.btnDetained.Image = global::DVLD_Interface.Properties.Resources.Detain_32;
            this.btnDetained.Location = new System.Drawing.Point(554, 590);
            this.btnDetained.Name = "btnDetained";
            this.btnDetained.Size = new System.Drawing.Size(155, 56);
            this.btnDetained.TabIndex = 1;
            this.btnDetained.Text = "Detain License";
            this.btnDetained.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetained.UseVisualStyleBackColor = true;
            this.btnDetained.Click += new System.EventHandler(this.btnDetained_Click);
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
            this.btnShowNewLicenseInfo.Click += new System.EventHandler(this.btnShowNewLicenseInfo_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::DVLD_Interface.Properties.Resources.money_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(10, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fees:                         ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Image = global::DVLD_Interface.Properties.Resources.User_32__2;
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(10, 256);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(220, 25);
            this.label20.TabIndex = 1;
            this.label20.Text = "Created By User:       ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(10, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(222, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Detained Date:           ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(10, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "License ID:                 ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::DVLD_Interface.Properties.Resources.Number_32;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(10, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Detained ID:               ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::DVLD_Interface.Properties.Resources.Notes_32;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
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
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNotes.FillColor = System.Drawing.Color.Wheat;
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.FocusedState.Parent = this.txtNotes;
            this.txtNotes.ForeColor = System.Drawing.Color.Snow;
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.HoverState.Parent = this.txtNotes;
            this.txtNotes.Location = new System.Drawing.Point(0, 442);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.ShadowDecoration.Parent = this.txtNotes;
            this.txtNotes.Size = new System.Drawing.Size(706, 144);
            this.txtNotes.TabIndex = 14;
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.Color.Transparent;
            this.txtFees.BorderRadius = 10;
            this.txtFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFees.DefaultText = "";
            this.txtFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.DisabledState.Parent = this.txtFees;
            this.txtFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.FillColor = System.Drawing.Color.Wheat;
            this.txtFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFees.FocusedState.Parent = this.txtFees;
            this.txtFees.ForeColor = System.Drawing.Color.Snow;
            this.txtFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFees.HoverState.Parent = this.txtFees;
            this.txtFees.Location = new System.Drawing.Point(258, 303);
            this.txtFees.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtFees.Multiline = true;
            this.txtFees.Name = "txtFees";
            this.txtFees.PasswordChar = '\0';
            this.txtFees.PlaceholderText = "";
            this.txtFees.SelectedText = "";
            this.txtFees.ShadowDecoration.Parent = this.txtFees;
            this.txtFees.Size = new System.Drawing.Size(217, 51);
            this.txtFees.TabIndex = 18;
            // 
            // ctrDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ctrDetainedLicenses";
            this.Size = new System.Drawing.Size(720, 680);
            this.Load += new System.EventHandler(this.ctrDetainedLicenses_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbBox.ResumeLayout(false);
            this.gbBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnShowLicenseHistory;
        private System.Windows.Forms.Button btnDetained;
        private ctrMISC.ctrFindLicense ctrFindLicense1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShowNewLicenseInfo;
        private System.Windows.Forms.Button btnSave;
        private Guna.UI2.WinForms.Guna2GroupBox gbBox;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblDetainedDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblDetainedID;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtFees;
    }
}
