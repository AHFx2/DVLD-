namespace DVLD_Interface.Applications.Local_Drinving_License_Application
{
    partial class frmLocalDrvingLicenseApplicationsList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalDrvingLicenseApplicationsList));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLDLApp = new System.Windows.Forms.DataGridView();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripScheduleTests1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sechulVesionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechulWriteenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechulStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiIssueDrivignFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrFiltredList1 = new DVLD_Interface.Controls.ctrFiltredList();
            this.btnAddLocalApplication = new Guna.UI2.WinForms.Guna2Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApp)).BeginInit();
            this.cmsApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DVLD_Interface.Properties.Resources.Manage_Applications_64;
            this.pictureBox2.Location = new System.Drawing.Point(418, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(269, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Local Drivgin License Applications";
            // 
            // dgvLDLApp
            // 
            this.dgvLDLApp.AllowUserToAddRows = false;
            this.dgvLDLApp.AllowUserToDeleteRows = false;
            this.dgvLDLApp.AllowUserToResizeColumns = false;
            this.dgvLDLApp.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLDLApp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLDLApp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLDLApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLDLApp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvLDLApp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLDLApp.ColumnHeadersHeight = 40;
            this.dgvLDLApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLDLApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.NatID,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvLDLApp.ContextMenuStrip = this.cmsApplications;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLDLApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLDLApp.EnableHeadersVisualStyles = false;
            this.dgvLDLApp.GridColor = System.Drawing.Color.Chartreuse;
            this.dgvLDLApp.Location = new System.Drawing.Point(0, 415);
            this.dgvLDLApp.MultiSelect = false;
            this.dgvLDLApp.Name = "dgvLDLApp";
            this.dgvLDLApp.ReadOnly = true;
            this.dgvLDLApp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApp.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLDLApp.RowHeadersVisible = false;
            this.dgvLDLApp.RowHeadersWidth = 5;
            this.dgvLDLApp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApp.RowTemplate.Height = 35;
            this.dgvLDLApp.RowTemplate.ReadOnly = true;
            this.dgvLDLApp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLDLApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDLApp.Size = new System.Drawing.Size(1062, 333);
            this.dgvLDLApp.TabIndex = 14;
            // 
            // cmsApplications
            // 
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editAppToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripScheduleTests1,
            this.toolStripSeparator2,
            this.tsmiIssueDrivignFirstTime,
            this.toolStripSeparator3,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.Size = new System.Drawing.Size(309, 332);
            this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.showDetailsToolStripMenuItem.Text = "Show App Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(305, 6);
            // 
            // editAppToolStripMenuItem
            // 
            this.editAppToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.edit_32;
            this.editAppToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editAppToolStripMenuItem.Name = "editAppToolStripMenuItem";
            this.editAppToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.editAppToolStripMenuItem.Text = "Edit Application";
            this.editAppToolStripMenuItem.Click += new System.EventHandler(this.editAppToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Delete_32;
            this.cancelApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(305, 6);
            // 
            // toolStripScheduleTests1
            // 
            this.toolStripScheduleTests1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechulVesionTestToolStripMenuItem,
            this.sechulWriteenTestToolStripMenuItem,
            this.sechulStreetTestToolStripMenuItem});
            this.toolStripScheduleTests1.Image = global::DVLD_Interface.Properties.Resources.Schedule_Test_32;
            this.toolStripScheduleTests1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripScheduleTests1.Name = "toolStripScheduleTests1";
            this.toolStripScheduleTests1.Size = new System.Drawing.Size(308, 38);
            this.toolStripScheduleTests1.Text = "Schedule Tests";
            // 
            // sechulVesionTestToolStripMenuItem
            // 
            this.sechulVesionTestToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Vision_Test_32;
            this.sechulVesionTestToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sechulVesionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sechulVesionTestToolStripMenuItem.Name = "sechulVesionTestToolStripMenuItem";
            this.sechulVesionTestToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.sechulVesionTestToolStripMenuItem.Text = "Schedule Vesion Test";
            this.sechulVesionTestToolStripMenuItem.Click += new System.EventHandler(this.sechulVesionTestToolStripMenuItem_Click);
            // 
            // sechulWriteenTestToolStripMenuItem
            // 
            this.sechulWriteenTestToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Written_Test_32;
            this.sechulWriteenTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sechulWriteenTestToolStripMenuItem.Name = "sechulWriteenTestToolStripMenuItem";
            this.sechulWriteenTestToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.sechulWriteenTestToolStripMenuItem.Text = "Schedule Thory Test";
            this.sechulWriteenTestToolStripMenuItem.Click += new System.EventHandler(this.sechulWriteenTestToolStripMenuItem_Click);
            // 
            // sechulStreetTestToolStripMenuItem
            // 
            this.sechulStreetTestToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Street_Test_32;
            this.sechulStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sechulStreetTestToolStripMenuItem.Name = "sechulStreetTestToolStripMenuItem";
            this.sechulStreetTestToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.sechulStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.sechulStreetTestToolStripMenuItem.Click += new System.EventHandler(this.sechulStreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(305, 6);
            // 
            // tsmiIssueDrivignFirstTime
            // 
            this.tsmiIssueDrivignFirstTime.Image = global::DVLD_Interface.Properties.Resources.IssueDrivingLicense_32;
            this.tsmiIssueDrivignFirstTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiIssueDrivignFirstTime.Name = "tsmiIssueDrivignFirstTime";
            this.tsmiIssueDrivignFirstTime.Size = new System.Drawing.Size(308, 38);
            this.tsmiIssueDrivignFirstTime.Text = "Issue Driving Licesne (First Time)";
            this.tsmiIssueDrivignFirstTime.Click += new System.EventHandler(this.tsmiIssueDrivignFirstTime_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(305, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.showLicenseToolStripMenuItem.Text = "Show License ";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.PersonLicenseHistory_5121;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // ctrFiltredList1
            // 
            this.ctrFiltredList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrFiltredList1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFiltredList1.ForeColor = System.Drawing.Color.Snow;
            this.ctrFiltredList1.Item = "None";
            this.ctrFiltredList1.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrFiltredList1.Items")));
            this.ctrFiltredList1.Location = new System.Drawing.Point(0, 326);
            this.ctrFiltredList1.Name = "ctrFiltredList1";
            this.ctrFiltredList1.Size = new System.Drawing.Size(270, 77);
            this.ctrFiltredList1.TabIndex = 15;
            this.ctrFiltredList1.TextBoxVisible = false;
            this.ctrFiltredList1.onTextChanged += new System.Action<string>(this.ctrFiltredList1_onTextChanged_1);
            // 
            // btnAddLocalApplication
            // 
            this.btnAddLocalApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLocalApplication.BorderRadius = 10;
            this.btnAddLocalApplication.CheckedState.Parent = this.btnAddLocalApplication;
            this.btnAddLocalApplication.CustomImages.Parent = this.btnAddLocalApplication;
            this.btnAddLocalApplication.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.btnAddLocalApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddLocalApplication.ForeColor = System.Drawing.Color.White;
            this.btnAddLocalApplication.HoverState.Parent = this.btnAddLocalApplication;
            this.btnAddLocalApplication.Image = global::DVLD_Interface.Properties.Resources.New_Application_64;
            this.btnAddLocalApplication.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddLocalApplication.Location = new System.Drawing.Point(982, 339);
            this.btnAddLocalApplication.Name = "btnAddLocalApplication";
            this.btnAddLocalApplication.ShadowDecoration.Parent = this.btnAddLocalApplication;
            this.btnAddLocalApplication.Size = new System.Drawing.Size(66, 64);
            this.btnAddLocalApplication.TabIndex = 22;
            this.btnAddLocalApplication.Click += new System.EventHandler(this.btnAddLocalApplication_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "L.D.L AppID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Driving Class";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // NatID
            // 
            this.NatID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NatID.FillWeight = 60F;
            this.NatID.HeaderText = "NatID";
            this.NatID.MinimumWidth = 6;
            this.NatID.Name = "NatID";
            this.NatID.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 200F;
            this.Column3.HeaderText = "Full Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 70F;
            this.Column4.HeaderText = "App Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 75F;
            this.Column5.HeaderText = "Passed Tests";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 60F;
            this.Column6.HeaderText = "Status";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // frmLocalDrvingLicenseApplicationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 748);
            this.Controls.Add(this.btnAddLocalApplication);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLDLApp);
            this.Controls.Add(this.ctrFiltredList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocalDrvingLicenseApplicationsList";
            this.Text = "frmLocalDrvingLicenseApplicationsList";
            this.Load += new System.EventHandler(this.frmLocalDrvingLicenseApplicationsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApp)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.DataGridView dgvLDLApp;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripScheduleTests1;
        private System.Windows.Forms.ToolStripMenuItem sechulVesionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechulWriteenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechulStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiIssueDrivignFirstTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private DVLD_Interface.Controls.ctrFiltredList ctrFiltredList1;
        private Guna.UI2.WinForms.Guna2Button btnAddLocalApplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}