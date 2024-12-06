namespace DVLD_Interface.Screens.MISC
{
    partial class frmLocalLicenseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalLicenseList));
            this.dgvLDLApp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAppDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pExit
            // 
            this.pExit.Location = new System.Drawing.Point(1274, 3);
            this.pExit.Size = new System.Drawing.Size(31, 29);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnAdd);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.ctrFiltredList1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1305, 651);
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint_1);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.ctrFiltredList1, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.label1, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.pictureBox2, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.pExit, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.btnAdd, 0);
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
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLDLApp.ColumnHeadersHeight = 30;
            this.dgvLDLApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLDLApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.NatID,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvLDLApp.ContextMenuStrip = this.contextMenuStrip1;
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
            this.dgvLDLApp.Location = new System.Drawing.Point(0, 318);
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
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApp.RowTemplate.Height = 30;
            this.dgvLDLApp.RowTemplate.ReadOnly = true;
            this.dgvLDLApp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLDLApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDLApp.Size = new System.Drawing.Size(1305, 333);
            this.dgvLDLApp.TabIndex = 9;
            this.dgvLDLApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLDLApp_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "L.D.L AppID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Driving Class";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // NatID
            // 
            this.NatID.HeaderText = "NatID";
            this.NatID.MinimumWidth = 6;
            this.NatID.Name = "NatID";
            this.NatID.ReadOnly = true;
            this.NatID.Width = 85;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Full Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 350;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "App Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Passed Tests";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAppDetailsToolStripMenuItem,
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
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(309, 360);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // showAppDetailsToolStripMenuItem
            // 
            this.showAppDetailsToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.PersonDetails_32;
            this.showAppDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showAppDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showAppDetailsToolStripMenuItem.Name = "showAppDetailsToolStripMenuItem";
            this.showAppDetailsToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.showAppDetailsToolStripMenuItem.Text = "Show App Details";
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
            this.toolStripScheduleTests1.Enabled = false;
            this.toolStripScheduleTests1.Image = global::DVLD_Interface.Properties.Resources.Schedule_Test_32;
            this.toolStripScheduleTests1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripScheduleTests1.Name = "toolStripScheduleTests1";
            this.toolStripScheduleTests1.Size = new System.Drawing.Size(308, 38);
            this.toolStripScheduleTests1.Text = "Schedule Tests";
            this.toolStripScheduleTests1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sechulVesionTestToolStripMenuItem
            // 
            this.sechulVesionTestToolStripMenuItem.Enabled = false;
            this.sechulVesionTestToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Vision_512;
            this.sechulVesionTestToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sechulVesionTestToolStripMenuItem.Name = "sechulVesionTestToolStripMenuItem";
            this.sechulVesionTestToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.sechulVesionTestToolStripMenuItem.Text = "Schedule Vesion Test";
            this.sechulVesionTestToolStripMenuItem.Click += new System.EventHandler(this.sechulVesionTestToolStripMenuItem_Click);
            // 
            // sechulWriteenTestToolStripMenuItem
            // 
            this.sechulWriteenTestToolStripMenuItem.Enabled = false;
            this.sechulWriteenTestToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Written_Test_32;
            this.sechulWriteenTestToolStripMenuItem.Name = "sechulWriteenTestToolStripMenuItem";
            this.sechulWriteenTestToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.sechulWriteenTestToolStripMenuItem.Text = "Schedule Thory Test";
            this.sechulWriteenTestToolStripMenuItem.Click += new System.EventHandler(this.sechulToolStripMenuItem_Click);
            // 
            // sechulStreetTestToolStripMenuItem
            // 
            this.sechulStreetTestToolStripMenuItem.Enabled = false;
            this.sechulStreetTestToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Street_Test_32;
            this.sechulStreetTestToolStripMenuItem.Name = "sechulStreetTestToolStripMenuItem";
            this.sechulStreetTestToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
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
            this.tsmiIssueDrivignFirstTime.Enabled = false;
            this.tsmiIssueDrivignFirstTime.Image = global::DVLD_Interface.Properties.Resources.IssueDrivingLicense_32;
            this.tsmiIssueDrivignFirstTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiIssueDrivignFirstTime.Name = "tsmiIssueDrivignFirstTime";
            this.tsmiIssueDrivignFirstTime.Size = new System.Drawing.Size(308, 38);
            this.tsmiIssueDrivignFirstTime.Text = "Issue Driving Licesne (First Time)";
            this.tsmiIssueDrivignFirstTime.Click += new System.EventHandler(this.isToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(305, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.LicenseView_400;
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
            this.ctrFiltredList1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFiltredList1.ForeColor = System.Drawing.Color.Snow;
            this.ctrFiltredList1.Item = "None";
            this.ctrFiltredList1.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrFiltredList1.Items")));
            this.ctrFiltredList1.Location = new System.Drawing.Point(5, 236);
            this.ctrFiltredList1.Name = "ctrFiltredList1";
            this.ctrFiltredList1.Size = new System.Drawing.Size(270, 77);
            this.ctrFiltredList1.TabIndex = 10;
            this.ctrFiltredList1.onTextChanged += new System.Action<string>(this.ctrFiltredList1_onTextChanged);
            this.ctrFiltredList1.Load += new System.EventHandler(this.ctrFiltredList1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(376, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Local Drivgin License Applications";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DVLD_Interface.Properties.Resources.Manage_Applications_64;
            this.pictureBox2.Location = new System.Drawing.Point(517, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Snow;
            this.btnAdd.Image = global::DVLD_Interface.Properties.Resources.New_Application_64;
            this.btnAdd.Location = new System.Drawing.Point(1233, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 64);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmLocalLicenseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 651);
            this.Controls.Add(this.dgvLDLApp);
            this.Name = "frmLocalLicenseList";
            this.Text = "frmLocalLicenseList";
            this.Load += new System.EventHandler(this.frmLocalLicenseList_Load);
            this.Shown += new System.EventHandler(this.frmLocalLicenseList_Shown);
            this.Controls.SetChildIndex(this.guna2CustomGradientPanel1, 0);
            this.Controls.SetChildIndex(this.dgvLDLApp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dgvLDLApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Controls.ctrFiltredList ctrFiltredList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showAppDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripScheduleTests1;
        private System.Windows.Forms.ToolStripMenuItem sechulVesionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechulWriteenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechulStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiIssueDrivignFirstTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}