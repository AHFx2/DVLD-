using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Logic;
using DVLD_Interface.People.Controls;
using DVLD_Buisness;

namespace DVLD_Interface.People.Controls
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

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public bool VisbleFilter
        {
            get
            {
                return this.ctrFiltredList1.TextBoxVisible;
            }
            set
            {
                this.ctrFiltredList1.TextBoxVisible = value;

            }
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddPerson.Visible = _ShowAddPerson;
            }
        }

        private int _PersonID = -1;

        public int PersonID
        {
            get { return ctrPersonCard1.PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return ctrPersonCard1.Person; }
        }

        public void LoadPersonInfo(int PersonID)
        {

            //...
            ctrFiltredList1.cbFilterList.SelectedIndex = 0;

            ctrFiltredList1.txtFilterText.Text = PersonID.ToString();
            FindNow();

        }

        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        public class clsPersonSelectedArgs : EventArgs { 
        
            public int PersonID { get; }

            public clsPersonSelectedArgs(int personID)
            {
                this.PersonID = personID;
            }
        }

        private EventHandler<clsPersonSelectedArgs> _SelectedPerson;

        private void RaiseOnPersonSelected(int PersonID) {
            
            RaiseOnPersonSelected(new clsPersonSelectedArgs(PersonID));
        }

        protected virtual void RaiseOnPersonSelected(clsPersonSelectedArgs e) 
        {
            _SelectedPerson?.Invoke(this, e);
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
        private void FindNow()
        {
            string filteredtext = ctrFiltredList1.Text;
            switch (ctrFiltredList1.Item)
            {
                case "Person ID":
                    this.ctrPersonCard1.LoadPersonData(Convert.ToInt16(filteredtext));
                    break;

                case "National No":
                    this.ctrPersonCard1.LoadPersonData(filteredtext);
                    break;

                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
                // Raise the event with a parameter
                RaiseOnPersonSelected(ctrPersonCard1.PersonID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddPerson = new frmAddUpdatePerson();
            frmAddPerson.ShowDialog();
            this.Refresh();
        }

        public void FilterFocus()
        {
            this.ctrFiltredList1.txtFilterText.Focus();
        }
        private void ctrFindPerson_Load(object sender, EventArgs e)
        {

        }

        private void ctrPersonDetails1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
