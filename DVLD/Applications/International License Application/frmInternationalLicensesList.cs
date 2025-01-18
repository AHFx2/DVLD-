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
using DVLD_Interface.Licenses;
using DVLD_Interface.People;

namespace DVLD_Interface.Applications.International_License_Application
{
    public partial class frmInternationalLicensesList : Form
    {
        private DataTable _dtInternationalLicenses;
        public frmInternationalLicensesList()
        {
            InitializeComponent();
        }

        private void _LoadGridData()
        {
            dgvInterntionalApp.Rows.Clear();
            foreach (DataRowView row in _dtInternationalLicenses.DefaultView)
            {
                dgvInterntionalApp.Rows.Add(row["InternationalLicenseID"], row["ApplicationID"], row["DriverID"], row["IssuedUsingLocalLicenseID"], row["IssueDate"], row["ExpirationDate"], Convert.ToBoolean(row["IsActive"]));
            }
        }

        private string _ColumnWithoutSpace()
        {
            // this function will remove the spaces from the items
            switch (ctrFiltredList1.Item)
            {
                case "InternationalLicense ID":
                    return "InternationalLicenseID";

                case "Application ID":
                    return "ApplicationID";

                case "Driver ID":
                    return "DriverID";

                case "IssuedUsingLocalLicense ID":
                    return "IssuedUsingLocalLicenseID";

                default:
                    return "None";

            }
        }

        private void _FilterGrid(string TextChanged)
        {
            if (TextChanged != "")
            {


                if (ctrFiltredList1.Item == "Driver ID")
                {
                    _dtInternationalLicenses.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} = {TextChanged}";
                }
                else
                {
                    _dtInternationalLicenses.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} Like '{TextChanged}%'";
                }

            }

            else
                _dtInternationalLicenses.DefaultView.RowFilter = "";

            _LoadGridData();
        }

        private void frmInternationalLicensesList_Load(object sender, EventArgs e)
        {

            this.ctrFiltredList1.Items = new List<string> {
                                                            "InternationalLicense ID",
                                                            "Application ID",
                                                            "Driver ID",
                                                            "IssuedUsingLocalLicense ID"
                                                            };

            _dtInternationalLicenses = clsInternationalLicense.GetAllInternationalLicenses();

            _LoadGridData() ;
        }

        private void ShowPersonDetailes_Click(object sender, EventArgs e)
        {
            People.frmShowPersonInfo frm = new People.frmShowPersonInfo(dgvInterntionalApp.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }

        private void ShowLicenseDetailes_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(clsDriver.FindByDriverID((int)dgvInterntionalApp.CurrentRow.Cells[2].Value).PersonID);
            frm.ShowDialog();
        }

        private void ShowLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(clsDriver.FindByDriverID((int)dgvInterntionalApp.CurrentRow.Cells[2].Value).PersonID);
            frm.ShowDialog();
        }

        private void ctrFiltredList1_onTextChanged(string obj)
        {
            _FilterGrid(obj);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
