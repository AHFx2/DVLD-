namespace DVLD_Interface.Screens
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pMenue = new System.Windows.Forms.FlowLayoutPanel();
            this.pLogo = new System.Windows.Forms.Panel();
            this.btnMinimuize = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMaxumize = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnExsit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnApplications = new Guna.UI2.WinForms.Guna2Button();
            this.btnPeople = new Guna.UI2.WinForms.Guna2Button();
            this.btnDriverss = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserss = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.pCurrentUser = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.pMenue.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pCurrentUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(50, 0);
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Location = new System.Drawing.Point(3, 625);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 55);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BorderRadius = 10;
            this.btnChangePassword.CheckedState.Parent = this.btnChangePassword;
            this.btnChangePassword.CustomBorderColor = System.Drawing.Color.Aquamarine;
            this.btnChangePassword.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChangePassword.CustomImages.Parent = this.btnChangePassword;
            this.btnChangePassword.FillColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.HoverState.Parent = this.btnChangePassword;
            this.btnChangePassword.Image = global::DVLD_Interface.Properties.Resources.icons8_change_password_58;
            this.btnChangePassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangePassword.ImageOffset = new System.Drawing.Point(35, 0);
            this.btnChangePassword.Location = new System.Drawing.Point(12, 0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ShadowDecoration.Parent = this.btnChangePassword;
            this.btnChangePassword.Size = new System.Drawing.Size(256, 55);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextOffset = new System.Drawing.Point(20, 0);
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.AutoScrollMargin = new System.Drawing.Size(50, 0);
            this.pContainer.Controls.Add(this.pbMain);
            this.pContainer.Location = new System.Drawing.Point(268, 0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1062, 748);
            this.pContainer.TabIndex = 1;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMain.Image = global::DVLD_Interface.Properties.Resources._6123153_ambulance_avatar_bus_driver_driver_frontliner_icon;
            this.pbMain.Location = new System.Drawing.Point(0, 0);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1062, 748);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pMain_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pMenue
            // 
            this.pMenue.BackColor = System.Drawing.Color.Chocolate;
            this.pMenue.Controls.Add(this.pLogo);
            this.pMenue.Controls.Add(this.btnApplications);
            this.pMenue.Controls.Add(this.btnPeople);
            this.pMenue.Controls.Add(this.btnDriverss);
            this.pMenue.Controls.Add(this.btnUserss);
            this.pMenue.Controls.Add(this.btnSettings);
            this.pMenue.Controls.Add(this.panel1);
            this.pMenue.Controls.Add(this.pCurrentUser);
            this.pMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenue.Location = new System.Drawing.Point(0, 0);
            this.pMenue.Name = "pMenue";
            this.pMenue.Size = new System.Drawing.Size(268, 748);
            this.pMenue.TabIndex = 2;
            // 
            // pLogo
            // 
            this.pLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pLogo.Controls.Add(this.btnMinimuize);
            this.pLogo.Controls.Add(this.btnMaxumize);
            this.pLogo.Controls.Add(this.btnExsit);
            this.pLogo.Controls.Add(this.pictureBox1);
            this.pLogo.Location = new System.Drawing.Point(3, 3);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(268, 124);
            this.pLogo.TabIndex = 2;
            // 
            // btnMinimuize
            // 
            this.btnMinimuize.CheckedState.Parent = this.btnMinimuize;
            this.btnMinimuize.CustomImages.Parent = this.btnMinimuize;
            this.btnMinimuize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimuize.FillColor2 = System.Drawing.Color.Transparent;
            this.btnMinimuize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimuize.ForeColor = System.Drawing.Color.White;
            this.btnMinimuize.HoverState.Parent = this.btnMinimuize;
            this.btnMinimuize.Image = global::DVLD_Interface.Properties.Resources.minus;
            this.btnMinimuize.Location = new System.Drawing.Point(161, 3);
            this.btnMinimuize.Name = "btnMinimuize";
            this.btnMinimuize.ShadowDecoration.Parent = this.btnMinimuize;
            this.btnMinimuize.Size = new System.Drawing.Size(32, 33);
            this.btnMinimuize.TabIndex = 4;
            this.btnMinimuize.Click += new System.EventHandler(this.btnMinimuize_Click);
            // 
            // btnMaxumize
            // 
            this.btnMaxumize.CheckedState.Parent = this.btnMaxumize;
            this.btnMaxumize.CustomImages.Parent = this.btnMaxumize;
            this.btnMaxumize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaxumize.FillColor2 = System.Drawing.Color.Transparent;
            this.btnMaxumize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaxumize.ForeColor = System.Drawing.Color.White;
            this.btnMaxumize.HoverState.Parent = this.btnMaxumize;
            this.btnMaxumize.Image = global::DVLD_Interface.Properties.Resources.maximize_size;
            this.btnMaxumize.Location = new System.Drawing.Point(82, 3);
            this.btnMaxumize.Name = "btnMaxumize";
            this.btnMaxumize.ShadowDecoration.Parent = this.btnMaxumize;
            this.btnMaxumize.Size = new System.Drawing.Size(32, 33);
            this.btnMaxumize.TabIndex = 3;
            this.btnMaxumize.Click += new System.EventHandler(this.btnMaxumize_Click);
            // 
            // btnExsit
            // 
            this.btnExsit.CheckedState.Parent = this.btnExsit;
            this.btnExsit.CustomImages.Parent = this.btnExsit;
            this.btnExsit.FillColor = System.Drawing.Color.Transparent;
            this.btnExsit.FillColor2 = System.Drawing.Color.Transparent;
            this.btnExsit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExsit.ForeColor = System.Drawing.Color.White;
            this.btnExsit.HoverState.Parent = this.btnExsit;
            this.btnExsit.Image = global::DVLD_Interface.Properties.Resources.cross__1_;
            this.btnExsit.Location = new System.Drawing.Point(9, 3);
            this.btnExsit.Name = "btnExsit";
            this.btnExsit.ShadowDecoration.Parent = this.btnExsit;
            this.btnExsit.Size = new System.Drawing.Size(32, 33);
            this.btnExsit.TabIndex = 2;
            this.btnExsit.Click += new System.EventHandler(this.btnExsit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Interface.Properties.Resources._7111327_driver_smart_car_control_technology_robot_icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(82, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnApplications
            // 
            this.btnApplications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplications.BackColor = System.Drawing.Color.Transparent;
            this.btnApplications.BorderColor = System.Drawing.Color.Gray;
            this.btnApplications.BorderRadius = 10;
            this.btnApplications.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnApplications.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnApplications.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnApplications.CheckedState.Image")));
            this.btnApplications.CheckedState.Parent = this.btnApplications;
            this.btnApplications.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnApplications.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnApplications.CustomImages.Parent = this.btnApplications;
            this.btnApplications.FillColor = System.Drawing.Color.Transparent;
            this.btnApplications.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.btnApplications.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnApplications.HoverState.CustomBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApplications.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnApplications.HoverState.Parent = this.btnApplications;
            this.btnApplications.Image = global::DVLD_Interface.Properties.Resources.Applications_64;
            this.btnApplications.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnApplications.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnApplications.ImageSize = new System.Drawing.Size(33, 33);
            this.btnApplications.Location = new System.Drawing.Point(3, 140);
            this.btnApplications.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.PressedColor = System.Drawing.Color.White;
            this.btnApplications.PressedDepth = 0;
            this.btnApplications.ShadowDecoration.Parent = this.btnApplications;
            this.btnApplications.Size = new System.Drawing.Size(264, 77);
            this.btnApplications.TabIndex = 1;
            this.btnApplications.Text = "Applications";
            this.btnApplications.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnApplications.TextOffset = new System.Drawing.Point(13, 0);
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnPeople.BorderColor = System.Drawing.Color.Gray;
            this.btnPeople.BorderRadius = 10;
            this.btnPeople.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPeople.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPeople.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnPeople.CheckedState.Image")));
            this.btnPeople.CheckedState.Parent = this.btnPeople;
            this.btnPeople.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnPeople.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPeople.CustomImages.Parent = this.btnPeople;
            this.btnPeople.FillColor = System.Drawing.Color.Transparent;
            this.btnPeople.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.btnPeople.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnPeople.HoverState.CustomBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPeople.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnPeople.HoverState.Parent = this.btnPeople;
            this.btnPeople.Image = global::DVLD_Interface.Properties.Resources.People_64;
            this.btnPeople.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPeople.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPeople.ImageSize = new System.Drawing.Size(33, 33);
            this.btnPeople.Location = new System.Drawing.Point(3, 237);
            this.btnPeople.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.PressedColor = System.Drawing.Color.White;
            this.btnPeople.PressedDepth = 0;
            this.btnPeople.ShadowDecoration.Parent = this.btnPeople;
            this.btnPeople.Size = new System.Drawing.Size(264, 77);
            this.btnPeople.TabIndex = 2;
            this.btnPeople.Text = "Mange People";
            this.btnPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPeople.TextOffset = new System.Drawing.Point(13, 0);
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnDriverss
            // 
            this.btnDriverss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDriverss.BackColor = System.Drawing.Color.Transparent;
            this.btnDriverss.BorderColor = System.Drawing.Color.Gray;
            this.btnDriverss.BorderRadius = 10;
            this.btnDriverss.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDriverss.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDriverss.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnDriverss.CheckedState.Image")));
            this.btnDriverss.CheckedState.Parent = this.btnDriverss;
            this.btnDriverss.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnDriverss.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDriverss.CustomImages.Parent = this.btnDriverss;
            this.btnDriverss.FillColor = System.Drawing.Color.Transparent;
            this.btnDriverss.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.btnDriverss.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnDriverss.HoverState.CustomBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDriverss.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnDriverss.HoverState.Parent = this.btnDriverss;
            this.btnDriverss.Image = global::DVLD_Interface.Properties.Resources.Drivers_64;
            this.btnDriverss.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDriverss.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDriverss.ImageSize = new System.Drawing.Size(33, 33);
            this.btnDriverss.Location = new System.Drawing.Point(3, 334);
            this.btnDriverss.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnDriverss.Name = "btnDriverss";
            this.btnDriverss.PressedColor = System.Drawing.Color.White;
            this.btnDriverss.PressedDepth = 0;
            this.btnDriverss.ShadowDecoration.Parent = this.btnDriverss;
            this.btnDriverss.Size = new System.Drawing.Size(264, 77);
            this.btnDriverss.TabIndex = 3;
            this.btnDriverss.Text = "Drivers";
            this.btnDriverss.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDriverss.TextOffset = new System.Drawing.Point(13, 0);
            this.btnDriverss.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnUserss
            // 
            this.btnUserss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserss.BackColor = System.Drawing.Color.Transparent;
            this.btnUserss.BorderColor = System.Drawing.Color.Gray;
            this.btnUserss.BorderRadius = 10;
            this.btnUserss.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUserss.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnUserss.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnUserss.CheckedState.Image")));
            this.btnUserss.CheckedState.Parent = this.btnUserss;
            this.btnUserss.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnUserss.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUserss.CustomImages.Parent = this.btnUserss;
            this.btnUserss.FillColor = System.Drawing.Color.Transparent;
            this.btnUserss.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.btnUserss.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnUserss.HoverState.CustomBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUserss.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnUserss.HoverState.Parent = this.btnUserss;
            this.btnUserss.Image = global::DVLD_Interface.Properties.Resources.Drivers_64;
            this.btnUserss.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserss.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnUserss.ImageSize = new System.Drawing.Size(33, 33);
            this.btnUserss.Location = new System.Drawing.Point(3, 431);
            this.btnUserss.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnUserss.Name = "btnUserss";
            this.btnUserss.PressedColor = System.Drawing.Color.White;
            this.btnUserss.PressedDepth = 0;
            this.btnUserss.ShadowDecoration.Parent = this.btnUserss;
            this.btnUserss.Size = new System.Drawing.Size(264, 77);
            this.btnUserss.TabIndex = 4;
            this.btnUserss.Text = "Users";
            this.btnUserss.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserss.TextOffset = new System.Drawing.Point(13, 0);
            this.btnUserss.Click += new System.EventHandler(this.btnUserss_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderColor = System.Drawing.Color.Gray;
            this.btnSettings.BorderRadius = 10;
            this.btnSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.CheckedState.Image")));
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnSettings.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSettings.HoverState.CustomBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::DVLD_Interface.Properties.Resources.account_settings_64;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSettings.ImageSize = new System.Drawing.Size(33, 33);
            this.btnSettings.Location = new System.Drawing.Point(3, 528);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedColor = System.Drawing.Color.White;
            this.btnSettings.PressedDepth = 0;
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(264, 77);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Account Settings";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.TextOffset = new System.Drawing.Point(17, 0);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pCurrentUser
            // 
            this.pCurrentUser.Controls.Add(this.groupBox1);
            this.pCurrentUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCurrentUser.Location = new System.Drawing.Point(3, 693);
            this.pCurrentUser.Name = "pCurrentUser";
            this.pCurrentUser.Size = new System.Drawing.Size(268, 99);
            this.pCurrentUser.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pbUserImage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 84);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblUsername.Location = new System.Drawing.Point(88, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 24);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Interface.Properties.Resources.icons8_exit_50;
            this.pictureBox3.Location = new System.Drawing.Point(191, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pbUserImage
            // 
            this.pbUserImage.Image = global::DVLD_Interface.Properties.Resources._172628_user_male_icon;
            this.pbUserImage.Location = new System.Drawing.Point(6, 18);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(62, 60);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 10;
            this.pbUserImage.TabStop = false;
            this.pbUserImage.Click += new System.EventHandler(this.pbUserImage_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 748);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pMenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1104, 694);
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainScreen_FormClosed);
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.panel1.ResumeLayout(false);
            this.pContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.pMenue.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pCurrentUser.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnPeople;
        private Guna.UI2.WinForms.Guna2Button btnApplications;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.PictureBox pbMain;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private System.Windows.Forms.FlowLayoutPanel pMenue;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDriverss;
        private Guna.UI2.WinForms.Guna2Button btnUserss;
        private System.Windows.Forms.Panel pCurrentUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbUserImage;
        private Guna.UI2.WinForms.Guna2GradientButton btnMinimuize;
        private Guna.UI2.WinForms.Guna2GradientButton btnMaxumize;
        private Guna.UI2.WinForms.Guna2GradientButton btnExsit;
    }
}

