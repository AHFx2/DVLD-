using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Controls;
using DVLD_Interface.Controls.ctrMISC;

namespace DVLD_Interface.Screens.Tests
{
    public partial class frmUpdateAppointmentForTest : PerentForm
    {
        public frmUpdateAppointmentForTest()
        {
            InitializeComponent();
        }

        public frmUpdateAppointmentForTest(int AppointmentID, int LDLappID)
        {
            InitializeComponent();
         
            this.ctrScheduleTest1.InitializeControl(LDLappID);
            ctrScheduleTest1.UpdateAppointment(AppointmentID);
        }

        private void frmUpdateTest_Load(object sender, EventArgs e)
        {

        }

        private void ctrAddAppointmentForTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
