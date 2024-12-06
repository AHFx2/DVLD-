using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Screens.MISC;
using DVLD_Logic;

namespace DVLD_Interface.Controls.ctrMISC
{
    public partial class ctrScheduledTest : UserControl
    {
        DataTable Info;
        clsTestLogic test = new clsTestLogic();
        public ctrScheduledTest()
        {
            InitializeComponent();
            
        }

        public void InitializeControl(int ApoiID, clsTestTypesLogic TestType) 
        {
            Info = clsTestAppointmentLogic.GetAppointmentInfo(ApoiID);
            _FillInfo();
            _LoadTestImage(TestType.ID);
            lblTitle.Text = TestType.Title;
            CenterLabelToPictureBox();
        }
        private void _FillInfo()
        {
            test.TestResult = 1; // by defualt
            
            if (Info != null && Info.Rows.Count > 0)
            {
                foreach (DataRow row in Info.Rows)
                {
                    lblLDLAppID.Text = row["LocalDrivingLicenseApplicationID"].ToString();
                    lblClassName.Text = row["ClassName"].ToString();
                    lblDate.Text = Convert.ToDateTime(row["AppointmentDate"]).ToShortDateString();
                    lblFees.Text = row["PaidFees"].ToString();
                    lblPersonName.Text = row["FullName"].ToString();
                    test.ApoitmetnID = Convert.ToInt16(row["TestAppointmentID"]);
                   
                }
            }
        }

        private void AddTest()
        {
            test.Notes = txtNotes.Text;
            test.UserID = clsGloble.User.ID;

        }

        private void ctrTakeTest_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            test.TestResult = 1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            test.TestResult = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure U Want To Add this Test", "!!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                AddTest();
            if (test.Save())
            {
                MessageBox.Show("Data Saved Succefuly!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            else
            {
                MessageBox.Show("Didn't Saved Succefully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void _LoadTestImage(byte TestTypeID)
        {
            switch (TestTypeID)
            {

                case 1:
                    pTestImage.Image = Properties.Resources.Vision_512;
                    break;
                case 2:
                    pTestImage.Image = Properties.Resources.Written_Test_512;
                    break;

                case 3:
                    pTestImage.Image = Properties.Resources.driving_test_512;
                    break;
            }

        }
        private void CenterLabelToPictureBox()
        {
            // Assuming `pictureBox1` is your PictureBox and `label1` is your Label.

            int pictureLeft = pTestImage.Left;
            int pictureTop = pTestImage.Top;
            int pictureWidth = pTestImage.Width;
            int pictureHeight = pTestImage.Height;

            int labelWidth = lblTitle.Width;

            // Center the Label horizontally relative to the PictureBox
            lblTitle.Left = pictureLeft + (pictureWidth - labelWidth) / 2;

            // Position the Label below the PictureBox
            lblTitle.Top = pictureTop + pictureHeight + 10; // 10px spacing below the PictureBox
        }

    }
  


}
