using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Controls.ctrMISC;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmUpdateApplicationType : PerentForm
    {
        public frmUpdateApplicationType()
        {
            InitializeComponent();
        }

        public byte typeID { get; set; }
        public frmUpdateApplicationType(byte typeID)
        {
            InitializeComponent();
      
           this.ctrUpdateApplicationtypes1.Initialize(typeID);
        }
        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
