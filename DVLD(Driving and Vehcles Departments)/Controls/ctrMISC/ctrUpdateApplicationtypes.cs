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

namespace DVLD_Interface.Controls.ctrMISC
{
    public partial class ctrUpdateApplicationtypes : UserControl
    {
        clsApplicationTyesLogic applicationTyes;
        public byte ID { get; set; }
        public ctrUpdateApplicationtypes()
        {
            InitializeComponent();
        }

        public void Initialize(byte ID)
        {

            this.ID = ID;
            applicationTyes = clsApplicationTyesLogic.GetApplicationType(this.ID);

            this.lblID.Text = applicationTyes.ID.ToString();
            this.txtFee.Text = applicationTyes.Fees.ToString();
            this.txtTitle.Text = applicationTyes.Title.ToString();

        }



        private void ctrUpdateApplicationtypes_Load(object sender, EventArgs e)
        {
           

        }


        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void _Update()
        {
            applicationTyes.ID = this.ID;
            applicationTyes.Fees = Convert.ToDouble(txtFee.Text);
            applicationTyes.Title = this.txtTitle.Text;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _Update();
            if (applicationTyes.Save())
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
