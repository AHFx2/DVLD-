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
    public partial class ctrDamged_LostLicensesApplications : UserControl
    {
        clsApplicationLogic application;
        public ctrDamged_LostLicensesApplications()
        {
            InitializeComponent();
            application = new clsApplicationLogic();

        }

        private void ctrFindLicense2_Load(object sender, EventArgs e)
        {

        }

        private void _FillApplicationInfo()
        {
            application.ApplicationStatus = 1;
            application.LaststautDate = DateTime.Now;
            application.ApplicationDate = DateTime.Now;
            application.UserCreatIt = clsGloble.User.ID;
            lblFees.Text = clsApplicationTyesLogic.GetApplicationType(application.ApplicationTypeID).Fees.ToString();
            application.PaidFees = Convert.ToInt16(lblFees.Text);
            application.ApplicantPersonID = clsPersonLogic.GetPerson(Convert.ToInt16(this.ctrFindLicense2.ctrLincesCard1.LicenseInformation.Rows[0]["PersonID"])).ID;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamgedApp.Checked) {
                lblTitlte.Text = "Replace Damaged License Application"; 
                application.ApplicationTypeID = Convert.ToByte(clsApplicationLogic.enApplicationTypes.ReplaceDamgedLicense);
            }

            else {
                lblTitlte.Text = "Replace Lost License Application"; 
                application.ApplicationTypeID = Convert.ToByte(clsApplicationLogic.enApplicationTypes.ReplaceLostLicense); 
            }


            CenterLabelToPictureBox();
        }

        private void CenterLabelToPictureBox()
        {
            // Assuming `pictureBox1` is your PictureBox and `label1` is your Label.

            int ctrFindLicensLeft = ctrFindLicense2.Left;
            int ctrFindLicensTop = ctrFindLicense2.Top;
            int ctrFindLicensWidth = ctrFindLicense2.Width;
            int ctrFindLicensHeight = ctrFindLicense2.Height;

            int labelWidth = lblTitlte.Width;

            // Center the Label horizontally relative to the PictureBox
            lblTitlte.Left = ctrFindLicensLeft + (ctrFindLicensWidth - labelWidth) / 2;

            // Position the Label below the PictureBox
            lblTitlte.Top = ctrFindLicensLeft + 10; // 10px spacing below the PictureBox
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void ctrFindLicense2_onLicenseFound(string obj)
        {
            lblOldLicenseID.Text = obj;
            btnShowLicenseHistory.Enabled = true;
            btnNext.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillApplicationInfo();
            if (clsLicenseLogic.IsLicenseActive(int.Parse(lblOldLicenseID.Text)))
            {
                if (application.Save())
                {
                    lblAppID.Text = application.ID.ToString();
                    int RepalcedID = clsLicenseLogic.ReplaceLicense(int.Parse(lblOldLicenseID.Text), application.ID, application.ApplicationTypeID, clsGloble.User.ID);
                    if (RepalcedID > 0)
                    {
                        MessageBox.Show("Data Saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblNewLicense.Text = RepalcedID.ToString();
                        clsLicenseLogic.DEactiveLicensedlg(int.Parse(lblOldLicenseID.Text));
                    }

                    else
                        MessageBox.Show("Data Didn't Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                    MessageBox.Show($"License Is With ID: {lblOldLicenseID.Text} Didn't Replaced", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

            else
            {
                MessageBox.Show($"License Is With ID: {lblOldLicenseID.Text} It's Not Active", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _FillTheBoxInformation()
        {
            lblUserName.Text = clsGloble.User.Username;
            lblFees.Text = clsApplicationTyesLogic.GetApplicationType(Convert.ToByte(clsApplicationLogic.enApplicationTypes.NewIntrnationlLicense)).Fees.ToString();
            lblDate.Text = DateTime.Now.ToShortDateString();


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _FillTheBoxInformation();

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnShowLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrFindLicense2.ctrLincesCard1.LicenseInformation.Rows[0]["NationalNo"].ToString());
            frm.ShowDialog();
        }
    }
}
