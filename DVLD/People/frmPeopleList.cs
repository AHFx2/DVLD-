using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DVLD_Driving_and_Vehcles_Departments_.Screens;
using DVLD_Interface.Screens;
using DVLD_Logic;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DVLD_Interface.People;
namespace DVLD_Interface.Screens
{
    public partial class frmPeopleList : Form
    {
        public frmPeopleList()
        {
            InitializeComponent();
            
        }

        private DataTable _dtAllPeople;
        private DataTable _dtPeople;
        private void _LoadGridData()
        {


  

            dgvPeople.Rows.Clear();
            foreach (DataRowView row in _dtPeople.DefaultView)
            {
                dgvPeople.Rows.Add(row["PersonID"], row["NationalNo"], row["FirstName"] , row["SecondName"] , row["ThirdName"], row["LastName"], row["GendorCaption"], DateTime.Now.Year - Convert.ToDateTime(row["DateOfBirth"]).Year, row["Email"], row["Phone"]);
            }
        }
        private void _FilterGrid(string TextChanged)
        {
            if (TextChanged != "")
            {


                if (ctrFiltredList1.Item == "Person ID")
                {
                    _dtPeople.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} = {TextChanged}";
                }
                else
                {
                    _dtPeople.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} Like '{TextChanged}%'";
                }

            }

            else
                _dtPeople.DefaultView.RowFilter = "";

            _LoadGridData();
        }
        private void frmPeopleInterface_Shown(object sender, EventArgs e)
        {
            
        }

   
        
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddPerson = new frmAddUpdatePerson();
            frmAddPerson.ShowDialog();
            frmPeopleInterface_Load(null, null);

        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson updatePerosn = new DVLD_Interface.People. frmAddUpdatePerson(Convert.ToInt16(dgvPeople.CurrentRow.Cells[0].Value));
            updatePerosn.ShowDialog();
            frmPeopleInterface_Load(null, null);
        }

        private void deletePersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Are u sure u want to perform this", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2 ) == DialogResult.Yes) 
            {
                if (DVLD_Logic.clsPersonLogic.DeletePerson(Convert.ToInt16(dgvPeople.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Deleted Successfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPeopleInterface_Load(null,null);
                }

                else
                    MessageBox.Show("Person Was Not Deleted Becuse It Has Data Linked To It", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo PerosnDetails = new frmShowPersonInfo(Convert.ToInt16(dgvPeople.CurrentRow.Cells[0].Value));
            PerosnDetails.ShowDialog();
        }

        private void frmPeopleInterface_Load(object sender, EventArgs e)
        {
            // i will call the load event if i want to retrive the whole data from the database
            this.ctrFiltredList1.Items = new List<string> { "Person ID",
                                                            "National No",
                                                            "First Name",
                                                            "Second Name",
                                                            "Third Name",
                                                            "Last Name",
                                                            "GendorCaption",
                                                            "Phone",
                                                            "Email" };

            _dtAllPeople = clsPersonLogic.GePeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth",
                                                       "Phone", "Email");

            _LoadGridData();
        }

        private string _ColumnWithoutSpace()
        {
            // this function will remove the spaces from the items
            switch (ctrFiltredList1.Item)
            {
                case "Person ID":
                    return"PersonID";

                case "National No":
                    return "NationalNo";

                case "First Name":
                    return "FirstName";

                case "Second Name":
                    return "SecondName";

                case "Third Name":
                    return "ThirdName";

                case "Last Name":
                    return "LastName";

                case "Nationality":
                    return "CountryName";

                case "Gendor":
                    return "GendorCaption";

                case "Phone":
                    return "Phone";

                case "Email":
                    return "Email";

                default:
                    return "None";
                    
            }
        }



        private void ctrFiltredList1_onTextChanged_1(string obj)
        {
            _FilterGrid(obj);
        }


        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmadd = new frmAddUpdatePerson();
            frmadd.ShowDialog();
            this.Refresh();
        }
    }
}
