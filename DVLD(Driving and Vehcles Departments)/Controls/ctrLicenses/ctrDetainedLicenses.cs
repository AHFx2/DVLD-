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

namespace DVLD_Interface.Controls.ctrLicenses
{
    public partial class ctrDetainedLicenses : UserControl
    {
        public ctrDetainedLicenses()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            this.lblDetainedDate.Text = DateTime.Now.ToShortDateString();
            lblUserName.Text = clsGloble.User.Username.ToString();

        }
        private void ctrDetainedLicenses_Load(object sender, EventArgs e)
        {
        }

        private void ctrFindLicense1_onLicenseFound(string obj)
        {
            lblLicenseID.Text = obj;
            btnShowLicenseHistory.Enabled = true;
            if (!clsDetainedLicenseLogic.IsDetainedLicense(int.Parse(obj)))
            {
                btnDetained.Enabled = true;

            }

            else { MessageBox.Show($"License With ID {obj} Already Detained", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int Reslult = clsDetainedLicenseLogic.DetaineLicense(int.Parse(lblLicenseID.Text), double.Parse(txtFees.Text), clsGloble.User.ID, txtNotes.Text);
            if (Reslult > 0)
            {
                btnShowNewLicenseInfo.Enabled = true;
                lblDetainedID.Text = Reslult.ToString();
                MessageBox.Show("Data Saved Succefully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show($"Data Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDetained_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true; 
            tabControl1.SelectedTab = tabPage2;
        }

        private void ctrFindLicense1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowNewLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseCard frm = new frmLicenseCard();
            frm.InitializeByLicenseID(int.Parse(lblLicenseID.Text));
        }
    }
}
