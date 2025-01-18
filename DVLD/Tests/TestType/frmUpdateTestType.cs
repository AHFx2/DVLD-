using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.GlobalClasses;
using DVLD_Logic;

namespace DVLD_Interface.Screens.Tests
{
    public partial class frmUpdateTestType : Form
    {
        private clsTestTypeLogic.enTestType _TestTypeID { get; set; }
        private clsTestTypeLogic _TestType;
        public frmUpdateTestType(clsTestTypeLogic.enTestType ID)
        {
            InitializeComponent();
            _TestTypeID = ID;
        }
        private void frmUpdateTestType_Load_1(object sender, EventArgs e)
        {
            this.lblID.Text = _TestTypeID.ToString();
            _TestType = clsTestTypeLogic.GetTestTypeByID(_TestTypeID);

            if (_TestType == null)
            {
                MessageBox.Show($"Test Type With ID {_TestTypeID} Not Found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.txtDescription.Text = _TestType.Descritpion;
            this.txtFees.Text = _TestType.Fees.ToString();
            this.txtTitle.Text = _TestType.Title;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Fill The Feild With Red Icon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _TestType.Fees = Convert.ToDouble(txtFees.Text);
            _TestType.Title = txtTitle.Text;

            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Succefully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
                MessageBox.Show("Data Didn't Save Succefully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);
        }

    }
}
