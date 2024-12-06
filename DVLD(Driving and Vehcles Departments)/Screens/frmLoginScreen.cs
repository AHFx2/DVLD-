using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Logic;

namespace DVLD_Interface.Screens
{
    public partial class frmLoginScreen : Form
    {
        byte seconds = 60;

        private byte Traies = 3;
        public frmLoginScreen()
        {
            InitializeComponent();
        }
        public clsUserLogic user;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            user = DVLD_Logic.clsUserLogic.GetUser(txtUserName.Text);
            if (user != null)
            {



                if (user.IsActive == 1)
                {

                    if (chkRememberMe.Checked)
                    {
                        clsGloble.RememberPasswordAndUserName(txtPassWord.Text.Trim(), txtUserName.Text.Trim());
                    }
                    else
                        clsGloble.RememberPasswordAndUserName("", ""); // actuly this will not save empty data but will delete the file data

                    clsGloble.User = user;
                    this.Hide();
                    frmMainScreen mainScreen = new frmMainScreen();
                    mainScreen.Show();
                }
                else
                txtUserName.Focus();
                lblWarning.Visible = true;
                lblWarning.Text = $"Your account is not Active, Contact Admin.";

                return;
            }
            else
            {
                lblWarning.Visible = true;
                Traies--;

                if (Traies == 0)
                {
                    guna2Button1.Enabled = false;
                    Traies = 3;
                    timer1.Start();
                }
                else

                    lblWarning.Text = $"Password Or Username wrong, \nYou Have {Traies} Tries";

            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWarning.Text = $"Try After {--seconds}s";
            if (seconds == 1)
            {
                guna2Button1.Enabled = true;
                lblWarning.Visible = false;
                seconds = 60;
                timer1.Stop();
            }

        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            string temUsername = string.Empty;
            string temPassword = string.Empty;
            if (clsGloble.GetStoredCardintls(ref temUsername, ref temPassword))
            {
                txtUserName.Text = temUsername;
                txtPassWord.Text = temPassword;
                chkRememberMe.Checked = true;
            }

            else
            {
                chkRememberMe.Checked = false;
            }
        }
    }
}
