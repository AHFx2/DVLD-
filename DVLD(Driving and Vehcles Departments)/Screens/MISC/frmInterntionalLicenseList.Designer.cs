namespace DVLD_Interface.Screens.MISC
{
    partial class frmInterntionalLicenseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterntionalLicenseList));
            this.dgvInterntionalApp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonDetailes = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseDetailes = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrFiltredList1 = new DVLD_Interface.Controls.ctrFiltredList();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterntionalApp)).BeginInit();
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
            this.guna2CustomGradientPanel1.Controls.Add(this.dgvInterntionalApp);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1305, 651);
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.pExit, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.dgvInterntionalApp, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.ctrFiltredList1, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.label1, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.pictureBox2, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.btnAdd, 0);
            // 
            // dgvInterntionalApp
            // 
            this.dgvInterntionalApp.AllowUserToAddRows = false;
            this.dgvInterntionalApp.AllowUserToDeleteRows = false;
            this.dgvInterntionalApp.AllowUserToResizeColumns = false;
            this.dgvInterntionalApp.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInterntionalApp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInterntionalApp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInterntionalApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInterntionalApp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvInterntionalApp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterntionalApp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInterntionalApp.ColumnHeadersHeight = 30;
            this.dgvInterntionalApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInterntionalApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.NatID,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvInterntionalApp.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterntionalApp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInterntionalApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInterntionalApp.EnableHeadersVisualStyles = false;
            this.dgvInterntionalApp.GridColor = System.Drawing.Color.Chartreuse;
            this.dgvInterntionalApp.Location = new System.Drawing.Point(0, 318);
            this.dgvInterntionalApp.Name = "dgvInterntionalApp";
            this.dgvInterntionalApp.ReadOnly = true;
            this.dgvInterntionalApp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterntionalApp.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInterntionalApp.RowHeadersVisible = false;
            this.dgvInterntionalApp.RowHeadersWidth = 5;
            this.dgvInterntionalApp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvInterntionalApp.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterntionalApp.RowTemplate.Height = 30;
            this.dgvInterntionalApp.RowTemplate.ReadOnly = true;
            this.dgvInterntionalApp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInterntionalApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterntionalApp.Size = new System.Drawing.Size(1305, 333);
            this.dgvInterntionalApp.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "National License";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Application ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // NatID
            // 
            this.NatID.HeaderText = "DriverID";
            this.NatID.MinimumWidth = 6;
            this.NatID.Name = "NatID";
            this.NatID.ReadOnly = true;
            this.NatID.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "LicenseID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Issue Date ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 220;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Epiration Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 220;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Is Active";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 90;
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::DVLD_Interface.Properties.Resources.New_Application_64;
            this.btnAdd.Location = new System.Drawing.Point(1223, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 64);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DVLD_Interface.Properties.Resources.Manage_Applications_64;
            this.pictureBox2.Location = new System.Drawing.Point(514, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(373, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "International License Applications";
            // 
            // ctrFiltredList1
            // 
            this.ctrFiltredList1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFiltredList1.ForeColor = System.Drawing.Color.Snow;
            this.ctrFiltredList1.Item = "None";
            this.ctrFiltredList1.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrFiltredList1.Items")));
            this.ctrFiltredList1.Location = new System.Drawing.Point(6, 231);
            this.ctrFiltredList1.Name = "ctrFiltredList1";
            this.ctrFiltredList1.Size = new System.Drawing.Size(270, 77);
            this.ctrFiltredList1.TabIndex = 14;
            this.ctrFiltredList1.onTextChanged += new System.Action<string>(this.ctrFiltredList1_onTextChanged);
            // 
            // frmInterntionalLicenseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 651);
            this.Name = "frmInterntionalLicenseList";
            this.Text = "frmInterntionalLicenseList";
            this.Load += new System.EventHandler(this.frmInterntionalLicenseList_Load);
            this.Shown += new System.EventHandler(this.frmInterntionalLicenseList_Shown);
            this.Controls.SetChildIndex(this.guna2CustomGradientPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterntionalApp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dgvInterntionalApp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Controls.ctrFiltredList ctrFiltredList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetailes;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseDetailes;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
    }
}