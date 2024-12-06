using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.Controls.Person
{
    public partial class ctrFindPerson : UserControl
    {
        public ctrFindPerson()
        {
            InitializeComponent();
        }

        public List<string> Items = new List<string>();
        public string Item { get; set; }
        public string Text { get; set; }
        protected void FindPerson(int PersonID)
        {
            this.ctrPersonDetails1.person = DVLD_Logic.clsPersonLogic.GetPerson(PersonID); 

        }
        private void pbSearch_Click(object sender, EventArgs e)
        {

        
        }

        private void ctrFiltredList1_Load(object sender, EventArgs e)
        {
            this.ctrFiltredList1.Items = new List<string> { 
                                                         "Person ID",
                                                         "National No"
                                                         };
        }
    

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ctrFiltredList1_onTextChanged(string obj)
        {
            this.Text = obj;
            this.Item = ctrFiltredList1.Item.Replace(" ", "");
        }

        private void ctrPersonDetails1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string filteredtext = ctrFiltredList1.Text;

                if (int.TryParse(filteredtext, out _))
                {
                    this.ctrPersonDetails1.person = DVLD_Logic.clsPersonLogic.GetPerson(Convert.ToInt16(filteredtext));
                }

                else
                {
                    this.ctrPersonDetails1.person = DVLD_Logic.clsPersonLogic.GetPerson(filteredtext);

                }
                this.ctrPersonDetails1.FillContent(this.ctrPersonDetails1.person, this.ctrPersonDetails1);

            }

            catch (Exception ex) { MessageBox.Show($"Error Happned When Finding The Data {ex.ToString()} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson();
            frmAddPerson.ShowDialog();
            this.Refresh();
        }

        private void ctrFindPerson_Load(object sender, EventArgs e)
        {

        }

        private void ctrPersonDetails1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
