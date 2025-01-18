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
using static DVLD_Buisness.clsLicense;
using DVLD_Interface.GlobalClasses;
using DVLD_Interface.Licenses.Local_Licenses;
using DVLD_Interface.Screens.MISC;

namespace DVLD_Interface.Applications.ReplaceForDamgedOrLostLicenses
{
    public partial class frmReplaceLostOrDamagedLicenseApplication : Form
    {
        private int _NewLicenseID = -1;

        public frmReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
        }

        private int _GetApplicationTypeID()
        {
            //this will decide which application type to use accirding 
            // to user selection.

            if (rbDamagedLicense.Checked)

                return (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;
        }

        private enIssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if (rbDamagedLicense.Checked)

                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }




  

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueReplacement_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            clsLicense NewLicense =
               ctrLicenseCardWithFilter1.SelectedLicenseInfo.Replace(_GetIssueReason(),
               clsGlobal.User.ID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;

            lblRreplacedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssueReplacement.Enabled = false;
            gbReplacementFor.Enabled = false;
            ctrLicenseCardWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;


        }

        private void rbDamagedLicense_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbDamagedLicense.Checked)
            {
                lblTitle.Text = "Replacement for Damaged License";
                this.Text = lblTitle.Text;
                lblApplicationFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).Fees.ToString();
            }

            else
            {

                lblTitle.Text = "Replacement for Lost License";
                this.Text = lblTitle.Text;
                lblApplicationFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).Fees.ToString();
            }
        }

        private void frmReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByUser.Text = clsGlobal.User.Username;

            rbDamagedLicense.Checked = true;
        }

        private void llShowLicenseHistory_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm =
                  new frmShowPersonLicenseHistory(ctrLicenseCardWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm =
                    new frmShowLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void ctrLicenseCardWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;
            lblOldLicenseID.Text = SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
            {
                return;
            }

            //dont allow a replacement if is Active .
            if (!ctrLicenseCardWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }

            btnIssueReplacement.Enabled = true;
        }
    }
}
