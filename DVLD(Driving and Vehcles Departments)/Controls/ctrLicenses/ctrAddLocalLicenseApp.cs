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
    public partial class ctrAddLocalLicenseApp : UserControl
    {
        public ctrAddLocalLicenseApp()
        {
            InitializeComponent();
            
        }

        public void Initialize()
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblDate.Tag = DateTime.Now.ToString();

            lblUser.Text = clsGloble.User.Username;
            lblUser.Tag = clsGloble.User.ID;


            lblFees.Text = 20.ToString();


            _FillClassesCombox();
        }

        DataTable ClassesTable = DVLD_Logic.clsLicenseClassLogic.GetLicenesClass();

        DVLD_Logic.clsApplicationLogic Application = new DVLD_Logic.clsApplicationLogic();


        protected Dictionary<string, byte> Classes_ID = new Dictionary<string, byte>();

        private void ctrAddLocalLicenseApp_Load(object sender, EventArgs e)
        {
           
        }

        protected void _FillClassesCombox()
        {
            comClasses.Items.Clear();
            DataTable dt = DVLD_Logic.clsLicenseClassLogic.GetLicenesClass();
            dt.DefaultView.Sort = "ClassName asc";
            foreach (DataRowView row in dt.DefaultView)
            {
                comClasses.Items.Add(row["ClassName"]);
                Classes_ID.Add(row["ClassName"].ToString(), Convert.ToByte(row["LicenseClassID"]));
            }

            comClasses.SelectedIndex = 0;
        }

        private void _FillApplicationDataAndAdd(ref DVLD_Logic.clsApplicationLogic Application)
        {
            Application.ApplicantPersonID = ctrFindPerson1.ctrPersonDetails1.person.ID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = 1; // new local license
            Application.ApplicationStatus = 1; // the status new
            Application.LaststautDate = DateTime.Now;
            Application.PaidFees = 15;
            Application.UserCreatIt = clsGloble.User.ID;

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void PersonInfor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

          

        }

        private void ctrFindPerson1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillApplicationDataAndAdd(ref Application);

            clsLocalLicenseApplicationLogic licenseApplication = new clsLocalLicenseApplicationLogic();
            licenseApplication.Application = Application;
            licenseApplication.LicenseClassID = Classes_ID[comClasses.SelectedItem.ToString()];

            if (!clsLocalLicenseApplicationLogic.DosePersonHaveThisLicense(licenseApplication.Application.ApplicantPersonID, licenseApplication.LicenseClassID))
            {
                if (!clsLocalLicenseApplicationLogic.IsThereActiveApplication(licenseApplication.Application.ApplicantPersonID, licenseApplication.LicenseClassID)) {
                    if (Application.Save() && licenseApplication.Save())
                    {

                        MessageBox.Show("Application Added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblID.Text = licenseApplication.ID.ToString();
                    }

                    else
                        MessageBox.Show("Application not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else 

                    MessageBox.Show("There Is an Active Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else
            {
                MessageBox.Show("Person Already Have This Type Of License U Can Issue it to him","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
