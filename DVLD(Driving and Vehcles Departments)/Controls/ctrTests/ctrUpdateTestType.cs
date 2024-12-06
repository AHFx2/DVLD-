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

namespace DVLD_Interface.Controls.ctrTests
{
    public partial class ctrUpdateTestType : UserControl
    {
        clsTestTypesLogic testtype;
        public byte ID { get; set; }
        public ctrUpdateTestType()
        {
            InitializeComponent();
        }

        public void Initialize(byte ID)
        {

            this.ID = ID;
            testtype = clsTestTypesLogic.GetTestTypeByID(this.ID);

            this.lblID.Text = testtype.ID.ToString();
            this.txtFees.Text = testtype.Fees.ToString();
            this.txtTitle.Text = testtype.Title.ToString();
            this.txtDescription.Text = testtype.Descritpion.ToString();

        }

        private void _Update()
        {
            testtype.ID = this.ID;
            testtype.Fees = Convert.ToDouble(txtFees.Text);
            testtype.Title = this.txtTitle.Text;
            testtype.Descritpion = this.txtDescription.Text;
        }

        private void ctrUpdateTestType_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Update();
            if (testtype.Save())
            {
                MessageBox.Show("Data Saved Succefully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Data Didn't Save Succefully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
