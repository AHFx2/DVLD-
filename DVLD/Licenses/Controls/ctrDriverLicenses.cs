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
using DVLD_Interface.Licenses.Local_Licenses;

namespace DVLD_Interface.Licenses.Controls
{
    public partial class ctrDriverLicenses : UserControl
    {
        private int _DriverID;
        private clsDriver _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;

        public ctrDriverLicenses()
        {
            InitializeComponent();
        }

        private void _LoadLocalLicenseInfo()
        {

            _dtDriverLocalLicensesHistory = clsDriver.GetLicenses(_DriverID);

            dgvLocalLicenses.Rows.Clear();
            foreach (DataRowView row in _dtDriverInternationalLicensesHistory.DefaultView)
            {
                dgvLocalLicenses.Rows.Add(row["LicenseID"], row["ApplicationID"], row["ClassName"], Convert.ToDateTime(row["IssueDate"]), Convert.ToDateTime(row["ExpirationDate"]), Convert.ToBoolean(row["IsActive"]));

            }


        }

        private void _LoadInternationalLicenseInfo()
        {

            _dtDriverInternationalLicensesHistory = clsDriver.GetLicenses(_DriverID);

            dgvInternationalLicenses.Rows.Clear();
            foreach (DataRowView row in _dtDriverInternationalLicensesHistory.DefaultView)
            {
                dgvInternationalLicenses.Rows.Add(row["InternationalLicenseID"], row["ApplicationID"], row["IssuedUsingLocalLicenseID"], Convert.ToDateTime(row["IssueDate"]), Convert.ToDateTime(row["ExpirationDate"]), Convert.ToBoolean(row["IsActive"]));

            }


        }

        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriver.FindByDriverID(_DriverID);

            if (_Driver == null) {
                MessageBox.Show($"No Driver With ID {DriverID} Plz Try Another One", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();

        }

        public void LoadInfoByPersonID(int PersonID)
        {

            _Driver = clsDriver.FindByPersonID(PersonID);

            if (_Driver == null)
            {
                MessageBox.Show($"No Driver With Person ID {PersonID} Plz Try Another One", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _DriverID = _Driver.DriverID;

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }

    

        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();
            _dtDriverInternationalLicensesHistory.Clear();
        }


        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvLocalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void InternationalLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            //frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            //frm.ShowDialog();

        }
    }

}