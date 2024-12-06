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
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
            
        }
       

        private async void frmIntro_Load(object sender, EventArgs e)
        {
            await Task.Delay(3000); // Delay for 3 seconds
            this.Close(); // Or navigate to the next form
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
