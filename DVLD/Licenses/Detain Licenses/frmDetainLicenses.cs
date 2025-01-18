using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.GlobalClasses;
using DVLD_Interface.Licenses.Local_Licenses;
using DVLD_Interface.Screens.MISC;

namespace DVLD_Interface.Licenses.Detain_Licenses
{
    public partial class frmDetainLicenses : Form
    {

        private int _DetainID = -1;
        private int _SelectedLicenseID = -1;
        public frmDetainLicenses()
        {
            InitializeComponent();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {

        }

        private void frmDetainLicenseApplication_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByUser.Text = clsGlobal.User.Username;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrLicenseCardWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            lblLicenseID.Text = _SelectedLicenseID.ToString();

            llShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)

            {
                return;
            }

            //ToDo: make sure the license is not detained already.
            if (ctrLicenseCardWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtFineFees.Focus();
            btnDetain.Enabled = true;
        }

        private void frmDetainLicenseApplication_Activated(object sender, EventArgs e)
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

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txtFineFees_Validating_1(object sender, CancelEventArgs e)
        {
            clsValidation.SetErrorToNumberFeilds(sender, e);
        }
    }
}
