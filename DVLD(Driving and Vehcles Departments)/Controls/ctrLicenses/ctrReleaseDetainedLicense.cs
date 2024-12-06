using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Logic;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Interface.Controls.ctrLicenses
{
    public partial class ctrReleaseDetainedLicense : UserControl
    {
        clsApplicationLogic application;
        public ctrReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        DataTable DetainedInfo;
        public void Initialize()
        {
            lblAppdate.Text = DateTime.Now.ToShortDateString();
            lblReleasseDate.Text = DateTime.Now.ToShortDateString();
            lblUserName.Text = clsGloble.User.Username;
        }
        private void btnDetained_Click(object sender, EventArgs e)
        {
            DetainedInfo = clsDetainedLicenseLogic.GetDetainedInfo(int.Parse(lblLicenseID.Text));
            if (DetainedInfo.Rows.Count > 0)
                _FillAppInfo();
            tabControl1.SelectedTab = tabPage2;
            btnSave.Enabled = true;

        }
        private void _FillAppInfo()
        {
            application = new clsApplicationLogic();
            application.ApplicationTypeID = Convert.ToByte(clsApplicationLogic.enApplicationTypes.ReleaaseDetainedLicense);
            application.ApplicationStatus = 1;
            application.LaststautDate = DateTime.Now;
            application.ApplicationDate = DateTime.Now;
            application.UserCreatIt = clsGloble.User.ID;
            lblAppFees.Text = clsApplicationTyesLogic.GetApplicationType(Convert.ToByte(clsApplicationLogic.enApplicationTypes.ReleaaseDetainedLicense)).Fees.ToString();
            lblFineFees.Text = DetainedInfo.Rows[0]["FineFees"].ToString();
            application.PaidFees = int.Parse(lblAppFees.Text) + double.Parse(lblFineFees.Text);
            lblTotalFees.Text = application.PaidFees.ToString();
            application.ApplicantPersonID = clsPersonLogic.GetPerson(Convert.ToInt16(this.ctrFindLicense1.ctrLincesCard1.LicenseInformation.Rows[0]["PersonID"])).ID;
            lblDetaineID.Text = DetainedInfo.Rows[0]["DetainID"].ToString();
            lblDetainDate.Text = Convert.ToDateTime(DetainedInfo.Rows[0]["DetainDate"]).ToShortDateString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (application.Save())
            {
                lblReAppID.Text = application.ID.ToString();
                if (clsDetainedLicenseLogic.ReleaseDetainedLicense(int.Parse(lblDetaineID.Text), clsGloble.User.ID, application.ID))
                {
                    MessageBox.Show("License Released Succefully", "Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("License Didn't Release", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ctrFindLicense1_onLicenseFound(string obj)
        {
            lblLicenseID.Text = obj;

            if (clsDetainedLicenseLogic.IsDetainedLicense(Convert.ToInt16(obj)))
            {
                btnRelease.Enabled = true;
            }

            else
            {
                MessageBox.Show($"License with id {obj} Not Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
