using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Controls.ctrMISC;
using DVLD_Interface.GlobalClasses;
using DVLD_Logic;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmUpdateApplicationType : Form
    {
        private byte _ApplicationTypeID { get; set; }
        private clsApplicationTypeLogic _ApplicationType;
        public frmUpdateApplicationType(byte ID)
        {
            InitializeComponent();
            _ApplicationTypeID = ID;
        }

        private void frmUpdateApplicationType_Load_1(object sender, EventArgs e)
        {
            this.lblID.Text = _ApplicationTypeID.ToString();
            _ApplicationType = clsApplicationTypeLogic.GetApplicationType(this._ApplicationTypeID);

            if (_ApplicationType != null)
            {
                this.lblID.Text = _ApplicationType.ID.ToString();
                this.txtFee.Text = _ApplicationType.Fees.ToString();
                this.txtTitle.Text = _ApplicationType.Title.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Fill The Feild With Red Icon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //_ApplicationType.Fees = Convert.ToDouble(txtFee.Text);
            _ApplicationType.Title = txtTitle.Text;

            if (_ApplicationType.Save())
            {
                MessageBox.Show("Data Saved Succefully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
                MessageBox.Show("Data Didn't Save Succefully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);
        }

        private void txtFee_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);

            clsValidation.SetErrorToNumberFeilds(sender, e);
        }
    }
}
