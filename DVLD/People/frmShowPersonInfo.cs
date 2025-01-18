using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Controls;
using DVLD_Interface;
using DVLD_Interface.Screens;
using System.Windows.Forms.VisualStyles;

namespace DVLD_Interface.People
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int ID)
        {
            InitializeComponent();
            this.ctrPersonCard1.LoadPersonData(ID);
        }


        public frmShowPersonInfo(string NatID)
        {
            InitializeComponent();
            this.ctrPersonCard1.LoadPersonData(NatID);
        }

      
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
