namespace DVLD_Interface.Applications.Release_Detain_Application
{
    partial class frmDetaindLicensesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaindLicensesList));
            this.dgvLDLApp = new System.Windows.Forms.DataGridView();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PesonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrFiltredList1 = new DVLD_Interface.Controls.ctrFiltredList();
            this.btnRelease = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetain = new Guna.UI2.WinForms.Guna2Button();
            this.NatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApp)).BeginInit();
            this.cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.dgvLDLApp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLDLApp.ColumnHeadersHeight = 40;
            this.dgvLDLApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLDLApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NatID,
            this.F,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
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
            this.dgvLDLApp.Location = new System.Drawing.Point(0, 314);
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
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgvLDLApp.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApp.RowTemplate.Height = 35;
            this.dgvLDLApp.RowTemplate.ReadOnly = true;
            this.dgvLDLApp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLDLApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDLApp.Size = new System.Drawing.Size(1287, 258);
            this.dgvLDLApp.TabIndex = 11;
            // 
            // cmsApplications
            // 
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PesonDetailsToolStripMenuItem,
            this.showDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.Size = new System.Drawing.Size(281, 162);
            this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
            // 
            // PesonDetailsToolStripMenuItem
            // 
            this.PesonDetailsToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.PersonDetails_32;
            this.PesonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PesonDetailsToolStripMenuItem.Name = "PesonDetailsToolStripMenuItem";
            this.PesonDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.PesonDetailsToolStripMenuItem.Text = "Show Person Details";
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.License_View_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showDetailsToolStripMenuItem.Text = "&Show License Details";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(277, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DVLD_Interface.Properties.Resources.Detain_512;
            this.pictureBox2.Location = new System.Drawing.Point(530, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(461, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mange Detain Licenses";
            // 
            // ctrFiltredList1
            // 
            this.ctrFiltredList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrFiltredList1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFiltredList1.ForeColor = System.Drawing.Color.Snow;
            this.ctrFiltredList1.Item = "None";
            this.ctrFiltredList1.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrFiltredList1.Items")));
            this.ctrFiltredList1.Location = new System.Drawing.Point(5, 231);
            this.ctrFiltredList1.Name = "ctrFiltredList1";
            this.ctrFiltredList1.Size = new System.Drawing.Size(270, 77);
            this.ctrFiltredList1.TabIndex = 18;
            this.ctrFiltredList1.TextBoxVisible = false;
            this.ctrFiltredList1.onTextChanged += new System.Action<string>(this.ctrFiltredList1_onTextChanged);
            // 
            // btnRelease
            // 
            this.btnRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelease.BorderRadius = 10;
            this.btnRelease.CheckedState.Parent = this.btnRelease;
            this.btnRelease.CustomImages.Parent = this.btnRelease;
            this.btnRelease.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.HoverState.Parent = this.btnRelease;
            this.btnRelease.Image = global::DVLD_Interface.Properties.Resources.Release_Detained_License_32;
            this.btnRelease.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRelease.Location = new System.Drawing.Point(1134, 246);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.ShadowDecoration.Parent = this.btnRelease;
            this.btnRelease.Size = new System.Drawing.Size(66, 64);
            this.btnRelease.TabIndex = 23;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetain.BorderRadius = 10;
            this.btnDetain.CheckedState.Parent = this.btnDetain;
            this.btnDetain.CustomImages.Parent = this.btnDetain;
            this.btnDetain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.btnDetain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetain.ForeColor = System.Drawing.Color.White;
            this.btnDetain.HoverState.Parent = this.btnDetain;
            this.btnDetain.Image = global::DVLD_Interface.Properties.Resources.Detain_32;
            this.btnDetain.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDetain.Location = new System.Drawing.Point(1214, 246);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.ShadowDecoration.Parent = this.btnDetain;
            this.btnDetain.Size = new System.Drawing.Size(66, 64);
            this.btnDetain.TabIndex = 25;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // NatID
            // 
            this.NatID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NatID.FillWeight = 77.41935F;
            this.NatID.HeaderText = "NatID";
            this.NatID.MinimumWidth = 6;
            this.NatID.Name = "NatID";
            this.NatID.ReadOnly = true;
            // 
            // F
            // 
            this.F.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F.FillWeight = 258.0645F;
            this.F.HeaderText = "Full Name";
            this.F.MinimumWidth = 250;
            this.F.Name = "F";
            this.F.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 77.41935F;
            this.Column1.HeaderText = "D. ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 77.41935F;
            this.Column2.HeaderText = "License ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 77.41935F;
            this.Column3.HeaderText = "D. Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 77.41935F;
            this.Column4.HeaderText = "Fine Fees";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 77.41935F;
            this.Column5.HeaderText = "Release app ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 77.41935F;
            this.Column6.HeaderText = "Release Date";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Is Released";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // frmDetaindLicensesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 572);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrFiltredList1);
            this.Controls.Add(this.dgvLDLApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetaindLicensesList";
            this.Text = "Detaind Licenses List";
            this.Load += new System.EventHandler(this.frmDetaindLicensesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApp)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dgvLDLApp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private DVLD_Interface.Controls.ctrFiltredList ctrFiltredList1;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem PesonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnRelease;
        private Guna.UI2.WinForms.Guna2Button btnDetain;
        private System.Windows.Forms.DataGridViewTextBoxColumn NatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
    }
}