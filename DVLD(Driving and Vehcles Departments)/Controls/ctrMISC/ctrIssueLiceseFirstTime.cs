using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Logic;

namespace DVLD_Interface.Controls.ctrMISC
{
    public partial class ctrIssueLiceseFirstTime : UserControl
    {
        public ctrIssueLiceseFirstTime()
        {
            InitializeComponent();
        }

        public void Initialize(int LDLappID) { 
        
            this.ctrLDLAppInfo1.Initialize(LDLappID);
        
        }
 
        private clsDriverLogic AddDriver()
        {
            clsDriverLogic driver = new clsDriverLogic();
            driver.CreatedDate = DateTime.Now;
            driver.CreatedUserID = clsGloble.User.ID;
            driver.PersonID = Convert.ToInt16(ctrLDLAppInfo1.Info.Rows[0]["PersonID"]);

            if (!clsDriverLogic.IsPersonDriver(driver.PersonID))
            {
                if (driver.Save())
                {
                    return driver;
                }

            }
            
            return clsDriverLogic.GetDriverByPersonID(driver.PersonID);

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            clsLicenseLogic licenseLogic = new clsLicenseLogic();

            licenseLogic.CreatedByUserID = clsGloble.User.ID;
            licenseLogic.IssueDate = DateTime.Now;
            licenseLogic.ExpirationDate = DateTime.Now.AddYears(Convert.ToByte(ctrLDLAppInfo1.Info.Rows[0]["DefaultValidityLength"]));
            licenseLogic.IsActive = 1; 
            licenseLogic.PaidFees = Convert.ToInt16(ctrLDLAppInfo1.Info.Rows[0]["ClassFees"]);
            licenseLogic.Notes = txtNotes.Text;
            licenseLogic.ApplicationID = Convert.ToInt16(ctrLDLAppInfo1.Info.Rows[0]["ApplicationID"]);
            licenseLogic.IssueReason = 1;
            licenseLogic.DriverID = AddDriver().ID;
            licenseLogic.LicenseClassID = Convert.ToByte(ctrLDLAppInfo1.Info.Rows[0]["LicenseClassID"]);

            if (licenseLogic.Save())
            {
                MessageBox.Show($"Licese Issued and it ID = {licenseLogic.ID}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else MessageBox.Show($"Not Issued Mistake", "Mistake", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ctrIssueLiceseFirstTime_Load(object sender, EventArgs e)
        {

        }

        private void ctrLDLAppInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
