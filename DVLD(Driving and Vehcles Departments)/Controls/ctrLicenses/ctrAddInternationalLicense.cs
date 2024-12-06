using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Screens.MISC;
using DVLD_Logic;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Interface.Controls.ctrMISC
{
    public partial class ctrAddInternationalLicense : UserControl
    {
        DVLD_Logic.clsApplicationLogic application = null;

        DVLD_Logic.clsInternationalLicenseLogic internationalLicense = null;
        public ctrAddInternationalLicense()
        {
            InitializeComponent();
        }

        private void ctrAddInternationalLicense_Load(object sender, EventArgs e)
        {

        }

        private void _FillInterNationalicesnApplicationInfo()
        {
            application = new clsApplicationLogic();
            application.ApplicationTypeID = Convert.ToByte(clsApplicationLogic.enApplicationTypes.NewIntrnationlLicense);
            application.ApplicationStatus = 1;
            application.LaststautDate = DateTime.Now;
            application.ApplicationDate = DateTime.Now;
            application.UserCreatIt = clsGloble.User.ID;
            lblFees.Text = clsApplicationTyesLogic.GetApplicationType(application.ApplicationTypeID).Fees.ToString();
            application.PaidFees = Convert.ToInt16(lblFees.Text);
            application.ApplicantPersonID = clsPersonLogic.GetPerson(Convert.ToInt16(this.ctrFindLicense1.ctrLincesCard1.LicenseInformation.Rows[0]["PersonID"])).ID;

        }

        private void _FillInterNationalicesnInfo()
        {
            internationalLicense = new clsInternationalLicenseLogic();
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.EpirationDate = internationalLicense.IssueDate.AddYears(1);
            internationalLicense.DriverID = Convert.ToInt16(ctrFindLicense1.ctrLincesCard1.LicenseInformation.Rows[0]["DriverID"]);
            internationalLicense.ApplicaitonID = application.ID;
            internationalLicense.IsActive = 1;
            internationalLicense.UserCreateItID = clsGloble.User.ID;
            internationalLicense.IssuedUsingLocalLicenseID = int.Parse(lblLicenseID.Text);

           
        }

        private void _FillTheBoxInformation()
        {
            lblUserName.Text = clsGloble.User.Username;
            lblFees.Text = clsApplicationTyesLogic.GetApplicationType(Convert.ToByte(clsApplicationLogic.enApplicationTypes.NewIntrnationlLicense)).Fees.ToString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblEpirtationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
        }
        private void ctrFindLicense1_onLicenseFound(string obj)
        {
            lblLicenseID.Text = obj;
            btnShowLicenseHistory.Enabled = true;  
            _FillTheBoxInformation();

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillInterNationalicesnApplicationInfo();
            _FillInterNationalicesnInfo();

            // i put the ! because the function will return true if the driver have the international license or not
            if (!clsInternationalLicenseLogic.DoseDriverHaveDemandedLicense(internationalLicense.DriverID))
            {
                if (clsLicenseLogic.IsLicenseActive(internationalLicense.IssuedUsingLocalLicenseID))
                {
                    if (!clsLicenseLogic.IsEpiredLicense(internationalLicense.IssuedUsingLocalLicenseID))
                    {
                        // welcome you can save it know lol
                        if (application.Save())
                        {
                            internationalLicense.ApplicaitonID = application.ID;
                            if (internationalLicense.Save())
                            {
                                btnShowLicenseInfo.Enabled = true;
                                this.lblLicenseID.Text = internationalLicense.InterNationalLicenseID.ToString();
                                this.lblAppID.Text = application.ID.ToString();
                                MessageBox.Show("Data Saved Succefully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                MessageBox.Show("Data Didn't Save Succefully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        else
                        {

                            MessageBox.Show("Data Didn't Save Succefully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    else
                    {
                        MessageBox.Show("The Length Of The License Is Epiered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                else
                {
                    MessageBox.Show("License Is Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
            {
                MessageBox.Show("Data Didn't Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseCard frm = new frmInternationalLicenseCard(Convert.ToInt16(lblNationalLID.Text));
            frm.ShowDialog();
        }

        private void btnShowLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(this.ctrFindLicense1.ctrLincesCard1.LicenseInformation.Rows[0]["NationalNo"].ToString());
            frm.ShowDialog();
        }

        private void ctrFindLicense1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }
    }
}
