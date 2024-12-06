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

namespace DVLD_Interface.Screens
{
    public partial class PerentForm : Form
    {
        public PerentForm()
        {
            InitializeComponent();

        }

        private void PerentForm_Load(object sender, EventArgs e)
        {
            LoadTheme(this);


        }
        public static void LoadTheme(Control contorl)
        {
            //this method will change the form componant to the main color

            foreach (Control c in contorl.Controls)
            {
                if (c.Controls.Count > 0) {
              
                    LoadTheme(c);
                }
                if (c.GetType() == typeof(Guna2CustomGradientPanel))
                {
                    Guna2CustomGradientPanel Pan = (Guna2CustomGradientPanel)c;


                    Pan.FillColor = SeetingsColor.ChangeColorBrightness(SeetingsColor.SecondaryColor, -0.5);  // Top-left (no change, base secondary)
                    Pan.FillColor2 = SeetingsColor.ChangeColorBrightness(SeetingsColor.SecondaryColor, 0.2); // Bottom-left (slightly lighter)
                    Pan.FillColor3 = SeetingsColor.ChangeColorBrightness(SeetingsColor.ThirdColor, 0.2);   // Top-right (slightly lighter)
                    Pan.FillColor4 = SeetingsColor.ChangeColorBrightness(SeetingsColor.ThirdColor, -0.5);  // Bottom-right (slightly darker)

                }




      
                else if (c.GetType() == typeof(Guna2Button))
                {
                    Guna2Button button = (Guna2Button)c;
                    
                    button.FillColor = SeetingsColor.PrimaryColor;
                    button.ForeColor = Color.White;
                }

                else if (c.GetType() == typeof(Guna2TextBox))
                {
                    Guna2TextBox txtbox = (Guna2TextBox)c;

                    txtbox.FillColor = SeetingsColor.PrimaryColor;
                    txtbox.ForeColor = Color.White;
                }

                else if (c.GetType() == typeof(Guna2DateTimePicker))
                {
                    Guna2DateTimePicker dtp = (Guna2DateTimePicker)c;

                    dtp.FillColor = SeetingsColor.PrimaryColor;
                    dtp.ForeColor = Color.White;
                }
                else if (c.GetType() == typeof(Guna2ComboBox))
                {
                    Guna2ComboBox comboBox = (Guna2ComboBox)c;

                    comboBox.FillColor = SeetingsColor.PrimaryColor;

                    comboBox.ForeColor = Color.White;
                }


                else if (c.GetType() == typeof(Guna2GroupBox))
                {
                    Guna2GroupBox GroupBox = (Guna2GroupBox)c;

                    GroupBox.FillColor = SeetingsColor.PrimaryColor;
                    GroupBox.CustomBorderColor = SeetingsColor.SecondaryColor;
                    GroupBox.BorderColor = SeetingsColor.ChangeColorBrightness(SeetingsColor.PrimaryColor, -0.3);
                }

                else if (c.GetType() == typeof(DataGridView))
                {

                    DataGridView dgv = (DataGridView)c;


                    dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = SeetingsColor.PrimaryColor;
                    dgv.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = SeetingsColor.SecondaryColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = SeetingsColor.SecondaryColor;

                }

                else if (c.GetType() == typeof(TabPage))
                {

                    TabPage tabPage = (TabPage)c;
                    tabPage.BackColor = SeetingsColor.PrimaryColor;

                }

                
            }
        }


   
        protected virtual void pExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
