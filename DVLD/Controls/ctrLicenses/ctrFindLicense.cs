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
    public partial class ctrFindLicense : UserControl
    {
        public ctrFindLicense()
        {
            InitializeComponent();
        }

        public event Action<string> onLicenseFound;

        protected virtual void LicenseFound(string Text)
        {
            Action<string> handler = onLicenseFound;
            if (handler != null)
            {
                handler(Text);
            }
        }

        public void Initialize(int LicenseID)
        {
            
        }

      


        private void ctrFiltredList1_Load(object sender, EventArgs e)
        {

        }

        private void ctrLincesCard1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (int.TryParse(txtFiled.Text, out _))
                {
                    ctrLincesCard1.InitializeByLicenseID(Convert.ToInt16(txtFiled.Text)); 
                    LicenseFound(txtFiled.Text); 

                }
            }

            catch { MessageBox.Show("License With ID " + txtFiled.Text + " Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand); } 
        }

        private void ctrFindLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
