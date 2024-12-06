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

namespace DVLD_Interface.Controls.ctrMISC
{
    public partial class ctrRenewLicense : UserControl
    {
        DVLD_Logic.clsApplicationLogic application = null;
        public ctrRenewLicense()
        {
            InitializeComponent();
        }

        private void _FillInterNationalicesnApplicationInfo()
        {
            application = new clsApplicationLogic();
            application.ApplicationTypeID = Convert.ToByte(clsApplicationLogic.enApplicationTypes.NewIntrnationlLicense);
            application.ApplicationStatus = 1;
            application.LaststautDate = DateTime.Now;
            application.ApplicationDate = DateTime.Now;
            application.UserCreatIt = clsGloble.User.ID;
            lblAppFees.Text = clsApplicationTyesLogic.GetApplicationType(application.ApplicationTypeID).Fees.ToString();
            application.PaidFees = Convert.ToInt16(lblAppFees.Text);
            application.ApplicantPersonID = clsPersonLogic.GetPerson(Convert.ToInt16(this.ctrFindLicense1.ctrLincesCard1.LicenseInformation.Rows[0]["PersonID"])).ID;

        }


        private void ctrFindLicense1_onLicenseFound(string obj)
        {
            // obj -> is the license id

            if (!clsLicenseLogic.IsEpiredLicense(int.Parse(obj)))
            {
                btnRenew.Enabled = false;
                MessageBox.Show($"Selected License it's not expired yet it will expired on {ctrFindLicense1.ctrLincesCard1.LicenseInformation.Rows[0]["ExpirationDate"]}", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                btnRenew.Enabled = true;
                lblOldLicenseID.Text = obj;
                _FillInterNationalicesnApplicationInfo();
            }
                btnShowLicenseHistory.Enabled = true;
        }

        private void _FillTheBoxInformation()
        {
            lblUserName.Text = clsGloble.User.Username;
            lblAppFees.Text = clsApplicationTyesLogic.GetApplicationType(Convert.ToByte(clsApplicationLogic.enApplicationTypes.NewIntrnationlLicense)).Fees.ToString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblEpirtationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblAppFees.Text = clsApplicationTyesLogic.GetApplicationType(Convert.ToByte(clsApplicationLogic.enApplicationTypes.RenewLicense)).Fees.ToString();
            lblLicenseFees.Text = clsLicenseClassLogic.GetLicenseByName(this.ctrFindLicense1.ctrLincesCard1.LicenseInformation.Rows[0]["ClassName"].ToString()).Fees.ToString();
            lblTotalFees.Text = Convert.ToInt16(int.Parse(lblLicenseFees.Text) + int.Parse(lblAppFees.Text)).ToString();
            
            
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clsLicenseLogic.IsLicenseActive(int.Parse(lblOldLicenseID.Text)))
            {

                    if (application.Save())
                    {

                        int NewLicenseID = clsLicenseLogic.RenewLicense(int.Parse(lblOldLicenseID.Text),application.ID, txtNotes.Text, Convert.ToInt16(lblLicenseFees.Text), clsGloble.User.ID);
                        if (NewLicenseID > 0)
                        {
                            lblRenewedLicenseID.Text = NewLicenseID.ToString();
                            MessageBox.Show("Data Renewd License", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clsLicenseLogic.DEactiveLicensedlg(int.Parse(lblOldLicenseID.Text));
                            btnSave.Enabled = false;
                        btnShowNewLicenseInfo.Enabled = true;
                        }

                        else
                            MessageBox.Show("Wrong Not Renewd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }    

                    else
                        MessageBox.Show("Wrong Not Renewd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else
                MessageBox.Show("License Is Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            _FillTheBoxInformation();
            btnSave.Enabled = true;
            tabControl1.SelectedTab = tabPage2;
        }

        private void ctrFindLicense1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

   
        private void btnShowLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrFindLicense1.ctrLincesCard1.LicenseInformation.Rows[0]["NationalNo"].ToString());
            frm.ShowDialog();
        }

        private void btnShowNewLicenseInfo_Click_1(object sender, EventArgs e)
        {
            frmLicenseCard frm = new frmLicenseCard();
            frm.InitializeByLicenseID(int.Parse(lblRenewedLicenseID.Text));
            frm.ShowDialog();
        }
    }
}
