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
using DVLD_Interface.Screens.MISC;
using DVLD_Interface.Screens.Tests;

namespace DVLD_Interface.Applications.Local_Drinving_License_Application
{
    public partial class frmLocalDrvingLicenseApplicationsList: Form
    {
      
        public frmLocalDrvingLicenseApplicationsList()
        {
            InitializeComponent();
        }

        private DataTable _dtLocalApplications;

        private void _LoadDataGridView()
        {
            dgvLDLApp.Rows.Clear();
            foreach (DataRowView row in _dtLocalApplications.DefaultView)
            {
                dgvLDLApp.Rows.Add(row["LocalDrivingLicenseApplicationID"], row["ClassName"], row["NationalNo"], row["FullName"], Convert.ToDateTime(row["ApplicationDate"]).ToShortDateString(), row["PassedTestCount"], row["Status"]);
            }
        }

        private void _FilterGrid(string TextChanged)
        {
            if (TextChanged != "")
            {

                if (ctrFiltredList1.Item == "Local Driving License Application ID")
                {
                    _dtLocalApplications.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} = {TextChanged}";
                }
                else
                {
                    _dtLocalApplications.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} Like '{TextChanged}%'";
                }

            }

            else
                _dtLocalApplications.DefaultView.RowFilter = "";

            _LoadDataGridView();
        }

        private void frmLocalDrvingLicenseApplicationsList_Load(object sender, EventArgs e)
        {
            _dtLocalApplications = DVLD_Logic.clsLocalDrivingLicenseApplicationLogic.GetAllLocalDrivingLicenseApplications();

            this.ctrFiltredList1.Items = new List<string> { "",
                                                        "Local Driving License Application ID",
                                                        "National No",
                                                        "Full Name",
                                                        "Status"
                                                        };

            _LoadDataGridView();
        }

        private string _ColumnWithoutSpace()
        {
            // this function will remove the spaces from the items
            switch (ctrFiltredList1.Item)
            {
                case "Local Driving License Application ID":
                    return "LocalDrivingLicenseApplicationID";

                case "National No":
                    return "NationalNo";

                case "Full Name":
                    return "FullName";

                case "Status":
                    return "Status";

                default:
                    return "None";

            }
        }

        private void sechulVesionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestApoitments frmApoitments = new frmTestApoitments(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value), 1);
            frmApoitments.ShowDialog();
        }
        private void sechulStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestApoitments frmApoitments = new frmTestApoitments(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value), 3);
            frmApoitments.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseCard licenseCard = new frmLicenseCard();
            licenseCard.InitializeByLDLID(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value));
            licenseCard.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory History = new frmShowPersonLicenseHistory(dgvLDLApp.CurrentRow.Cells[2].Value.ToString());
            History.ShowDialog();
        }

        private void editAppToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalDrivingLicenseApplicationID = (int)dgvLDLApp.CurrentRow.Cells[0].Value;

            frmAddUpdateLocalDrivingLicenseApplication frm =
                            new frmAddUpdateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();

            frmLocalDrvingLicenseApplicationsList_Load(null, null);
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)dgvLDLApp.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the form again.
                    frmLocalDrvingLicenseApplicationsList_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)dgvLDLApp.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the form again.
                    frmLocalDrvingLicenseApplicationsList_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not cancel applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmLocalDrivingLicenseApplication_Info frm =
                       new frmLocalDrivingLicenseApplication_Info((int)dgvLDLApp.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            //refresh
            frmLocalDrvingLicenseApplicationsList_Load(null, null);
        }

        private void tsmiIssueDrivignFirstTime_Click(object sender, EventArgs e)
        {
            Licenses.Local_Licenses.frmIssueLicenseFirstTime frmIssueLicenseFirstTime = new Licenses.Local_Licenses.frmIssueLicenseFirstTime((int)dgvLDLApp.CurrentRow.Cells[0].Value);
            frmIssueLicenseFirstTime.ShowDialog();
        }
        private void ctrFiltredList1_onTextChanged_1(string obj)
        {
            _FilterGrid(obj);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLDLApp.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                    clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID
                                                    (LocalDrivingLicenseApplicationID);

            int TotalPassedTests = (int)dgvLDLApp.CurrentRow.Cells[5].Value;

            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            //Enabled only if person passed all tests and Does not have license. 
            tsmiIssueDrivignFirstTime.Enabled = (TotalPassedTests == 3) && !LicenseExists;

            showLicenseToolStripMenuItem.Enabled = LicenseExists;
            editAppToolStripMenuItem.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            toolStripScheduleTests1.Enabled = !LicenseExists;

            //Enable/Disable Cancel Menue Item
            //We only canel the applications with status=new.
            cancelApplicationToolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            //Enable/Disable Delete Menue Item
            //We only allow delete incase the application status is new not complete or Cancelled.
            deleteApplicationToolStripMenuItem.Enabled =
                (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);



            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.StreetTest);

            toolStripScheduleTests1.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            if (toolStripScheduleTests1.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                sechulVesionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                sechulWriteenTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                sechulStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }

        }

        private void sechulWriteenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLocalApplication_Click(object sender, EventArgs e)
        {

            frmAddUpdateLocalDrivingLicenseApplication frmAddLocalLicenes = new frmAddUpdateLocalDrivingLicenseApplication();
            frmAddLocalLicenes.ShowDialog();
            frmLocalDrvingLicenseApplicationsList_Load(null, null);
        }
    }
}

