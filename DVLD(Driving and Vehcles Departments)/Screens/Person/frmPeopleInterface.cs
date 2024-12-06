using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Driving_and_Vehcles_Departments_.Screens;
using DVLD_Interface.Screens;
using DVLD_Logic;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Interface.Screens
{
    public partial class frmPeopleInterface : frmPerent2
    {
        public frmPeopleInterface()
        {
            InitializeComponent();
            
        }

        DataTable peopleTable = DVLD_Logic.clsPersonLogic.GePeople();
        public void _RefreshPeopleList(string Condition = "")
        {


            DataView dv = peopleTable.DefaultView;
        
            if (Condition != "")
                dv.RowFilter = Condition;
            
            
            dgvPeopleList.Rows.Clear();
            foreach (DataRowView row in  dv)
            {
                dgvPeopleList.Rows.Add(row["PersonID"], row["NationalNo"], row["FirstName"] + " " + row["LastName"], row["Gendor"], DateTime.Now.Year - Convert.ToDateTime(row["DateOfBirth"]).Year, row["Email"], row["Phone"]);
            }
        }

        private void frmPeopleInterface_Shown(object sender, EventArgs e)
        {
            _RefreshPeopleList();
        }

   
        private void txtFilterText_TextChanged(object sender, EventArgs e)
        {
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson();
            frmAddPerson.ShowDialog();
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePerosn updatePerosn = new frmUpdatePerosn(Convert.ToInt16(dgvPeopleList.CurrentRow.Cells[0].Value));
            updatePerosn.ShowDialog();
        }

        private void deletePersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Are u sure u want to perform this", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2 ) == DialogResult.Yes) 
            {
                if (DVLD_Logic.clsPersonLogic.DeletePerson(Convert.ToInt16(dgvPeopleList.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Deleted Successfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }

                else
                    MessageBox.Show("Person Was Not Deleted Becuse It Has Data Linked To It", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonInfo PerosnDetails = new frmPersonInfo(Convert.ToInt16(dgvPeopleList.CurrentRow.Cells[0].Value));
            PerosnDetails.ShowDialog();
        }

        private void frmPeopleInterface_Load(object sender, EventArgs e)
        {
            this.ctrFiltredList1.Items = new List<string> { "Person ID",
                                                            "National No",
                                                            "First Name",
                                                            "Gendor",
                                                            "Phone",
                                                            "Email" };
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ctrFiltredList1_Load(object sender, EventArgs e)
        {
            
        }

        private void ctrFiltredList1_Load_1(object sender, EventArgs e)
        {

        }

        private void frmPeopleInterface_Move(object sender, EventArgs e)
        {

        }

  

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson();
            frmAddPerson.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pExit_Click_1(object sender, EventArgs e)
        {
          
        }

        private void ctrFiltredList1_onTextChanged_1(string obj)
        {
            _RefreshPeopleList($"Convert({ctrFiltredList1.Item.Replace(" ", "")}, 'System.String') LIKE '%{obj}%'");
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddPerson frmadd = new frmAddPerson();
            frmadd.ShowDialog();
            this.Refresh();
        }
    }
}
