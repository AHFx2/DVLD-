namespace DVLD_Interface.Controls.ctrUser
{
    partial class ctrAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrAddUser));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrFindUser1 = new DVLD_Interface.Controls.Person.ctrFindPerson();
            this.tpLogininfo = new System.Windows.Forms.TabPage();
            this.btnnSave = new System.Windows.Forms.Button();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConvirmedPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl1.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpLogininfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPersonInfo);
            this.tabControl1.Controls.Add(this.tpLogininfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 768);
            this.tabControl1.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.ctrFindUser1);
            this.tpPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tpPersonInfo.ImageKey = "PersonDetails 32.png";
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(890, 739);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 10;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = global::DVLD_Interface.Properties.Resources.icons8_next_30;
            this.btnNext.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNext.Location = new System.Drawing.Point(828, 688);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(56, 45);
            this.btnNext.TabIndex = 16;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrFindUser1
            // 
            this.ctrFindUser1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFindUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrFindUser1.Item = null;
            this.ctrFindUser1.Location = new System.Drawing.Point(3, 3);
            this.ctrFindUser1.Name = "ctrFindUser1";
            this.ctrFindUser1.Size = new System.Drawing.Size(884, 733);
            this.ctrFindUser1.TabIndex = 17;
            // 
            // tpLogininfo
            // 
            this.tpLogininfo.BackColor = System.Drawing.Color.Tomato;
            this.tpLogininfo.Controls.Add(this.btnnSave);
            this.tpLogininfo.Controls.Add(this.chkIsActive);
            this.tpLogininfo.Controls.Add(this.label6);
            this.tpLogininfo.Controls.Add(this.lblID);
            this.tpLogininfo.Controls.Add(this.label4);
            this.tpLogininfo.Controls.Add(this.label3);
            this.tpLogininfo.Controls.Add(this.label2);
            this.tpLogininfo.Controls.Add(this.label1);
            this.tpLogininfo.Controls.Add(this.txtConvirmedPassword);
            this.tpLogininfo.Controls.Add(this.txtPassword);
            this.tpLogininfo.Controls.Add(this.txtUsername);
            this.tpLogininfo.ImageKey = "Applications.png";
            this.tpLogininfo.Location = new System.Drawing.Point(4, 25);
            this.tpLogininfo.Name = "tpLogininfo";
            this.tpLogininfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogininfo.Size = new System.Drawing.Size(890, 739);
            this.tpLogininfo.TabIndex = 1;
            this.tpLogininfo.Text = "Login Info";
            // 
            // btnnSave
            // 
            this.btnnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnSave.Image = global::DVLD_Interface.Properties.Resources.Save_32;
            this.btnnSave.Location = new System.Drawing.Point(836, 685);
            this.btnnSave.Name = "btnnSave";
            this.btnnSave.Size = new System.Drawing.Size(48, 48);
            this.btnnSave.TabIndex = 9;
            this.btnnSave.UseVisualStyleBackColor = true;
            this.btnnSave.Click += new System.EventHandler(this.btnnSave_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.BorderRadius = 2;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.Parent = this.chkIsActive;
            this.chkIsActive.Location = new System.Drawing.Point(488, 519);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.ShadowDecoration.Parent = this.chkIsActive;
            this.chkIsActive.Size = new System.Drawing.Size(20, 20);
            this.chkIsActive.TabIndex = 7;
            this.chkIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.BorderRadius = 2;
            this.chkIsActive.UncheckedState.BorderThickness = 0;
            this.chkIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.Parent = this.chkIsActive;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(393, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "IsActive";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblID.Location = new System.Drawing.Point(262, 163);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 26);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(50, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(50, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(50, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(50, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID";
            // 
            // txtConvirmedPassword
            // 
            this.txtConvirmedPassword.BorderRadius = 10;
            this.txtConvirmedPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConvirmedPassword.DefaultText = "";
            this.txtConvirmedPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConvirmedPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConvirmedPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConvirmedPassword.DisabledState.Parent = this.txtConvirmedPassword;
            this.txtConvirmedPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConvirmedPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConvirmedPassword.FocusedState.Parent = this.txtConvirmedPassword;
            this.txtConvirmedPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConvirmedPassword.HoverState.Parent = this.txtConvirmedPassword;
            this.txtConvirmedPassword.Location = new System.Drawing.Point(267, 418);
            this.txtConvirmedPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConvirmedPassword.Name = "txtConvirmedPassword";
            this.txtConvirmedPassword.PasswordChar = '*';
            this.txtConvirmedPassword.PlaceholderText = "";
            this.txtConvirmedPassword.SelectedText = "";
            this.txtConvirmedPassword.ShadowDecoration.Parent = this.txtConvirmedPassword;
            this.txtConvirmedPassword.Size = new System.Drawing.Size(267, 44);
            this.txtConvirmedPassword.TabIndex = 1;
            this.txtConvirmedPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConvirmedPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(267, 330);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(267, 44);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(267, 242);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(267, 44);
            this.txtUsername.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Applications.png");
            this.imageList1.Images.SetKeyName(1, "PersonDetails 32.png");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 10;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = global::DVLD_Interface.Properties.Resources._8666542_save_icon;
            this.btnSave.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSave.Location = new System.Drawing.Point(835, 821);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(56, 45);
            this.btnSave.TabIndex = 17;
            // 
            // ctrAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "ctrAddUser";
            this.Size = new System.Drawing.Size(898, 768);
            this.Load += new System.EventHandler(this.ctrAddUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpLogininfo.ResumeLayout(false);
            this.tpLogininfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private System.Windows.Forms.Panel panel3;
        protected internal Guna.UI2.WinForms.Guna2ComboBox comItmes;
        protected internal Guna.UI2.WinForms.Guna2TextBox txtFilterText;
        protected internal System.Windows.Forms.PictureBox pbFilter;
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tpPersonInfo;
        protected System.Windows.Forms.TabPage tpLogininfo;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label lblID;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected Guna.UI2.WinForms.Guna2TextBox txtConvirmedPassword;
        protected Guna.UI2.WinForms.Guna2TextBox txtPassword;
        protected Guna.UI2.WinForms.Guna2TextBox txtUsername;
        protected Guna.UI2.WinForms.Guna2CustomCheckBox chkIsActive;
        protected System.Windows.Forms.ErrorProvider errorProvider1;
        protected Guna.UI2.WinForms.Guna2Button btnSave;
        protected Guna.UI2.WinForms.Guna2Button btnNext;
        protected Person.ctrFindPerson ctrFindUser1;
        protected System.Windows.Forms.ImageList imageList1;
        protected System.Windows.Forms.Button btnnSave;
    }
}
