using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.People;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmInterntionalLicenseList : PerentForm
    {
        public frmInterntionalLicenseList()
        {
            InitializeComponent();
        }


        DataTable _dtInternationalLicenses/* = DVLD_Logic.clsInternationalLicenseLogic.GetInternationalLicenses()*/;
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


                if (ctrFiltredList1.Item == "Person ID")
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

        private void frmInterntionalLicenseList_Load(object sender, EventArgs e)
        {
            this.ctrFiltredList1.Items = new List<string> {
                                                            "InternationalLicense ID",
                                                            "Application ID",
                                                            "Driver ID",
                                                            "IssuedUsingLocalLicense ID"
                                                            };
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmInterntionalLicenseList_Shown(object sender, EventArgs e)
        {
            _LoadGridData();
        }

        private void ShowLicenseDetailes_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseCard frm = new frmInternationalLicenseCard(Convert.ToInt16(dgvInterntionalApp.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        
        private void ShowPersonDetailes_Click(object sender, EventArgs e)
        {
            //frmShowPersonInfo frm = new frmShowPersonInfo(DVLD_Logic.clsInternationalLicenseLogic.GetPersonIDByInternationalID(Convert.ToInt16(dgvInterntionalApp.CurrentRow.Cells[0].Value)));
            //frm.ShowDialog();
        }

        private void ShowLicenseHistory_Click(object sender, EventArgs e)
        {
            //frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(DVLD_Logic.clsInternationalLicenseLogic.GetPersonIDByInternationalID(Convert.ToInt16(dgvInterntionalApp.CurrentRow.Cells[0].Value)));
            //frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicense frm = new frmAddInternationalLicense();
            frm.ShowDialog();
        }
    }
}
