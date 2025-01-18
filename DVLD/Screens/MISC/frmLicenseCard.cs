using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmLicenseCard : PerentForm
    {
        public frmLicenseCard()
        {
            InitializeComponent();
        }


        public void InitializeByLDLID(int LDLappID) {
            this.ctrLincesCard1.InitializeByLDLID(LDLappID);

        }
        public void InitializeByLicenseID(int LicenseID) {
            this.ctrLincesCard1.InitializeByLicenseID(LicenseID);

        }

        private void frmLicenseCard_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
