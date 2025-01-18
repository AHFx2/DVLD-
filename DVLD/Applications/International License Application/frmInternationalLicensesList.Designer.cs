namespace DVLD_Interface.Applications.International_License_Application
{
    partial class frmInternationalLicensesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternationalLicensesList));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInterntionalApp = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonDetailes = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseDetailes = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInternationalApplication = new Guna.UI2.WinForms.Guna2Button();
            this.ctrFiltredList1 = new DVLD_Interface.Controls.ctrFiltredList();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterntionalApp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DVLD_Interface.Properties.Resources.Manage_Applications_64;
            this.pictureBox2.Location = new System.Drawing.Point(418, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(271, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "International License Applications";
            // 
            // dgvInterntionalApp
            // 
            this.dgvInterntionalApp.AllowUserToAddRows = false;
            this.dgvInterntionalApp.AllowUserToDeleteRows = false;
            this.dgvInterntionalApp.AllowUserToResizeColumns = false;
            this.dgvInterntionalApp.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInterntionalApp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInterntionalApp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInterntionalApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInterntionalApp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvInterntionalApp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterntionalApp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInterntionalApp.ColumnHeadersHeight = 40;
            this.dgvInterntionalApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInterntionalApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column2,
            this.NatID,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterntionalApp.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInterntionalApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInterntionalApp.EnableHeadersVisualStyles = false;
            this.dgvInterntionalApp.GridColor = System.Drawing.Color.Chartreuse;
            this.dgvInterntionalApp.Location = new System.Drawing.Point(0, 460);
            this.dgvInterntionalApp.Name = "dgvInterntionalApp";
            this.dgvInterntionalApp.ReadOnly = true;
            this.dgvInterntionalApp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterntionalApp.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInterntionalApp.RowHeadersVisible = false;
            this.dgvInterntionalApp.RowHeadersWidth = 5;
            this.dgvInterntionalApp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterntionalApp.RowTemplate.Height = 35;
            this.dgvInterntionalApp.RowTemplate.ReadOnly = true;
            this.dgvInterntionalApp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInterntionalApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterntionalApp.Size = new System.Drawing.Size(1062, 288);
            this.dgvInterntionalApp.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonDetailes,
            this.ShowLicenseDetailes,
            this.ShowLicenseHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 118);
            // 
            // ShowPersonDetailes
            // 
            this.ShowPersonDetailes.Image = global::DVLD_Interface.Properties.Resources.PersonDetails_32;
            this.ShowPersonDetailes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonDetailes.Name = "ShowPersonDetailes";
            this.ShowPersonDetailes.Size = new System.Drawing.Size(240, 38);
            this.ShowPersonDetailes.Text = "Show Person Detailes";
            this.ShowPersonDetailes.Click += new System.EventHandler(this.ShowPersonDetailes_Click);
            // 
            // ShowLicenseDetailes
            // 
            this.ShowLicenseDetailes.Image = global::DVLD_Interface.Properties.Resources.LocalDriving_License;
            this.ShowLicenseDetailes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseDetailes.Name = "ShowLicenseDetailes";
            this.ShowLicenseDetailes.Size = new System.Drawing.Size(240, 38);
            this.ShowLicenseDetailes.Text = "Show License Detailes";
            this.ShowLicenseDetailes.Click += new System.EventHandler(this.ShowLicenseDetailes_Click);
            // 
            // ShowLicenseHistory
            // 
            this.ShowLicenseHistory.Image = global::DVLD_Interface.Properties.Resources.PersonLicenseHistory_32;
            this.ShowLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseHistory.Name = "ShowLicenseHistory";
            this.ShowLicenseHistory.Size = new System.Drawing.Size(240, 38);
            this.ShowLicenseHistory.Text = "Show License History";
            this.ShowLicenseHistory.Click += new System.EventHandler(this.ShowLicenseHistory_Click);
            // 
            // btnInternationalApplication
            // 
            this.btnInternationalApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInternationalApplication.BorderRadius = 10;
            this.btnInternationalApplication.CheckedState.Parent = this.btnInternationalApplication;
            this.btnInternationalApplication.CustomImages.Parent = this.btnInternationalApplication;
            this.btnInternationalApplication.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.btnInternationalApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInternationalApplication.ForeColor = System.Drawing.Color.White;
            this.btnInternationalApplication.HoverState.Parent = this.btnInternationalApplication;
            this.btnInternationalApplication.Image = global::DVLD_Interface.Properties.Resources.New_Application_64;
            this.btnInternationalApplication.ImageSize = new System.Drawing.Size(40, 40);
            this.btnInternationalApplication.Location = new System.Drawing.Point(994, 390);
            this.btnInternationalApplication.Name = "btnInternationalApplication";
            this.btnInternationalApplication.ShadowDecoration.Parent = this.btnInternationalApplication;
            this.btnInternationalApplication.Size = new System.Drawing.Size(66, 64);
            this.btnInternationalApplication.TabIndex = 23;
            // 
            // ctrFiltredList1
            // 
            this.ctrFiltredList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrFiltredList1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFiltredList1.ForeColor = System.Drawing.Color.Snow;
            this.ctrFiltredList1.Item = "None";
            this.ctrFiltredList1.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrFiltredList1.Items")));
            this.ctrFiltredList1.Location = new System.Drawing.Point(0, 377);
            this.ctrFiltredList1.Name = "ctrFiltredList1";
            this.ctrFiltredList1.Size = new System.Drawing.Size(270, 77);
            this.ctrFiltredList1.TabIndex = 19;
            this.ctrFiltredList1.TextBoxVisible = false;
            this.ctrFiltredList1.onTextChanged += new System.Action<string>(this.ctrFiltredList1_onTextChanged);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.FillWeight = 243.2929F;
            this.Column7.HeaderText = "International Licenses ID";
            this.Column7.MinimumWidth = 235;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 80.6707F;
            this.Column2.HeaderText = "Application ID";
            this.Column2.MinimumWidth = 145;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // NatID
            // 
            this.NatID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NatID.FillWeight = 21.40866F;
            this.NatID.HeaderText = "DriverID";
            this.NatID.MinimumWidth = 100;
            this.NatID.Name = "NatID";
            this.NatID.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 9.976184F;
            this.Column3.HeaderText = "LicenseID";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 5.606599F;
            this.Column4.HeaderText = "Issue Date ";
            this.Column4.MinimumWidth = 250;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 2.146479F;
            this.Column5.HeaderText = "Epiration Date";
            this.Column5.MinimumWidth = 250;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 336.8983F;
            this.Column6.HeaderText = "Is Active";
            this.Column6.MinimumWidth = 115;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 115;
            // 
            // frmInternationalLicensesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 748);
            this.Controls.Add(this.btnInternationalApplication);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrFiltredList1);
            this.Controls.Add(this.dgvInterntionalApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInternationalLicensesList";
            this.Text = "International Licenses List";
            this.Load += new System.EventHandler(this.frmInternationalLicensesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterntionalApp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private DVLD_Interface.Controls.ctrFiltredList ctrFiltredList1;
        protected internal System.Windows.Forms.DataGridView dgvInterntionalApp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetailes;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseDetailes;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseHistory;
        private Guna.UI2.WinForms.Guna2Button btnInternationalApplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
    }
}