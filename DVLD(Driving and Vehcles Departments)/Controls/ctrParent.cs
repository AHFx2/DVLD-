using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface;
using Guna.UI2.WinForms;
using System.IO;

namespace DVLD_Interface.Controls
{
    public partial class ctrParent : UserControl
    {
        public ctrParent()
        {
            InitializeComponent();
        }

        private void ctrParent_Load(object sender, EventArgs e)
        {
            lblTitle.ForeColor = Color.White;
        }

        private void pPersonPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            //string Exstention = Path.GetExtension(openFileDialog1.FileName);
            pPersonPicture.Tag = openFileDialog1.FileName;/*$@"F:\coding\Projects\Driving & Vehicle License Department (DVLD)\PeopleImages\{Guid.NewGuid()}{Exstention}";*/
            //File.Move(openFileDialog1.FileName, pPersonPicture.Tag.ToString());
            pPersonPicture.Load(pPersonPicture.Tag.ToString());
        }

        public bool CheckEmptyFiled()
        {
            //this method will check if there is an empty fields or not

            foreach (Control c in this.Controls)
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

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
