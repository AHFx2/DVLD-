using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Screens.Tests;
using DVLD_Interface.Screens.User;
using DVLD_Logic;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmLocalLicenseList : PerentForm
    {
        public frmLocalLicenseList()
        {
            InitializeComponent();
        }


        DataTable LocalApplicationsTable;
        private void _RefreshLDLAppList(string Condition = "")
        {

            LocalApplicationsTable = DVLD_Logic.clsLocalLicenseApplicationLogic.GetLocalApplicationsApplications();

            DataView dv = LocalApplicationsTable.DefaultView;

            if (Condition != "")
                dv.RowFilter = Condition;


            dgvLDLApp.Rows.Clear();
            foreach (DataRowView row in dv)
            {
                dgvLDLApp.Rows.Add(row["LocalDrivingLicenseApplicationID"], row["ClassName"], row["NationalNo"], row["FullName"], Convert.ToDateTime(row["ApplicationDate"]).ToShortDateString(), row["PassedTestCount"], row["Status"]);
            }
        }


        private void frmLocalLicenseList_Load(object sender, EventArgs e)
        {
            this.ctrFiltredList1.Items = new List<string> { "",
                                                            "LocalDrivingLicenseApplicationID",
                                                            "NationalNo",
                                                            "FullName",
                                                            "Status"
                                                            };
        }

        private void frmLocalLicenseList_Shown(object sender, EventArgs e)
        {
            _RefreshLDLAppList();
        }

        private void ctrFiltredList1_onTextChanged(string obj)
        {
            _RefreshLDLAppList($"Convert({ctrFiltredList1.Item}, 'System.String') LIKE '%{obj}%'");
        }

        private void ctrFiltredList1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are U sure u want to cancel this application ??", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsLocalLicenseApplicationLogic.CancelApplication(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Application Canceled Succefully" , "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshLDLAppList();
                }

                else
                    MessageBox.Show("Application Not Canceled Succefully" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }

        private void sechulVesionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestApoitments frmApoitments = new frmTestApoitments(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value), 1);
            frmApoitments.ShowDialog();
        }
        private void sechulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestApoitments frmApoitments = new frmTestApoitments(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value), 2);
            frmApoitments.ShowDialog();
        }
        private void sechulStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestApoitments frmApoitments = new frmTestApoitments(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value), 3);
            frmApoitments.ShowDialog();
        }


        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            /* this function is responsble for enbling and desabing the contxt menue 
                1- make sure if the application is canceled and completed if yes then we desable the delete and the cancel and the edit itms
                if no then the status is new and we will determine the test that the person should take 
                after that we will check if the license is issued or not 
                if it was not issued we enble the issue license for first time and after issuing it for first time we enble the show license itme


             */


            //bool IsCompleted = DVLD_Logic.clsLocalLicenseApplicationLogic.IsApplicationCompleted(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value));
            //if (!(DVLD_Logic.clsLocalLicenseApplicationLogic.IsApplicationCanceled(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value)) || IsCompleted))
            //{
            //    _EnableANDdesableItms(true);
            //    tsmiIssueDrivignFirstTime.Enabled = false;
            //    showLicenseToolStripMenuItem.Enabled = false;
            //    sbyte TestTypeID = clsLocalLicenseApplicationLogic.DetermineTheTestTypeToTake(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value));

            //    toolStripScheduleTests1.Enabled = true;
            //    switch (TestTypeID)
            //    {
            //        case 0: // it's the first test for the person
            //            sechulVesionTestToolStripMenuItem.Enabled = true;
            //            break;

            //        case 1: // he passed the first test and he will take the second
            //            sechulVesionTestToolStripMenuItem.Enabled = false;
            //            sechulWriteenTestToolStripMenuItem.Enabled = true;
            //            break;

            //        case 2:// he passed the second test and he will take the third
            //            sechulWriteenTestToolStripMenuItem.Enabled = false;
            //            sechulStreetTestToolStripMenuItem.Enabled = true;
            //            break;

            //        case 3: // he passed the thrid test and we desble all items
            //            sechulVesionTestToolStripMenuItem.Enabled = false;
            //            sechulWriteenTestToolStripMenuItem.Enabled = false;
            //            sechulStreetTestToolStripMenuItem.Enabled = false;
            //            toolStripScheduleTests1.Enabled = false;

            //            /*here means the person passed the whole tests and we will check if the application status is complete if yes

            //             we will enble the show license itme so the person can see his license and desple the issue driver because he can't issue it 
            //             */
            //            if (IsCompleted)
            //            {
            //                showLicenseToolStripMenuItem.Enabled = true;
            //                tsmiIssueDrivignFirstTime.Enabled = false;
            //            }

            //            else
            //            {
            //                showLicenseToolStripMenuItem.Enabled = false;
            //                tsmiIssueDrivignFirstTime.Enabled = true;
            //            }

            //            break;
            //    }

            //}

            //else
            //{
            //    _EnableANDdesableItms(false);
            //    if (IsCompleted)
            //        showLicenseToolStripMenuItem.Enabled = true;

            //}
        }

        private void _EnableANDdesableItms(bool Value)
        {
            editAppToolStripMenuItem.Enabled = Value;
            cancelApplicationToolStripMenuItem.Enabled = Value;
            deleteApplicationToolStripMenuItem.Enabled = Value;
            showLicenseToolStripMenuItem.Enabled = Value;
            tsmiIssueDrivignFirstTime.Enabled = Value;
            toolStripScheduleTests1.Enabled = Value;
        }

        private void dgvLDLApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void isToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueLicense issueLicense = new frmIssueLicense(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value));
            issueLicense.ShowDialog();
            _RefreshLDLAppList();

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

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are U Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {   
                if (clsLocalLicenseApplicationLogic.DeleteLocalDrivingApplication(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[0].Value)))

                {
                    MessageBox.Show("Deleted Succefully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _RefreshLDLAppList();
            }
            else
            {
                MessageBox.Show("Didn't Delete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddLocalLicenes frmAddLocalLicenes = new frmAddLocalLicenes();
            frmAddLocalLicenes.ShowDialog();
            _RefreshLDLAppList();
        }

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void editAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
