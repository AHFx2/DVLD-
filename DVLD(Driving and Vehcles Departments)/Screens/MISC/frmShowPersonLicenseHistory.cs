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

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmShowPersonLicenseHistory : PerentForm
    {
        public frmShowPersonLicenseHistory()
        {
            InitializeComponent();
        }

        DataTable LicensesHistory ;
        DataTable InternationalLiHistory ;
        public frmShowPersonLicenseHistory(string NatID)
        {
            InitializeComponent();
            this.ctrPersonDetails1.Initialize(NatID);
            LicensesHistory = DVLD_Logic.clsLicenseLogic.GetLicenseHistoryByNatID(NatID);
            InternationalLiHistory = clsInternationalLicenseLogic.GetInternationalLicenseHistoryByNatID(NatID);
        }

        public frmShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            this.ctrPersonDetails1.Initialize(PersonID);
            LicensesHistory = DVLD_Logic.clsLicenseLogic.GetLicenseHistoryByPersonID(PersonID);
            InternationalLiHistory = clsInternationalLicenseLogic.GetInternationalLicenseHistoryByPersonID(PersonID);
        }


        private void _RefrshLicenseHistory()
        {


         
            dgvILhistory.Rows.Clear();
            dgvLicensesHistory.Rows.Clear();
            for (byte i = 0; i < LicensesHistory.Rows.Count || i < InternationalLiHistory.Rows.Count; i++)
            {
                if ( i < LicensesHistory.Rows.Count)
                {
                    dgvLicensesHistory.Rows.Add(LicensesHistory.Rows[i]["LicenseID"], LicensesHistory.Rows[i]["ApplicationID"], LicensesHistory.Rows[i]["ClassName"], Convert.ToDateTime(LicensesHistory.Rows[i]["IssueDate"]), Convert.ToDateTime(LicensesHistory.Rows[i]["ExpirationDate"]), Convert.ToBoolean(LicensesHistory.Rows[i]["IsActive"]));
                }
                if (i < InternationalLiHistory.Rows.Count)
                {
                    dgvILhistory.Rows.Add(InternationalLiHistory.Rows[i]["InternationalLicenseID"], InternationalLiHistory.Rows[i]["ApplicationID"], InternationalLiHistory.Rows[i]["IssuedUsingLocalLicenseID"], Convert.ToDateTime(InternationalLiHistory.Rows[i]["IssueDate"]), Convert.ToDateTime(InternationalLiHistory.Rows[i]["ExpirationDate"]), Convert.ToBoolean(InternationalLiHistory.Rows[i]["IsActive"]));
                }
            }
        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {

        }

        private void frmShowPersonLicenseHistory_Shown(object sender, EventArgs e)
        {
            _RefrshLicenseHistory();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ctrPersonDetails1_Load(object sender, EventArgs e)
        {

        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmLicenseCard frm = new frmLicenseCard();

            frm.InitializeByLicenseID(Convert.ToInt16(dgvLicensesHistory.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLicenseCard frm = new frmLicenseCard();
            frm.InitializeByLicenseID(Convert.ToInt16(dgvLicensesHistory.CurrentRow.Cells[2].Value));

            frm.ShowDialog();

        }

        private void dgvILhistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
