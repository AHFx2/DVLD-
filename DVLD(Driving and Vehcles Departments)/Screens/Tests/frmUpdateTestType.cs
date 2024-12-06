using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.Screens.Tests
{
    public partial class frmUpdateTestType : PerentForm
    {
        public frmUpdateTestType(byte ID)
        {
            InitializeComponent();
            this.ctrUpdateTestType1.Initialize(ID);
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {

        }

        private void ctrUpdateTestType1_Load(object sender, EventArgs e)
        {

        }
    }
}
