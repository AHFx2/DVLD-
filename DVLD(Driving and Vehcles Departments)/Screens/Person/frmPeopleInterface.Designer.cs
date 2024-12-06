namespace DVLD_Interface.Screens
{
    partial class frmPeopleInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleInterface));
            this.dgvPeopleList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.como = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrFiltredList1 = new DVLD_Interface.Controls.ctrFiltredList();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeopleList
            // 
            this.dgvPeopleList.AllowUserToAddRows = false;
            this.dgvPeopleList.AllowUserToDeleteRows = false;
            this.dgvPeopleList.AllowUserToResizeColumns = false;
            this.dgvPeopleList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPeopleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeopleList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPeopleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPeopleList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPeopleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeopleList.ColumnHeadersHeight = 30;
            this.dgvPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPeopleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NationalNO,
            this.como,
            this.Gendor,
            this.Age,
            this.Email,
            this.Phone});
            this.dgvPeopleList.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeopleList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeopleList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPeopleList.EnableHeadersVisualStyles = false;
            this.dgvPeopleList.GridColor = System.Drawing.Color.Chartreuse;
            this.dgvPeopleList.Location = new System.Drawing.Point(0, 347);
            this.dgvPeopleList.Name = "dgvPeopleList";
            this.dgvPeopleList.ReadOnly = true;
            this.dgvPeopleList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeopleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeopleList.RowHeadersVisible = false;
            this.dgvPeopleList.RowHeadersWidth = 5;
            this.dgvPeopleList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPeopleList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvPeopleList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPeopleList.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvPeopleList.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvPeopleList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvPeopleList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPeopleList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeopleList.RowTemplate.Height = 30;
            this.dgvPeopleList.RowTemplate.ReadOnly = true;
            this.dgvPeopleList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeopleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeopleList.Size = new System.Drawing.Size(1062, 401);
            this.dgvPeopleList.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // NationalNO
            // 
            this.NationalNO.HeaderText = "NatID";
            this.NationalNO.MinimumWidth = 6;
            this.NationalNO.Name = "NationalNO";
            this.NationalNO.ReadOnly = true;
            this.NationalNO.Width = 70;
            // 
            // como
            // 
            this.como.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.como.HeaderText = "Name";
            this.como.MinimumWidth = 220;
            this.como.Name = "como";
            this.como.ReadOnly = true;
            this.como.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.como.ToolTipText = "ListsContacts";
            // 
            // Gendor
            // 
            this.Gendor.HeaderText = "Gendor";
            this.Gendor.MinimumWidth = 6;
            this.Gendor.Name = "Gendor";
            this.Gendor.ReadOnly = true;
            this.Gendor.Width = 80;
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 75;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 187;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 187;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 95;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.addNewPersonToolStripMenuItem,
            this.updatePersonToolStripMenuItem,
            this.deletePersonToolStripMenuItem1,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem,
            this.callToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(204, 244);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.AddPerson_32;
            this.addNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // updatePersonToolStripMenuItem
            // 
            this.updatePersonToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.edit_32;
            this.updatePersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updatePersonToolStripMenuItem.Name = "updatePersonToolStripMenuItem";
            this.updatePersonToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.updatePersonToolStripMenuItem.Text = "Update Person";
            this.updatePersonToolStripMenuItem.Click += new System.EventHandler(this.updatePersonToolStripMenuItem_Click);
            // 
            // deletePersonToolStripMenuItem1
            // 
            this.deletePersonToolStripMenuItem1.Image = global::DVLD_Interface.Properties.Resources.Delete_32;
            this.deletePersonToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deletePersonToolStripMenuItem1.Name = "deletePersonToolStripMenuItem1";
            this.deletePersonToolStripMenuItem1.Size = new System.Drawing.Size(203, 38);
            this.deletePersonToolStripMenuItem1.Text = "Delete Person";
            this.deletePersonToolStripMenuItem1.Click += new System.EventHandler(this.deletePersonToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // callToolStripMenuItem
            // 
            this.callToolStripMenuItem.Image = global::DVLD_Interface.Properties.Resources.call_32;
            this.callToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.callToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.callToolStripMenuItem.Name = "callToolStripMenuItem";
            this.callToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.callToolStripMenuItem.Text = "Call";
            // 
            // ctrFiltredList1
            // 
            this.ctrFiltredList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrFiltredList1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFiltredList1.ForeColor = System.Drawing.Color.Snow;
            this.ctrFiltredList1.Item = "None";
            this.ctrFiltredList1.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrFiltredList1.Items")));
            this.ctrFiltredList1.Location = new System.Drawing.Point(3, 264);
            this.ctrFiltredList1.Name = "ctrFiltredList1";
            this.ctrFiltredList1.Size = new System.Drawing.Size(270, 77);
            this.ctrFiltredList1.TabIndex = 7;
            this.ctrFiltredList1.onTextChanged += new System.Action<string>(this.ctrFiltredList1_onTextChanged_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DVLD_Interface.Properties.Resources.People_400;
            this.pictureBox2.Location = new System.Drawing.Point(407, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(394, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 50);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mange People";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.Snow;
            this.btnAddUser.Image = global::DVLD_Interface.Properties.Resources.Add_Person_40;
            this.btnAddUser.Location = new System.Drawing.Point(996, 279);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(66, 64);
            this.btnAddUser.TabIndex = 19;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // frmPeopleInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 748);
            this.Controls.Add(this.dgvPeopleList);
            this.Controls.Add(this.ctrFiltredList1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPeopleInterface";
            this.Text = "frmPeopleInterface";
            this.Load += new System.EventHandler(this.frmPeopleInterface_Load);
            this.Shown += new System.EventHandler(this.frmPeopleInterface_Shown);
            this.Move += new System.EventHandler(this.frmPeopleInterface_Move);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.DataGridViewTextBoxColumn ID;
        protected System.Windows.Forms.DataGridViewTextBoxColumn NationalNO;
        protected System.Windows.Forms.DataGridViewTextBoxColumn como;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Gendor;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Age;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Email;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        protected System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        protected System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem updatePersonToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem1;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem callToolStripMenuItem;
        protected internal System.Windows.Forms.DataGridView dgvPeopleList;
        private Controls.ctrFiltredList ctrFiltredList1;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUser;
    }
}