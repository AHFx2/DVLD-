using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.Applications.Release_Detain_Application
{
    public partial class frmDetaindLicensesList : Form
    {
        private DataTable _dtDetainedLicenses;

        public frmDetaindLicensesList()
        {
            InitializeComponent();
        }

        private void frmDetaindLicensesList_Load(object sender, EventArgs e)
        {
            this.ctrFiltredList1.Items = new List<string>() { "Detain ID", "Full Name", "National No", "Release Application ID" };
            _dtDetainedLicenses = DVLD_Logic.clsDetainedLicenseLogic.GetDetainedLicenses();


            _LoadGridData();
        }

        private void _FilterGrid(string TextChanged)
        {
            if (TextChanged != "")
            {


                if (ctrFiltredList1.Item == "Detain ID")
                {
                    _dtDetainedLicenses.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} = {TextChanged}";
                }
                else
                {
                    _dtDetainedLicenses.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} Like '{TextChanged}%'";
                }

            }

            else
                _dtDetainedLicenses.DefaultView.RowFilter = "";

            _LoadGridData();
        }

        private string _ColumnWithoutSpace()
        {
            // this function will remove the spaces from the items
            switch (ctrFiltredList1.Item)
            {
                case "Detain ID":
                    return "DetainID";

                case "Full Name":
                    return "FullName";

                case "National No":
                    return "NationalNo";

                case "Release Application ID":
                    return "ReleaseApplicationID";

                default:
                    return "None";

            }
        }

        private void _LoadGridData()
        {
            dgvLDLApp.Rows.Clear();
            foreach (DataRowView row in _dtDetainedLicenses.DefaultView)
            {
                dgvLDLApp.Rows.Add(row["NationalNo"], row["FullName"], row["DetainID"], row["LicenseID"], Convert.ToDateTime(row["DetainDate"]).ToShortDateString(), row["FineFees"], (row["ReleaseApplicationID"] == DBNull.Value) ? "Null" : row["ReleaseApplicationID"], (row["ReleaseDate"] == DBNull.Value) ? "Null" : Convert.ToDateTime(row["ReleaseDate"]).ToShortDateString(), row["FineFees"], Convert.ToBoolean(row["IsReleased"]));
            }
        }

        private void ctrFiltredList1_onTextChanged(string obj)
        {
            _FilterGrid(obj);
        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
            releaseDetainedLicenseToolStripMenuItem.Enabled = Convert.ToBoolean(dgvLDLApp.CurrentRow.Cells[8].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReleaseDetainApplication frm = new frmReleaseDetainApplication((int)dgvLDLApp.CurrentRow.Cells[3].Value);
            frm.ShowDialog();

            frmDetaindLicensesList_Load(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Licenses.Detain_Licenses.frmDetainLicenses frm = new Licenses.Detain_Licenses.frmDetainLicenses();
            frm.ShowDialog();

            frmDetaindLicensesList_Load(null, null);
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainApplication frm = new frmReleaseDetainApplication((int)dgvLDLApp.CurrentRow.Cells[3].Value);
            frm.ShowDialog();

            frmDetaindLicensesList_Load(null, null);
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            Licenses.Detain_Licenses.frmDetainLicenses frm = new Licenses.Detain_Licenses.frmDetainLicenses();
            frm.ShowDialog();

            frmDetaindLicensesList_Load(null, null);
        }
    }
}
