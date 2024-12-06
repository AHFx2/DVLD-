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

namespace DVLD_Interface.Controls.ctrMISC
{
    public partial class ctrInterntionalLiceneCard : UserControl
    {
        public DataTable LicenseInformation;
        public ctrInterntionalLiceneCard()
        {
            InitializeComponent();
        }



        public void InitializeByLicenseID(int LicenseID)
        {
            LicenseInformation = new DataTable();
            LicenseInformation = clsInternationalLicenseLogic.GetLicenseByInterNationalLicenseID(LicenseID);
            if (LicenseInformation.Rows.Count > 0) { _FillInformation(); }
        }

        private void _FillInformation()
        {
            try
            {
                lblName.Text = LicenseInformation.Rows[0]["FullName"].ToString();
                lblInterntional.Text = LicenseInformation.Rows[0]["InternationalLicenseID"].ToString();
                lblLicenseID.Text = LicenseInformation.Rows[0]["LicenseID"].ToString();
                lblNatID.Text = LicenseInformation.Rows[0]["NationalNo"].ToString();
                pbImage.Tag = LicenseInformation.Rows[0]["ImagePath"].ToString();
                pbImage.Load(pbImage.Tag.ToString());
                lblGendro.Text = LicenseInformation.Rows[0]["Gendor"].ToString();
                lblIssueDate.Text = Convert.ToDateTime(LicenseInformation.Rows[0]["IssueDate"]).ToShortDateString();
                lblBirthDate.Text = Convert.ToDateTime(LicenseInformation.Rows[0]["DateOfBirth"]).ToShortDateString();
                lblEpiraationDate.Text = Convert.ToDateTime(LicenseInformation.Rows[0]["ExpirationDate"]).ToShortDateString();
                lblIssueReason.Text = LicenseInformation.Rows[0]["IssueReason"].ToString();
                lblNotes.Text = (LicenseInformation.Rows[0]["Notes"].ToString().Length > 0) ? LicenseInformation.Rows[0]["Notes"].ToString() : "No Notes";
                lblIsActive.Text = LicenseInformation.Rows[0]["IsActive"].ToString();
                lblDriverID.Text = LicenseInformation.Rows[0]["DriverID"].ToString();
                lblAppID.Text = LicenseInformation.Rows[0]["ApplicationID"].ToString();
            }

            catch { MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void ctrInterntionalLiceneCard_Load(object sender, EventArgs e)
        {

        }
    }
}
