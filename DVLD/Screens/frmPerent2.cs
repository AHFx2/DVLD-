using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.Screens
{
    public partial class frmPerent2 : Form
    {
        public frmPerent2()
        {
            InitializeComponent();
        }

        private void frmPerent2_Load(object sender, EventArgs e)
        {
            PerentForm.LoadTheme(this);
        }
    }
}
