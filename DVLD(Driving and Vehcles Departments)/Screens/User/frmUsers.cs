using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.Screens.User
{
    public partial class frmUsers : frmPerent2
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        DataTable UsersTable;
        private void _RefreshUsersList(string Condition = "")
        {

            UsersTable = DVLD_Logic.clsUserLogic.GetUsers();
            DataView dv = UsersTable.DefaultView;

            if (Condition != "")
                dv.RowFilter = Condition;


            dgvUsersList.Rows.Clear();
            foreach (DataRowView row in dv)
            {


                dgvUsersList.Rows.Add(row["UserID"], row["PersonID"], row["Name"], row["UserName"], (Convert.ToByte(row["IsActive"]) == 1));
            }
        }




        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.ctrFiltredList1.Items = new List<string> { "User ID",
                                                            "Person ID",
                                                            "Name",
                                                            "UserName",
                                                            "Is Active"
                                                            };
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUsers_Shown(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }

        private void ctrFiltredList1_onTextChanged(string obj)
        {
            _RefreshUsersList($"Convert({ctrFiltredList1.Item.Replace(" ", "")}, 'System.String') LIKE '%{obj}%'");
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangepassword changepassword = new frmChangepassword(Convert.ToInt16(dgvUsersList.CurrentRow.Cells[0].Value));
            changepassword.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
     
        }

  
        private void deletePersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u sure u want to perform this", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (DVLD_Logic.clsUserLogic.DeleteUser(Convert.ToInt16(dgvUsersList.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Deleted Successfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                }
            }
        }


        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUpdateUser updateUser = new frmUpdateUser(Convert.ToInt16(dgvUsersList.CurrentRow.Cells[0].Value));
            updateUser.ShowDialog();
            _RefreshUsersList();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
            _RefreshUsersList();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmUserInfo userino = new frmUserInfo(Convert.ToInt16(dgvUsersList.CurrentRow.Cells[0].Value));
            userino.ShowDialog();
            _RefreshUsersList();

        }

        private void addNewPersonToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddUser newUser = new frmAddUser();
            newUser.ShowDialog();
        }

        private void dgvUsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
