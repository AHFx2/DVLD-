namespace DVLD_Interface.Controls.ctrMISC
{
    partial class ctrAddLocalLicenseApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrAddLocalLicenseApp));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PersonInfor = new System.Windows.Forms.TabPage();
            this.ctrFindPerson1 = new DVLD_Interface.Controls.Person.ctrFindPerson();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.comClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.PersonInfor.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonInfor);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 770);
            this.tabControl1.TabIndex = 0;
            // 
            // PersonInfor
            // 
            this.PersonInfor.BackColor = System.Drawing.Color.Tomato;
            this.PersonInfor.Controls.Add(this.ctrFindPerson1);
            this.PersonInfor.ImageKey = "PersonDetails 32.png";
            this.PersonInfor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PersonInfor.Location = new System.Drawing.Point(4, 39);
            this.PersonInfor.Name = "PersonInfor";
            this.PersonInfor.Padding = new System.Windows.Forms.Padding(3);
            this.PersonInfor.Size = new System.Drawing.Size(926, 727);
            this.PersonInfor.TabIndex = 0;
            this.PersonInfor.Text = "Person Infor";
            this.PersonInfor.Click += new System.EventHandler(this.PersonInfor_Click);
            // 
            // ctrFindPerson1
            // 
            this.ctrFindPerson1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFindPerson1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrFindPerson1.Item = null;
            this.ctrFindPerson1.Location = new System.Drawing.Point(3, 144);
            this.ctrFindPerson1.Name = "ctrFindPerson1";
            this.ctrFindPerson1.Size = new System.Drawing.Size(920, 580);
            this.ctrFindPerson1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tomato;
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.comClasses);
            this.tabPage2.Controls.Add(this.lblUser);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblFees);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblDate);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lblID);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.ImageKey = "Applications.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 727);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::DVLD_Interface.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(861, 664);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 57);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comClasses
            // 
            this.comClasses.BackColor = System.Drawing.Color.Transparent;
            this.comClasses.BorderRadius = 10;
            this.comClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comClasses.FocusedColor = System.Drawing.Color.Empty;
            this.comClasses.FocusedState.Parent = this.comClasses;
            this.comClasses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comClasses.ForeColor = System.Drawing.Color.Snow;
            this.comClasses.FormattingEnabled = true;
            this.comClasses.HoverState.Parent = this.comClasses;
            this.comClasses.ItemHeight = 30;
            this.comClasses.ItemsAppearance.Parent = this.comClasses;
            this.comClasses.Location = new System.Drawing.Point(379, 369);
            this.comClasses.Name = "comClasses";
            this.comClasses.ShadowDecoration.Parent = this.comClasses;
            this.comClasses.Size = new System.Drawing.Size(440, 36);
            this.comClasses.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblUser.ForeColor = System.Drawing.Color.Snow;
            this.lblUser.Location = new System.Drawing.Point(373, 517);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(139, 35);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Created By:";
            this.lblUser.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Image = global::DVLD_Interface.Properties.Resources.User_32__2;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(113, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Created By:                ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFees.ForeColor = System.Drawing.Color.Snow;
            this.lblFees.Location = new System.Drawing.Point(374, 454);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(202, 35);
            this.lblFees.TabIndex = 1;
            this.lblFees.Text = "Application Fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Image = global::DVLD_Interface.Properties.Resources.money_32___2;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(113, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "Application Fees:       ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Image = global::DVLD_Interface.Properties.Resources.License_Type_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(113, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "License Class:             ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDate.ForeColor = System.Drawing.Color.Snow;
            this.lblDate.Location = new System.Drawing.Point(373, 286);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(205, 35);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Application Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(113, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application Date:       ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblID.ForeColor = System.Drawing.Color.Snow;
            this.lblID.Location = new System.Drawing.Point(373, 215);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 35);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Image = global::DVLD_Interface.Properties.Resources.Number_32;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(113, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L Application ID:     ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "PersonDetails 32.png");
            this.imageList1.Images.SetKeyName(1, "Applications.png");
            // 
            // ctrAddLocalLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ctrAddLocalLicenseApp";
            this.Size = new System.Drawing.Size(934, 770);
            this.Load += new System.EventHandler(this.ctrAddLocalLicenseApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.PersonInfor.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersonInfor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblID;
        private Guna.UI2.WinForms.Guna2ComboBox comClasses;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Button btnSave;
        private Person.ctrFindPerson ctrFindPerson1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
