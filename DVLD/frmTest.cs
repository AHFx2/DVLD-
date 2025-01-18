using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface;
using Guna.UI2.WinForms;

namespace DVLD_Interface
{
    //public partial class frmTest : Form
    //{
    //    private void initializeComponent()
    //    {
    //        // Form settings
    //        this.Size = new System.Drawing.Size(1000, 600);
    //        this.StartPosition = FormStartPosition.CenterScreen;
    //        this.Text = "License Management System";
    //        this.BackColor = System.Drawing.Color.FromArgb(245, 246, 247);

    //        // Logo PictureBox
    //        Guna2PictureBox logoPictureBox = new Guna2PictureBox();
    //        logoPictureBox.Size = new System.Drawing.Size(200, 200);
    //        logoPictureBox.Location = new System.Drawing.Point(400, 30);
    //        logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
    //        logoPictureBox.Image = Properties.Resources.account_settings; // Add your logo to resources
    //        this.Controls.Add(logoPictureBox);

    //        // Create and style buttons
    //        string[] buttonTexts = {
    //            "Manage Licenses",
    //            "Add New License",
    //            "View Reports",
    //            "Settings",
    //            "Exit"
    //        };

    //        string[] buttonIcons = {
    //            "📋", "➕", "📊", "⚙️", "🚪"
    //        };

    //        for (int i = 0; i < 5; i++)
    //        {
    //            Guna2Button button = new Guna2Button();
    //            button.Text = buttonTexts[i];
    //            button.Size = new System.Drawing.Size(250, 45);
    //            button.Location = new System.Drawing.Point(375, 250 + (i * 60));

    //            // Button styling
    //            button.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
    //            button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
    //            button.ForeColor = System.Drawing.Color.White;
    //            button.BorderRadius = 20;
    //            button.Cursor = Cursors.Hand;

    //            // Hover effects
    //            button.HoverState.FillColor = System.Drawing.Color.FromArgb(72, 123, 237);
    //            button.HoverState.ForeColor = System.Drawing.Color.White;

    //            // Add icon
    //            button.Text = buttonIcons[i] + "  " + buttonTexts[i];

    //            // Add shadow effect
    //            button.ShadowDecoration.Enabled = true;
    //            button.ShadowDecoration.Color = System.Drawing.Color.FromArgb(94, 148, 255);
    //            button.ShadowDecoration.Depth = 20;
    //            button.ShadowDecoration.Shadow = new Padding(5);

    //            this.Controls.Add(button);
    //        }

    //        // Form title
    //        Guna2HtmlLabel titleLabel = new Guna2HtmlLabel();
    //        titleLabel.Text = "License Management System";
    //        titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
    //        titleLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
    //        titleLabel.Location = new System.Drawing.Point(330, 180);
    //        titleLabel.AutoSize = true;
    //        this.Controls.Add(titleLabel);
    //    }
    //    public frmTest()
    //    {
    //        initializeComponent();
    //    }

    //}
}


namespace DVLD_Interface
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            SetupUI();
        }

        private void SetupUI()
        {
            // Main Form
            this.Text = "License Management System";
            this.Size = new System.Drawing.Size(800, 600);
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // Logo
            var logo = new Guna2PictureBox
            {
                Image = Properties.Resources.loading, // Add your logo in Resources
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new System.Drawing.Size(200, 100),
                Location = new System.Drawing.Point(300, 50)
            };
            this.Controls.Add(logo);

            // Title Label
            var titleLabel = new Guna2HtmlLabel
            {
                Text = "License Management System",
                Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.DimGray,
                AutoSize = true,
                Location = new System.Drawing.Point(250, 170)
            };
            this.Controls.Add(titleLabel);

            // Buttons
            string[] buttonTexts = { "Add License", "Update License", "View Licenses", "Delete License", "Exit" };
            int topOffset = 250;

            foreach (var text in buttonTexts)
            {
                var button = new Guna2Button
                {
                    Text = text,
                    Size = new System.Drawing.Size(300, 45),
                    Font = new System.Drawing.Font("Segoe UI", 12),
                    BorderRadius = 20,
                    FillColor = System.Drawing.Color.FromArgb(63, 81, 181),
                    ForeColor = System.Drawing.Color.White,
                    HoverState = { FillColor = System.Drawing.Color.FromArgb(48, 63, 159) },
                    Location = new System.Drawing.Point(250, topOffset)
                };

                button.Click += (sender, e) => MessageBox.Show($"{text} button clicked!");
                this.Controls.Add(button);
                topOffset += 60;
            }
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }
    }
}


//namespace LicenseManagementSystem
//{
//    public partial class frmTest : Form
//    {
//        public frmTest()
//        {
//            InitializeComponent();
//        }

//        private void InitializeComponent()
//        {
//            // Form settings
//            this.Size = new System.Drawing.Size(1000, 600);
//            this.StartPosition = FormStartPosition.CenterScreen;
//            this.Text = "License Management System";
//            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 247);

//            // Logo PictureBox
//            Guna2PictureBox logoPictureBox = new Guna2PictureBox();
//            logoPictureBox.Size = new System.Drawing.Size(200, 200);
//            logoPictureBox.Location = new System.Drawing.Point(400, 30);
//            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
//            logoPictureBox.Image = Properties.Resources.logo; // Add your logo to resources
//            this.Controls.Add(logoPictureBox);

//            // Create and style buttons
//            string[] buttonTexts = {
//                "Manage Licenses",
//                "Add New License",
//                "View Reports",
//                "Settings",
//                "Exit"
//            };

//            string[] buttonIcons = {
//                "📋", "➕", "📊", "⚙️", "🚪"
//            };

//            for (int i = 0; i < 5; i++)
//            {
//                Guna2Button button = new Guna2Button();
//                button.Text = buttonTexts[i];
//                button.Size = new System.Drawing.Size(250, 45);
//                button.Location = new System.Drawing.Point(375, 250 + (i * 60));

//                // Button styling
//                button.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
//                button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
//                button.ForeColor = System.Drawing.Color.White;
//                button.BorderRadius = 20;
//                button.Cursor = Cursors.Hand;

//                // Hover effects
//                button.HoverState.FillColor = System.Drawing.Color.FromArgb(72, 123, 237);
//                button.HoverState.ForeColor = System.Drawing.Color.White;

//                // Add icon
//                button.Text = buttonIcons[i] + "  " + buttonTexts[i];

//                // Add shadow effect
//                button.ShadowDecoration.Enabled = true;
//                button.ShadowDecoration.Color = System.Drawing.Color.FromArgb(94, 148, 255);
//                button.ShadowDecoration.Depth = 20;
//                button.ShadowDecoration.Shadow = new Padding(5);

//                this.Controls.Add(button);
//            }

//            // Form title
//            Guna2HtmlLabel titleLabel = new Guna2HtmlLabel();
//            titleLabel.Text = "License Management System";
//            titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
//            titleLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
//            titleLabel.Location = new System.Drawing.Point(330, 180);
//            titleLabel.AutoSize = true;
//            this.Controls.Add(titleLabel);
//        }
//    }
//}
