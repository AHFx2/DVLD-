using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Screens.Tests;
using DVLD_Logic;

namespace DVLD_Interface.Controls.ctrMISC
{
    public partial class ctrClintTestsAppointments : UserControl
    {
        public int LDLApp { get; set; }
        public byte TestType { get; set; }



        public ctrClintTestsAppointments()
        {
            InitializeComponent();


        }

        DataTable TestApoitments;

        private clsTestTypesLogic _Testtype;
        public void Initialize(int LdLApp, byte Testtype = 1)
        {
            this.LDLApp = LdLApp;
            this.TestType = Testtype;   
            this.ctrLDLAppInfo1.Initialize(LdLApp);
            _Testtype = clsTestTypesLogic.GetTestTypeByID(Convert.ToByte(this.TestType));
            lblTitle.Text = _Testtype.Title + " " + "Appoitments";
            CenterLabelToPictureBox();
            _RefreshAppoitmestList();
            _LoadTestImage(Testtype);
            

        }

        private void _RefreshAppoitmestList(string Condition = "")
        {
            TestApoitments = DVLD_Logic.clsTestAppointmentLogic.GetApointments();


            DataRow[] rows = TestApoitments.Select($"LocalDrivingLicenseApplicationID = {LDLApp} and TestTypeTitle = '{_Testtype.Title}'");

            dgvAppointMents.Rows.Clear();
            foreach (DataRow row in rows)
            {
                dgvAppointMents.Rows.Add(row["TestAppointmentID"], Convert.ToDateTime(row["AppointmentDate"]).ToShortDateString(), row["PaidFees"], row["IsLocked"]);
            }
        }

        private void ctrLDLAppInfo1_Load(object sender, EventArgs e)
        {
            _RefreshAppoitmestList();
        }


        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Convert.ToInt16(dgvAppointMents.CurrentRow.Cells[3].Value)))
            {
                MessageBox.Show("Locked U can't Take The test");
            }
            else
            {
                frmScheduledTest frmAddTest = new frmScheduledTest(Convert.ToInt16(dgvAppointMents.CurrentRow.Cells[0].Value), this._Testtype);
                frmAddTest.ShowDialog();
                _RefreshAppoitmestList();
            }
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            frmUpdateAppointmentForTest frmUpdateTest = new frmUpdateAppointmentForTest(Convert.ToInt16(dgvAppointMents.CurrentRow.Cells[0].Value), this.LDLApp);
            frmUpdateTest.ShowDialog();
            _RefreshAppoitmestList();
            
        }

  
        private void ctrLDLAppInfo1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //adding 
            frmScheduleTest test = new frmScheduleTest(this.LDLApp, Convert.ToByte(this.TestType));

            if (test.ctrScheduleTest1.apoinmentsLogic.IsThereUnlockedAppointment())
            {
                MessageBox.Show("Person Already Have an Active Appointment For This Test, You Cannot Add New Appointment");
            }
            else if (test.ctrScheduleTest1.apoinmentsLogic.IsTherePassedApointments())
                MessageBox.Show("This Person Already Passed The Test Before, You Can Only ReTake Failed Test");


            else if (test.ctrScheduleTest1.apoinmentsLogic.IsThereFailedApointments())
            {
                // the appointment is locked and the person failed 
                test.ctrScheduleTest1.InitializeGroupBox();
                test.ctrScheduleTest1.lblTestTitle.Text = "Schedule Retake Test";
                test.ShowDialog();
                _RefreshAppoitmestList();

            }

            else // there is no Appointment
            {
                test.ShowDialog();
                _RefreshAppoitmestList();

            }
        }


        private void _LoadTestImage(byte TestTypeID)
        {
            switch (TestTypeID)
            {

                case 1:
                    pIcon.Image = Properties.Resources.Vision_512;
                    break;
                case 2:
                    pIcon.Image = Properties.Resources.Written_Test_512;
                    break;

                case 3:
                    pIcon.Image = Properties.Resources.driving_test_512;
                    break;
            }

        }

        private void CenterLabelToPictureBox()
        {
            // Assuming `pictureBox1` is your PictureBox and `label1` is your Label.

            int pictureLeft = pIcon.Left;
            int pictureTop = pIcon.Top;
            int pictureWidth = pIcon.Width;
            int pictureHeight = pIcon.Height;

            int labelWidth = lblTitle.Width;

            // Center the Label horizontally relative to the PictureBox
            lblTitle.Left = pictureLeft + (pictureWidth - labelWidth) / 2;

            // Position the Label below the PictureBox
            lblTitle.Top = pictureTop + pictureHeight - 5; // 10px spacing below the PictureBox
        }


        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAppoitments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
