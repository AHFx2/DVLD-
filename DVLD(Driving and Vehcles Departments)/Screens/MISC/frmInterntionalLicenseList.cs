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

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmInterntionalLicenseList : PerentForm
    {
        public frmInterntionalLicenseList()
        {
            InitializeComponent();
        }


        DataTable InterNationaApplicationsTable = DVLD_Logic.clsInternationalLicenseLogic.GetInternationalLicenses();
        private void _RefreshInterntionalAppList(string Condition = "")
        {


            DataView dv = InterNationaApplicationsTable.DefaultView;

            if (Condition != "")
                dv.RowFilter = Condition;


            dgvInterntionalApp.Rows.Clear();
            foreach (DataRowView row in dv)
            {
                dgvInterntionalApp.Rows.Add(row["InternationalLicenseID"], row["ApplicationID"], row["DriverID"], row["IssuedUsingLocalLicenseID"], row["IssueDate"], row["ExpirationDate"], Convert.ToBoolean(row["IsActive"]));
            }
        }

        private void frmInterntionalLicenseList_Load(object sender, EventArgs e)
        {
            this.ctrFiltredList1.Items = new List<string> {
                                                            "InternationalLicenseID",
                                                            "ApplicationID",
                                                            "DriverID",
                                                            "IssuedUsingLocalLicenseID"
                                                            };
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmInterntionalLicenseList_Shown(object sender, EventArgs e)
        {
            _RefreshInterntionalAppList();
        }

        private void ShowLicenseDetailes_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseCard frm = new frmInternationalLicenseCard(Convert.ToInt16(dgvInterntionalApp.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void ctrFiltredList1_onTextChanged(string obj)
        {
            _RefreshInterntionalAppList($"Convert({ctrFiltredList1.Item}, 'System.String') LIKE '%{obj}%'");
        }

        private void ShowPersonDetailes_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(DVLD_Logic.clsInternationalLicenseLogic.GetPersonIDByInternationalID(Convert.ToInt16(dgvInterntionalApp.CurrentRow.Cells[0].Value)));
            frm.ShowDialog();
        }

        private void ShowLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(DVLD_Logic.clsInternationalLicenseLogic.GetPersonIDByInternationalID(Convert.ToInt16(dgvInterntionalApp.CurrentRow.Cells[0].Value)));
            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicense frm = new frmAddInternationalLicense();
            frm.ShowDialog();
        }
    }
}
