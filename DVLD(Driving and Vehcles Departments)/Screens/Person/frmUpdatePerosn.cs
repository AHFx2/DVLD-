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
using DVLD_Interface.Screens;

namespace DVLD_Driving_and_Vehcles_Departments_.Screens
{
    public partial class frmUpdatePerosn : PerentForm
    {
        public frmUpdatePerosn(int ID)
        {
            InitializeComponent();
           ctrUpdate1.Initialize(ID);
        }

        private void frmUpdatePerosn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
