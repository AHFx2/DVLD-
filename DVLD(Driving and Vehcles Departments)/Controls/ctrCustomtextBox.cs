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
    public partial class ctrCustomtextBox : UserControl
    {
        public ctrCustomtextBox()
        {
            InitializeComponent();
            LoadTheme();
            panel1.BackColor = SeetingsColor.PrimaryColor;
        }
        public void LoadTheme()
        {
            //this method will change the form componant to the main color

            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Guna2Button))
                {
                    Guna2Button button = (Guna2Button)control;

                    button.FillColor = SeetingsColor.PrimaryColor;
                    button.ForeColor = Color.White;
                }

                else if (control.GetType() == typeof(Guna2TextBox))
                {
                    Guna2TextBox txtbox = (Guna2TextBox)control;

                    txtbox.FillColor = SeetingsColor.PrimaryColor;
                    txtbox.ForeColor = Color.White;
                }

                else if (control.GetType() == typeof(Guna2DateTimePicker))
                {
                    Guna2DateTimePicker dtp = (Guna2DateTimePicker)control;

                    dtp.FillColor = SeetingsColor.PrimaryColor;
                    dtp.ForeColor = Color.White;
                }
                else if (control.GetType() == typeof(Guna2ComboBox))
                {
                    Guna2ComboBox comboBox = (Guna2ComboBox)control;

                    comboBox.FillColor = SeetingsColor.PrimaryColor;

                    comboBox.ForeColor = Color.White;
                }





            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
