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
    public partial class frmScheduleTest : PerentForm
    {
        public frmScheduleTest(int LDLAppID, byte TestType = 1)
        {
            InitializeComponent();
            this.ctrScheduleTest1.InitializeControl(LDLAppID, TestType);
        }


        public frmScheduleTest() {
        
        }
        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void ctrAddVisionTest1_Load(object sender, EventArgs e)
        {

        }

        private void ctrAddTest1_Load(object sender, EventArgs e)
        {

        }

        private void ctrScheduleTest1_OnClosed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
