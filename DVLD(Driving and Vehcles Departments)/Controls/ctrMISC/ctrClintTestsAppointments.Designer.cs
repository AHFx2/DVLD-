namespace DVLD_Interface.Controls.ctrMISC
{
    partial class ctrClintTestsAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pAppointmestsList = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvAppointMents = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrLDLAppInfo1 = new DVLD_Interface.Controls.ctrMISC.ctrLDLAppInfo();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddAppoi = new Guna.UI2.WinForms.Guna2Button();
            this.pIcon = new System.Windows.Forms.PictureBox();
            this.pAppointmestsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointMents)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pAppointmestsList
            // 
            this.pAppointmestsList.BackColor = System.Drawing.Color.Transparent;
            this.pAppointmestsList.Controls.Add(this.dgvAppointMents);
            this.pAppointmestsList.Location = new System.Drawing.Point(706, 0);
            this.pAppointmestsList.Name = "pAppointmestsList";
            this.pAppointmestsList.ShadowDecoration.Parent = this.pAppointmestsList;
            this.pAppointmestsList.Size = new System.Drawing.Size(497, 526);
            this.pAppointmestsList.TabIndex = 13;
            // 
            // dgvAppointMents
            // 
            this.dgvAppointMents.AllowUserToAddRows = false;
            this.dgvAppointMents.AllowUserToDeleteRows = false;
            this.dgvAppointMents.AllowUserToResizeColumns = false;
            this.dgvAppointMents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAppointMents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointMents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAppointMents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointMents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAppointMents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointMents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointMents.ColumnHeadersHeight = 30;
            this.dgvAppointMents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppointMents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvAppointMents.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointMents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointMents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointMents.EnableHeadersVisualStyles = false;
            this.dgvAppointMents.GridColor = System.Drawing.Color.Chartreuse;
            this.dgvAppointMents.Location = new System.Drawing.Point(0, 0);
            this.dgvAppointMents.Name = "dgvAppointMents";
            this.dgvAppointMents.ReadOnly = true;
            this.dgvAppointMents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointMents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointMents.RowHeadersVisible = false;
            this.dgvAppointMents.RowHeadersWidth = 5;
            this.dgvAppointMents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppointMents.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvAppointMents.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointMents.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvAppointMents.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvAppointMents.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvAppointMents.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAppointMents.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointMents.RowTemplate.Height = 30;
            this.dgvAppointMents.RowTemplate.ReadOnly = true;
            this.dgvAppointMents.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointMents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointMents.Size = new System.Drawing.Size(497, 526);
            this.dgvAppointMents.TabIndex = 12;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ApptID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ApptDate";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fees";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "IsLocked";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 80);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(153, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.test;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(153, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.ctrLDLAppInfo1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 526);
            this.panel1.TabIndex = 14;
            // 
            // ctrLDLAppInfo1
            // 
            this.ctrLDLAppInfo1.BackColor = System.Drawing.Color.Transparent;
            this.ctrLDLAppInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrLDLAppInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrLDLAppInfo1.Name = "ctrLDLAppInfo1";
            this.ctrLDLAppInfo1.Size = new System.Drawing.Size(697, 526);
            this.ctrLDLAppInfo1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.pAppointmestsList);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 234);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1201, 529);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(387, 180);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(433, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Vesion Test Appoitments";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.btnAddAppoi);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.Controls.Add(this.pIcon);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1201, 234);
            this.guna2Panel1.TabIndex = 12;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnAddAppoi
            // 
            this.btnAddAppoi.BorderRadius = 10;
            this.btnAddAppoi.CheckedState.Parent = this.btnAddAppoi;
            this.btnAddAppoi.CustomImages.Parent = this.btnAddAppoi;
            this.btnAddAppoi.FillColor = System.Drawing.Color.Transparent;
            this.btnAddAppoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddAppoi.ForeColor = System.Drawing.Color.White;
            this.btnAddAppoi.HoverState.Parent = this.btnAddAppoi;
            this.btnAddAppoi.Image = global::DVLD_Interface.Properties.Resources.AddAppointment_32;
            this.btnAddAppoi.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddAppoi.Location = new System.Drawing.Point(1135, 180);
            this.btnAddAppoi.Name = "btnAddAppoi";
            this.btnAddAppoi.ShadowDecoration.Parent = this.btnAddAppoi;
            this.btnAddAppoi.Size = new System.Drawing.Size(61, 51);
            this.btnAddAppoi.TabIndex = 14;
            this.btnAddAppoi.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pIcon
            // 
            this.pIcon.Image = global::DVLD_Interface.Properties.Resources.Vision_512;
            this.pIcon.Location = new System.Drawing.Point(469, 3);
            this.pIcon.Name = "pIcon";
            this.pIcon.Size = new System.Drawing.Size(264, 195);
            this.pIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pIcon.TabIndex = 1;
            this.pIcon.TabStop = false;
            // 
            // ctrClintTestsAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ctrClintTestsAppointments";
            this.Size = new System.Drawing.Size(1201, 763);
            this.pAppointmestsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointMents)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pAppointmestsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private ctrLDLAppInfo ctrLDLAppInfo1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnAddAppoi;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pIcon;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        protected internal System.Windows.Forms.DataGridView dgvAppointMents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
    }
}
