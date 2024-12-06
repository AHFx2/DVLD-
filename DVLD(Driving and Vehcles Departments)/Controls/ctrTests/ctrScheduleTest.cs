using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Logic;
using Guna.UI2.WinForms.Suite;

namespace DVLD_Interface.Controls.ctrMISC
{
    public partial class ctrScheduleTest : UserControl
    {
        DataTable Info;
        clsApplicationLogic application;
        public clsTestAppointmentLogic apoinmentsLogic = new clsTestAppointmentLogic();
        protected clsTestTypesLogic testtype;
        enum enMode { Add, Update, Retake };

        enMode mode = enMode.Add;

        public int DldbID { get; set; }
        public ctrScheduleTest()
        {

            InitializeComponent();
        }

        public event EventHandler OnClosed;
        protected virtual void On_Closed()
        {
            OnClosed?.Invoke(this, EventArgs.Empty);
        }

        public void InitializeGroupBox()
        { 
            this.guna2GroupBox1.Enabled =true;
            this.mode = enMode.Retake;
            _FillRetakeAppointmentInfo(); 
        }


 
        public void InitializeControl(int LDLAppID, byte TestType = 1)
        {
            this.DldbID = LDLAppID;
            Info = DVLD_Logic.clsLocalLicenseApplicationLogic.GetLDLAppInfo(LDLAppID);
            testtype = clsTestTypesLogic.GetTestTypeByID(TestType);
            this.dtpApointmentDate.MinDate = DateTime.Now.AddDays(1);
            _FillInfo();
            _FillTestAppointment();
        }
        public void UpdateAppointment(int AppointmentID)
        {
            apoinmentsLogic = clsTestAppointmentLogic.GetAppointmen(AppointmentID);
            if (apoinmentsLogic.IsAppointmentlocked()) // check if the Appointment locked if yes then you can't update locked Appointment
            {
                this.lblWarminglockedTest.Visible = true;
                this.dtpApointmentDate.Enabled = false;
                btnSave.Visible = false;
            }

            else
            {
                mode = enMode.Update;
            }
        }

        private void _FillRetakeAppointmentInfo()
        {
            application = new clsApplicationLogic();
            application.ApplicationTypeID = Convert.ToByte(clsApplicationLogic.enApplicationTypes.Reinspectionservice);
            application.ApplicationStatus = 1;
            application.LaststautDate = DateTime.Now;
            application.ApplicationDate = DateTime.Now;
            application.UserCreatIt = clsGloble.User.ID;
            application.ApplicantPersonID = clsPersonLogic.GetPerson(Info.Rows[0]["NationalNo"].ToString()).ID;
            lblRappFees.Text = clsApplicationTyesLogic.GetApplicationType(application.ApplicationTypeID).Fees.ToString();
            application.PaidFees = Convert.ToInt16(lblFees.Text) + Convert.ToInt16(lblRappFees.Text);
            lblTotalFees.Text = application.PaidFees.ToString();
            
        }
        
        private void _LoadTestImage(byte TestTypeID)
        {
            switch (TestTypeID) {

                case 1:
                    pTestLogo.Image = Properties.Resources.Vision_512;
                    break;
                case 2:
                    pTestLogo.Image = Properties.Resources.Written_Test_512;
                    break;

                case 3:
                    pTestLogo.Image = Properties.Resources.driving_test_512;
                    break;  
            }

        }
        
        private void _FillInfo()
        {
            dtpApointmentDate.MinDate = DateTime.Now;
            lblTestTitle.Text = testtype.Title;
            _LoadTestImage(testtype.ID);
            CenterLabelToPictureBox();
            if (Info != null && Info.Rows.Count > 0)
            {
                foreach (DataRow row in Info.Rows)
                {
                    lblLDLAppID.Text = row["LocalDrivingLicenseApplicationID"].ToString();
                    lblClassName.Text = row["ClassName"].ToString();
                    lblTrail.Text = row["ApplicationTypeTitle"].ToString();

                    lblFees.Text = testtype.Fees.ToString();
                    lblPersonName.Text = row["FullName"].ToString();
                }
            }
        }
       

        protected virtual void _FillTestAppointment()
        {
            apoinmentsLogic.TestTypeID = 1;
            apoinmentsLogic.PaidFees = testtype.Fees;
            apoinmentsLogic.TestTypeID = Convert.ToByte(testtype.ID);
            apoinmentsLogic.CreateduserID = clsGloble.User.ID;
            apoinmentsLogic.IsLock = 0;
            apoinmentsLogic.AppoinmentDate = dtpApointmentDate.Value;
            apoinmentsLogic.LDLappID = Convert.ToInt16(lblLDLAppID.Text);
        }

        private void ctrAddTest_Load(object sender, EventArgs e)
        {

        }

        public void AddNewApplicationWithAppointment()
        {
            if (MessageBox.Show("Are You Sure You Want to Retake The Test", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                if (application.Save())
                {
                    apoinmentsLogic.RetakeAppID = application.ID;
                    if (apoinmentsLogic.Save())
                        MessageBox.Show("Data Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Data Didn't Save Succsfuly", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private bool AddAppointment()
        {
            return apoinmentsLogic.Save();
           
        }

        private void pSaved_Click(object sender, EventArgs e)
        {
   
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillTestAppointment();// -> this will niether update it or add it so don't worry
            switch (this.mode)
            {
                case enMode.Add:

                    if (AddAppointment())
                        MessageBox.Show("Data Saved Succsfuly", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data Didn't Save Succsfuly", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                    break;

                case enMode.Update:
                    // if the mode is update we will re fill the info for the appointment due the date

                    
                    if (AddAppointment()) { MessageBox.Show("Data Saved Succsfuly", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information); } 
                    else { MessageBox.Show("Data Didn't Save Succsfuly", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case enMode.Retake:
                    AddNewApplicationWithAppointment();
                    break;

                
            }
          

        }

        private void CenterLabelToPictureBox()
        {
            // Assuming `pictureBox1` is your PictureBox and `label1` is your Label.

            int pictureLeft = pTestLogo.Left;
            int pictureTop = pTestLogo.Top;
            int pictureWidth = pTestLogo.Width;
            int pictureHeight = pTestLogo.Height;

            int labelWidth = lblTestTitle.Width;

            // Center the Label horizontally relative to the PictureBox
            lblTestTitle.Left = pictureLeft + (pictureWidth - labelWidth) / 2;

            // Position the Label below the PictureBox
            lblTestTitle.Top = pictureTop + pictureHeight + 10; // 10px spacing below the PictureBox
        }


        private void lblTestTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
