using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmApplications : frmPerent2
    {
        public frmApplications()
        {
            InitializeComponent();
        }

        private void frmApplications_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

          
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localDrivngLicenesApplicantionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalLicenseList frmLocalLicenseList = new frmLocalLicenseList();

            frmLocalLicenseList.dgvLDLApp.RowTemplate.DefaultCellStyle.SelectionBackColor = SeetingsColor.PrimaryColor;
            frmLocalLicenseList.dgvLDLApp.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            frmLocalLicenseList.dgvLDLApp.ColumnHeadersDefaultCellStyle.BackColor = SeetingsColor.SecondaryColor;
            frmLocalLicenseList.dgvLDLApp.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            frmLocalLicenseList.dgvLDLApp.ColumnHeadersDefaultCellStyle.SelectionBackColor = SeetingsColor.SecondaryColor;
            frmLocalLicenseList.ShowDialog();
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            frmApplictinonsType ApplicationsTypes = new frmApplictinonsType();

            ApplicationsTypes.ShowDialog();
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            frmTestTypesList TestTypesList = new frmTestTypesList();
            TestTypesList.dgvTestTypes.RowTemplate.DefaultCellStyle.SelectionBackColor = SeetingsColor.PrimaryColor;
            TestTypesList.dgvTestTypes.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            TestTypesList.dgvTestTypes.ColumnHeadersDefaultCellStyle.BackColor = SeetingsColor.SecondaryColor;
            TestTypesList.dgvTestTypes.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            TestTypesList.dgvTestTypes.ColumnHeadersDefaultCellStyle.SelectionBackColor = SeetingsColor.SecondaryColor;
            TestTypesList.ShowDialog();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddLocalLicenes frm = new frmAddLocalLicenes();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicense frm = new frmAddInternationalLicense();
            frm.ShowDialog();
        }

        private void internationalDrivngLicenesApplicantionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInterntionalLicenseList frm = new frmInterntionalLicenseList();
            frm.ShowDialog();
        }

        private void renewDrivingLiceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicense frm = new frmRenewLicense();
            frm.ShowDialog();
        }

        private void replacementLiceneeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDamged_LostLicensesApplications frm = new frmDamged_LostLicensesApplications();
            frm.ShowDialog();
        }

        private void newDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void internationalLicenseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void renewDrivingLiceneToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void replacementLiceneeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void localDrivngLicenesApplicantionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void internationalDrivngLicenesApplicantionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void detaineLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void releToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetain frm = new frmReleaseDetain();
            frm.ShowDialog();
            
        }

        private void mangeDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMangeDetainedLicenses frm = new frmMangeDetainedLicenses();
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetain frm = new frmReleaseDetain();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalLicenseList frm = new frmLocalLicenseList();
            frm.ShowDialog();
        }
    }
}
