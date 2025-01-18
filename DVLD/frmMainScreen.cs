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
using DVLD_Interface.User;
using DVLD_Interface.Screens.MISC;
using System.Windows.Forms.VisualStyles;
using DVLD_Interface.Applications.Local_Drinving_License_Application;
using DVLD_Interface.User;

namespace DVLD_Interface
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
            
            
            //child.BackColor = SeetingsColor.PrimaryColor;
            ActiveForm = child;
            child.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;

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
                    CurrentButton.FillColor = SeetingsColor.ChangeColorBrightness(Color.FromArgb(65, 82, 101), 0.2);
                    CurrentButton.CustomBorderColor = SeetingsColor.ChangeColorBrightness(Color.FromArgb(65, 82, 101), -0.5);
                    CurrentButton.Font = new System.Drawing.Font("Segoe UI", 11.5F);
                    CurrentButton.ForeColor = Color.Snow;
                    
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
                    guna2Button.FillColor = Color.FromArgb(65, 82, 101);
                    guna2Button.ForeColor = Color.LightGray;
                    guna2Button.CustomBorderColor = Color.LightGray;
                    guna2Button.Font = new System.Drawing.Font("Segoe UI", 10F);

                }
            }
        }

  

        private void btnPeople_Click(object sender, EventArgs e)
        {
            frmPeopleList listsPeople = new frmPeopleList();
            OpenChaildForm(listsPeople, (Guna2Button)sender);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {



        }

        private void _LoadUserSubCard()
        {

            lblUsername.Text = clsGlobal.User.Username;
        
        }
        
        private void btnApplications_Click(object sender, EventArgs e)
        {
            //frmApplications frmApplications = new frmApplications();
            //OpenChaildForm(frmApplications, (Guna2Button)sender);

            pApplications.Visible = (pApplications.Visible == true) ? false : true;
        }



        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            else
                panel1.Visible = true;
        }

 

        private void frmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

 

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            frmDriversList driversList = new frmDriversList();
            OpenChaildForm(driversList, (Guna2Button)sender);
        }

    
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangepassword changepassword = new frmChangepassword(clsGlobal.User.ID);
            changepassword.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Drivers.frmDriversList driversList = new Drivers.frmDriversList();
            OpenChaildForm(driversList, (Guna2Button)sender);
        }

        private void btnUserss_Click(object sender, EventArgs e)
        {
            frmUserList usersList = new frmUserList();
            OpenChaildForm(usersList, (Guna2Button)sender);
        }

        
        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            pDetainLicenses.Visible = (pDetainLicenses.Visible == true) ? false: true;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            pMangeApplications.Visible = (pMangeApplications.Visible == true) ? false : true;
        }

        private void btnNewLicense_Click(object sender, EventArgs e)
        {
            pNewLicense.Visible = (pNewLicense.Visible == true) ? false : true;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            pDrvingLicense.Visible = (pDrvingLicense.Visible == true) ? false : true;
        }

        private void pDrvingLicense_Paint(object sender, PaintEventArgs e)
        {
            pMenue.HorizontalScroll.Enabled = false;
        }

        private void btnLocalLicensesList_Click(object sender, EventArgs e)
        {
     
            Applications.Local_Drinving_License_Application.frmLocalDrvingLicenseApplicationsList frm = new Applications.Local_Drinving_License_Application.frmLocalDrvingLicenseApplicationsList();
            OpenChaildForm(frm, (Guna2Button)sender);
        }

        private void btnMangeIntenationalLicenses_Click(object sender, EventArgs e)
        {


            Applications.International_License_Application.frmInternationalLicensesList frm = new  Applications.International_License_Application.frmInternationalLicensesList();
            OpenChaildForm(frm, (Guna2Button)sender);
        }

        private void btnAddLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            OpenChaildForm(frm, (Guna2Button)sender);
        }

        private void btnAddInternationalLicenses_Click(object sender, EventArgs e)
        {
            Applications.International_License_Application.frmAddInternationalLicenseApplication frm = new Applications.International_License_Application.frmAddInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void btnReplaceLicenses_Click(object sender, EventArgs e)
        {
            Applications.ReplaceForDamgedOrLostLicenses.frmReplaceLostOrDamagedLicenseApplication frm = new Applications.ReplaceForDamgedOrLostLicenses.frmReplaceLostOrDamagedLicenseApplication();
            frm.ShowDialog();
        }

        private void btnRenewLicenses_Click(object sender, EventArgs e)
        {
            Applications.Renew_License.frmRenewLocalDrivingLicenseApplication RenewLicenseForm = new Applications.Renew_License.frmRenewLocalDrivingLicenseApplication();
            RenewLicenseForm.ShowDialog();
        }

        private void btnMangeDetainLicenses_Click(object sender, EventArgs e)
        {
            Applications.Release_Detain_Application.frmDetaindLicensesList DetainLicensesList = new Applications.Release_Detain_Application.frmDetaindLicensesList();
            OpenChaildForm(DetainLicensesList, (Guna2Button)sender);



        }

        private void btnDetainLicenses_Click(object sender, EventArgs e)
        {
            Licenses.Detain_Licenses.frmDetainLicenses DetainLicenseForm = new Licenses.Detain_Licenses.frmDetainLicenses();
            DetainLicenseForm.ShowDialog();
        }

        private void btnReleaseDetainLicense_Click(object sender, EventArgs e)
        {
            Applications.Release_Detain_Application.frmReleaseDetainApplication ReleaseLicenseForm = new Applications.Release_Detain_Application.frmReleaseDetainApplication();
            ReleaseLicenseForm.ShowDialog();
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            frmUserInfo userinfo = new frmUserInfo(clsGlobal.User.ID);
            userinfo.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLoginScreen frmLogin = new frmLoginScreen();
            frmLogin.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            tMenueTransaction.Start();
        }

        private bool _expand = true;
        private void tMenueTransaction_Tick(object sender, EventArgs e)
        {

            if (_expand)
            {
                // i nead to make smaller
                if (pMenue.Width >= 79)
                {

                    pMenue.Width -= 8;
                    pContainer.Width += 8;
                    if (pMenue.Width == 79)
                    {
                        _expand = false;
                        tMenueTransaction.Stop();
                        MessageBox.Show("Stop");
                    }
                }
            }

                
            else 
            {
                if (pMenue.Width <= 319)
                {

                    pMenue.Width += 8;
                    pContainer.Width -= 8;
                    if (pMenue.Width == 319)
                    {
                        _expand = true;
                        tMenueTransaction.Stop();
                        MessageBox.Show("Stop");
                    }
                }
            }

        }
    }
}
