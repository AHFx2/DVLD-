using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Licenses.Controls;

namespace DVLD_Interface.Licenses
{
    public partial class frmShowPersonLicensesHistory : Form
    {
        private int _PersonID = -1;

        public frmShowPersonLicensesHistory()
        {
            InitializeComponent();


        }

        public frmShowPersonLicensesHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {

            if (_PersonID != -1)
            {
                ctrFindPerson1.LoadPersonInfo(_PersonID);
                ctrFindPerson1.FilterEnabled = false;
                ctrDriverLicenses1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                ctrFindPerson1.Enabled = true;
                ctrFindPerson1.FilterFocus();
            }



        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1)
            {
                ctrDriverLicenses1.Clear();
            }
            else
                ctrDriverLicenses1.LoadInfoByPersonID(_PersonID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
