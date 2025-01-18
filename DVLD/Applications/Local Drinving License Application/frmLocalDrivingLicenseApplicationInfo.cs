using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.Applications.Local_Drinving_License_Application
{
    public partial class frmLocalDrivingLicenseApplication_Info : Form
    {
        private int _ApplicationID = 0;
        public frmLocalDrivingLicenseApplication_Info(int applicationID)
        {
            InitializeComponent();
            _ApplicationID = applicationID;
        }

        private void ctrLocalDrivingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmLocalDrivingLicenseApplication_Info_Load(object sender, EventArgs e)
        {
            ctrLocalDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_ApplicationID);
        }
    }
}
