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
    public partial class ctrFiltredList : UserControl
    {
        private List<string> _Itmes;
        public ctrFiltredList()
        {
            InitializeComponent();

            _Itmes = new List<string>();
        }

        public event Action<string> onTextChanged;

        protected virtual void TextChanged(string Text)
        {
            Action<string> handler = onTextChanged;
            if (handler != null) { 
                handler(Text);
            }
        }
        public List<string> Items
        {
            get { return _Itmes; }
            set
            {
                _Itmes = value;
                _Itmes.Add("None");
                _FillBox();
            }
        }

        public string Item { get; set; }
        public string Text { get; set; }

        private void _FillBox()
        {
            if (this.Items.Count > 0)
             guna2ComboBox1.DataSource = this.Items;
             this.label1.Text = "Filter";
        }


   

        private void ctrFiltredList_Load_1(object sender, EventArgs e)
        {
            
        }


        private void pbFilter_Click_1(object sender, EventArgs e)
        {
   
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Item = guna2ComboBox1.SelectedItem.ToString();
            if (Item == "None")
            {
                label1.Text = "Filter ";
                txtFilterText.Visible = false;

            }

            else
            {
                label1.Text = "Filter By " + Item;
                guna2ComboBox1.DroppedDown = false; label1.Text = "Filter By " + Item;
            }
    
            guna2ComboBox1.DroppedDown = false;
        }

        private void txtFilterText_TextChanged(object sender, EventArgs e)
        {
         
            this.Text = txtFilterText.Text;
            if (onTextChanged != null)
                TextChanged(Text);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2ComboBox1.DroppedDown = true;
            txtFilterText.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
