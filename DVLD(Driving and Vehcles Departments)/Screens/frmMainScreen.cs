using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using DVLD_Interface.Screens;
using DVLD_Interface.Screens.User;
using DVLD_Interface.Screens.MISC;
using System.Windows.Forms.VisualStyles;

namespace DVLD_Interface.Screens
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
            
            
        }

     

        Form ActiveForm;
        Guna2Button CurrentButton;
        
        protected internal void OpenChaildForm(Form child, Guna2Button buttnSender)
        {
            pbMain.Visible = false;
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveButton(buttnSender);
            
            
            child.BackColor = SeetingsColor.PrimaryColor;
            ActiveForm = child;
            child.TopLevel = false;
            this.pContainer.Controls.Add(child);
            child.Dock = DockStyle.Fill;
            child.BringToFront();
            child.Show();
            pbMain.Visible = true;

        }

        private void ActiveButton(object Button)
        {
            if (Button != null)
            {
                Color color = SeetingsColor.RandomColor();
                RestButtons(color);
                if (CurrentButton != (Guna2Button)Button)
                {
                    CurrentButton = (Guna2Button)Button;
                    CurrentButton.FillColor = SeetingsColor.ChangeColorBrightness(color, 0.2);
                    CurrentButton.CustomBorderColor = SeetingsColor.ChangeColorBrightness(color, -0.5);
                    CurrentButton.Font = new System.Drawing.Font("Old Antic Outline Shaded", 13F);
                    CurrentButton.ForeColor = Color.Snow;
                    pLogo.BackColor = SeetingsColor.ChangeColorBrightness(color, -0.2);
                    pCurrentUser.BackColor = SeetingsColor.ChangeColorBrightness(color, -0.4);
                    SeetingsColor.PrimaryColor = color;
                    SeetingsColor.SecondaryColor = SeetingsColor.ChangeColorBrightness(color, -0.3);
                    pMenue.BackColor = SeetingsColor.ChangeColorBrightness(color, -0.111);
                    
                }
            }
        }

        private void RestButtons(Color color)
        {
            Guna2Button guna2Button = new Guna2Button();
            foreach (Control PrevButton in pMenue.Controls)
            {

           

                if (PrevButton.GetType() == typeof(Guna2Button))
                {

                    guna2Button = (Guna2Button)PrevButton;
                    guna2Button.FillColor = Color.Transparent;
                    guna2Button.ForeColor = Color.Gainsboro;
                    guna2Button.Font = new System.Drawing.Font("Old Antic Outline Shaded", 10F);
                    guna2Button.CustomBorderColor = SeetingsColor.ChangeColorBrightness(color, -0.5);
                    guna2Button.HoverState.FillColor = SeetingsColor.ChangeColorBrightness(color, -0.2);
                    guna2Button.HoverState.CustomBorderColor = SeetingsColor.ChangeColorBrightness(color, -0.6);

                }
            }
        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {
        }

  

        private void btnPeople_Click(object sender, EventArgs e)
        {
            frmPeopleInterface listsPeople = new frmPeopleInterface();
            OpenChaildForm(listsPeople, (Guna2Button)sender);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {

            pLogo.BackColor = SeetingsColor.ChangeColorBrightness(Color.FromArgb(17, 95, 166), -0.2);
            pCurrentUser.BackColor = SeetingsColor.ChangeColorBrightness(Color.FromArgb(17, 95, 166), -0.4);
            btnApplications.CustomBorderColor = Color.FromArgb(17, 95, 166);
            btnSettings.CustomBorderColor = Color.FromArgb    (17, 95, 166);
            btnPeople.CustomBorderColor = Color.FromArgb      (17, 95, 166);
            btnDriverss.CustomBorderColor = Color.FromArgb     (17, 95, 166);
            btnUserss.CustomBorderColor = Color.FromArgb       (17, 95, 166);
            pMenue.BackColor = pCurrentUser.BackColor;

            panel1.BackColor = Color.Transparent;
            btnChangePassword.BackColor = btnUserss.BackColor;
            btnChangePassword.CustomBorderColor = btnUserss.CustomBorderColor;


            lblUsername.Text = clsGloble.User.Username;
            pbUserImage.Image = Image.FromFile(DVLD_Logic.clsPersonLogic.GetPerson(clsGloble.User.Person.ID).ImagePath.ToString());
        }



        private void btnApplications_Click(object sender, EventArgs e)
        {
            frmApplications frmApplications = new frmApplications();
            OpenChaildForm(frmApplications, (Guna2Button)sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers usersList = new frmUsers();
            OpenChaildForm(usersList, (Guna2Button)sender);



        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            else
                panel1.Visible = true;
        }

        private void pCurrentUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
      
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            frmDriversList driversList = new frmDriversList();
            OpenChaildForm(driversList, (Guna2Button)sender);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExsit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimuize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxumize_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pMenue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmDriversList driversList = new frmDriversList();
            OpenChaildForm(driversList, (Guna2Button)sender);
        }

        private void btnUserss_Click(object sender, EventArgs e)
        {
            frmUsers usersList = new frmUsers();
            OpenChaildForm(usersList, (Guna2Button)sender);
        }

        private void pbUserImage_Click(object sender, EventArgs e)
        {
            frmUserInfo userinfo = new frmUserInfo(clsGloble.User.ID);
            userinfo.ShowDialog();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void pMain_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            frmLoginScreen frmLogin = new frmLoginScreen();
            frmLogin.Show();
            this.Hide();
        }

        private void lblUsername_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMaxumize_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExsit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMinimuize_Click_1(object sender, EventArgs e)
        {

        }
    }
}
