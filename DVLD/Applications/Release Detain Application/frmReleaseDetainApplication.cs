using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisness;
using DVLD_Interface.GlobalClasses;
using DVLD_Interface.Licenses.Local_Licenses;
using DVLD_Interface.Screens.MISC;

namespace DVLD_Interface.Applications.Release_Detain_Application
{
    public partial class frmReleaseDetainApplication : Form
    {


        private int _SelectedLicenseID = -1;

        public frmReleaseDetainApplication()
        {
            InitializeComponent();
        }

        public frmReleaseDetainApplication(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenseID;

            ctrLicenseCardWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
            ctrLicenseCardWithFilter1.FilterEnabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            lblLicenseID.Text = _SelectedLicenseID.ToString();

            llShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)

            {
                return;
            }

            //ToDo: make sure the license is not detained already.
            if (!ctrLicenseCardWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString();
            lblCreatedByUser.Text = clsGlobal.User.Username;

            lblDetainID.Text = ctrLicenseCardWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
            lblLicenseID.Text = ctrLicenseCardWithFilter1.SelectedLicenseInfo.LicenseID.ToString();

            lblCreatedByUser.Text = ctrLicenseCardWithFilter1.SelectedLicenseInfo.DetainedInfo.CreatedByUserInfo.UserName;
            lblDetainDate.Text = clsFormat.DateToShort(ctrLicenseCardWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainDate);
            lblFineFees.Text = ctrLicenseCardWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();

            btnRelease.Enabled = true;
        }

        private void frmReleaseDetainedLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrLicenseCardWithFilter1.txtLicenseIDFocus();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm =
             new frmShowPersonLicenseHistory(ctrLicenseCardWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm =
           new frmShowLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int ApplicationID = -1;


            bool IsReleased = ctrLicenseCardWithFilter1.SelectedLicenseInfo.ReleaseDetainedLicense(clsGlobal.User.ID, ref ApplicationID); ;

            lblApplicationID.Text = ApplicationID.ToString();

            if (!IsReleased)
            {
                MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            ctrLicenseCardWithFilter1.FilterEnabled = false;
        }
    }
}
