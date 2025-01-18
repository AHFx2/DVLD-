using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Licenses.International_Licenses.Controls;

namespace DVLD_Interface.Licenses.International_Licenses
{
    public partial class frmShowInternationalLicenseInfo : Form
    {
        private int _InternationalLicenseID;
        public frmShowInternationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;

        }


    
        private void frmShowInternationalLicenseInfo_Load_1(object sender, EventArgs e)
        {
            ctrDriverInternationalLicenseInfo1.LoadInfo(_InternationalLicenseID);

        }
    }
}
