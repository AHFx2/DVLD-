using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Driving_and_Vehcles_Departments_.Screens;
using Microsoft.VisualBasic.ApplicationServices;

namespace DVLD_Interface.Controls.ctrMISC
{
    public partial class ctrLDLAppInfo : UserControl
    {
        public ctrLDLAppInfo()
        {
            InitializeComponent();
        }

        public DataTable Info;
 
        public void Initialize(int LDLAppID) {
            Info = DVLD_Logic.clsLocalLicenseApplicationLogic.GetLDLAppInfo(LDLAppID);
            _FillInfo();

        }
       
        private void _FillInfo()
        {
            if (Info != null)
            {
                foreach (DataRow row in Info.Rows)
                { 
                    this.lblLDLappID.Text = row["LocalDrivingLicenseApplicationID"].ToString(); 
                    this.lblClassName.Text = row["ClassName"].ToString() ;
                    this.lblAppID.Text = row["ApplicationID"].ToString();
                    this.lblDate.Text = Convert.ToDateTime(row["ApplicationDate"]).ToShortDateString();
                    this.lblStatusDate.Text = Convert.ToDateTime(row["LastStatusDate"]).ToShortDateString();
                    this.lblStatus.Text = row["Status"].ToString();
                    this.lblAppType.Text = row["ApplicationTypeTitle"].ToString();
                    this.lblFees.Text = row["PaidFees"].ToString();
                    this.lblUserName.Text = row["UserName"].ToString();
                    this.lblApplicantal.Text = row["FullName"].ToString();
                    this.lblPassedTests.Text = row["PssedTests"].ToString() + "\\3";
                    

                }
            }
        }

        private void ctrLDLAppInfo_Load(object sender, EventArgs e)
        {
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonDetails_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(Convert.ToInt16(Info.Rows[0]["PersonID"]));
            frm.ShowDialog();
        }
    }
}
