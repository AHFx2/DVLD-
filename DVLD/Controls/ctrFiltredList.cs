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
             cbFilterList.DataSource = this.Items;
             this.label1.Text = "Filter";
        }

        /// <summary>
        /// Expose a property to show or hide the TextBox inside the UserControl.
        /// </summary>
        [Browsable(true)] // Makes the property visible in the designer
        [Category("Behavior")] // Groups the property under "Behavior"
        [Description("Show or hide the internal TextBox.")]
        public bool TextBoxVisible
        {
            get { return txtFilterText.Visible; }
            set { txtFilterText.Visible = value; }
        }


        private void ctrFiltredList_Load_1(object sender, EventArgs e)
        {
          
        }


        private void pbFilter_Click_1(object sender, EventArgs e)
        {
   
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Item = cbFilterList.SelectedItem.ToString();
            if (Item == "None")
            {
                label1.Text = "Filter ";
                txtFilterText.Visible = false;

            }

            else
            {
                label1.Text = "Filter By " + Item;
                cbFilterList.DroppedDown = false; label1.Text = "Filter By " + Item;
            }
    
            cbFilterList.DroppedDown = false;
        }

        private void txtFilterText_TextChanged(object sender, EventArgs e)
        {
         
            this.Text = txtFilterText.Text;
            if (onTextChanged != null)
                TextChanged(Text);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cbFilterList.DroppedDown = true;
            txtFilterText.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
