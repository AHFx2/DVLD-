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

namespace DVLD_Interface.Licenses.Local_Licenses.Controls
{
    public partial class ctrLicenseCardWithFilter : UserControl
    {

        public ctrLicenseCardWithFilter()
        {
            InitializeComponent();
        }
        // Define a custom event handler delegate with parameters
        public event Action<int> OnLicenseSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID); // Raise the event with the parameter
            }
        }

      
        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                ctrFiltredList1.Enabled = _FilterEnabled;
            }
        }

        private int _LicenseID = -1;

        public int LicenseID
        {
            get { return ctrLicenseInof1.LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        { get { return ctrLicenseInof1.SelectedLicenseInfo; } }

        public void LoadLicenseInfo(int LicenseID)
        {


            ctrFiltredList1.txtFilterText.Text = LicenseID.ToString();
            ctrLicenseInof1.LoadInfo(LicenseID);
            _LicenseID = ctrLicenseInof1.LicenseID;
            if (OnLicenseSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnLicenseSelected(_LicenseID);


        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

        }

      

        public void txtLicenseIDFocus()
        {
            ctrFiltredList1.txtFilterText.Focus();
        }

        private void txtLicenseID_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider2 = new ErrorProvider();
            if (string.IsNullOrEmpty(ctrFiltredList1.txtFilterText.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider2.SetError(ctrFiltredList1.txtFilterText, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(ctrFiltredList1.txtFilterText, null);
            }
        }

        
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrFiltredList1.txtFilterText.Focus();
                return;

            }
            _LicenseID = int.Parse(ctrFiltredList1.txtFilterText.Text);
            LoadLicenseInfo(_LicenseID);
        }
    }
}
