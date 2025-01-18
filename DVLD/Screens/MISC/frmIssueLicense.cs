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

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmIssueLicense : PerentForm
    {
        public frmIssueLicense(int LDLappID)
        {
            InitializeComponent();
            
            this.ctrIssueLiceseFirstTime1.Initialize(LDLappID);
        }

        private void frmIssueLicense_Load(object sender, EventArgs e)
        {

        }

        private void frmIssueLicense_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
