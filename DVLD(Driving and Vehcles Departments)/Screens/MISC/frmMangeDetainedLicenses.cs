using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Driving_and_Vehcles_Departments_.Screens;
using DVLD_Logic;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmMangeDetainedLicenses : PerentForm
    {
        public frmMangeDetainedLicenses()
        {
            InitializeComponent();
        }
        DataTable DetainedLicensese;
        private void _RefreshDetainedLicensesList(string Condition = "")
        {

            DetainedLicensese = DVLD_Logic.clsDetainedLicenseLogic.GetDetainedLicenses();

            DataView dv = DetainedLicensese.DefaultView;

            if (Condition != "")
                dv.RowFilter = Condition;


            dgvLDLApp.Rows.Clear();
            foreach (DataRowView row in dv)
            {
                dgvLDLApp.Rows.Add(row["NationalNo"], row["FullName"], row["DetainID"], row["LicenseID"], Convert.ToDateTime(row["DetainDate"]).ToShortDateString(), row["FineFees"],  (row["ReleaseApplicationID"] == DBNull.Value) ? "Null" : row["ReleaseApplicationID"], (row["ReleaseDate"] == DBNull.Value) ? "Null" : Convert.ToDateTime(row["ReleaseDate"]).ToShortDateString(), row["FineFees"], Convert.ToBoolean(row["IsReleased"]));
            }
        }

        private void frmMangeDetainedLicenses_Load(object sender, EventArgs e)
        {
            this.ctrFiltredList1.Items = new List<string>() { "Detain ID", "Full Name", "National No", "Release Application ID" };
        }

        private void frmMangeDetainedLicenses_Shown(object sender, EventArgs e)
        {
            _RefreshDetainedLicensesList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReleaseDetain frmReleaseDetain = new frmReleaseDetain();
            frmReleaseDetain.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void ctrFiltredList1_onTextChanged(string obj)
        {
            _RefreshDetainedLicensesList($"Convert({ctrFiltredList1.Item}, 'System.String') LIKE '%{obj}%'");

        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(clsPersonLogic.GetPerson(dgvLDLApp.CurrentRow.Cells[0].Value.ToString()).ID);
            frm.ShowDialog();   
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(dgvLDLApp.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseCard frm = new frmLicenseCard();
            frm.InitializeByLicenseID(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[3].Value));
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetain  frm = new frmReleaseDetain();
            frm.ShowDialog();
        }

        //private void contextMenuStrip1_Opened(object sender, EventArgs e)
        //{
        //    if (clsDetainedLicenseLogic.IsDetainedLicense(Convert.ToInt16(dgvLDLApp.CurrentRow.Cells[3].Value)))
        //    {
        //        releaseDetainedLicenseToolStripMenuItem.Enabled = true;
        //    }

        //    else
        //    {
        //        releaseDetainedLicenseToolStripMenuItem.Enabled=false;
        //    }
        //}
    }
}
