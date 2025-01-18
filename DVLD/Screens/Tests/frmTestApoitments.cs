using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Controls.ctrMISC;

namespace DVLD_Interface.Screens.Tests
{
    public partial class frmTestApoitments : PerentForm
    {
        public frmTestApoitments(int LDLApp, byte TestType)
        {
            InitializeComponent();
            this.ctrClintTestsAppointments1.Initialize(LDLApp, TestType);

        }



        private void frmVisionTest_Load(object sender, EventArgs e)
        {

        }

        private void frmVisionTestApoitments_Shown(object sender, EventArgs e)
        {
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
          

        }

        private void ctrLDLAppInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ctrClintTestsAppointments1_Load(object sender, EventArgs e)
        {

        }

        private void ctrClintTestsAppointments1_Load_1(object sender, EventArgs e)
        {

        }

        private void takeToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ctrClintTestsAppointments1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
