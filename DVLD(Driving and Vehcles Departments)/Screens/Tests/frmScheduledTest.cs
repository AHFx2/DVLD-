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
using DVLD_Logic;

namespace DVLD_Interface.Screens.Tests
{
    public partial class frmScheduledTest : PerentForm
    {
        public frmScheduledTest()
        {
            InitializeComponent();
        }

        public frmScheduledTest(int ApoiID, clsTestTypesLogic TestType)
        {
            InitializeComponent();
            this.ctrTakeTest1.InitializeControl(ApoiID,TestType);
            
        }

        private void frmAddTest_Load(object sender, EventArgs e)
        {

        }

        private void ctrTakeTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
