using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DVLD_Interface.Controls
{
    public partial class ctrPerentGloble : UserControl
    {
        public ctrPerentGloble()
        {
            InitializeComponent();
        }

        public bool CheckEmptyFiled(Control control)
        {
            //this method will check if there is an empty fields or not

            foreach (Control c in control.Controls)
            {

             
                if (c.GetType() == typeof(Guna2TextBox))
                {
                    Guna2TextBox txtbox = (Guna2TextBox)c;

                    if (string.IsNullOrWhiteSpace(txtbox.Text))
                    {
                        MessageBox.Show("There Is Empty Fileds", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

            }
            return true;
        }

        private void ctrPerentGloble_Load(object sender, EventArgs e)
        {

        }
    }
}
