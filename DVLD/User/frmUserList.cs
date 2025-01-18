using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.User
{
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            InitializeComponent();
        }

        private DataTable _dtUsers;
        private void _LoadGridData(string Condition = "")
        {



          

            dgvUsersList.Rows.Clear();
            foreach (DataRowView row in _dtUsers.DefaultView)
            {
                dgvUsersList.Rows.Add(row["UserID"], row["PersonID"], row["FullName"], row["UserName"], (Convert.ToByte(row["IsActive"]) == 1));
            }
        }

        private string _ColumnWithoutSpace()
        {
            // this function will remove the spaces from the items
            switch (ctrFiltredList1.Item)
            {
                case "User ID":
                    return "UserID";

                case "Person ID":
                    return "PersonID";

                case "Full Name":
                    return "Full Name";

                case "Username":
                    return "UserName";

                default:
                    return "";
            }
        }

        private void _FilterGrid(string TextChanged)
        {
            if (TextChanged != "")
            {


                if (ctrFiltredList1.Item == "Person ID" || ctrFiltredList1.Item == "User ID")
                {
                    _dtUsers.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} = {TextChanged}";
                }
                else
                {
                    _dtUsers.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} Like '{TextChanged}%'";
                }

            }

            else
                _dtUsers.DefaultView.RowFilter = "";

            _LoadGridData();
        }


        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.ctrFiltredList1.Items = new List<string> { "User ID",
                                                            "Person ID",
                                                            "Full Name",
                                                            "User Name",
                                                           
                                                            };

            _dtUsers = DVLD_Logic.clsUserLogic.GetUsers();
            _LoadGridData("fad");
            //dgvUsersList.DataSource = _dtUsers;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUsers_Shown(object sender, EventArgs e)
        {
            _LoadGridData();
        }

        private void ctrFiltredList1_onTextChanged(string obj)
        {
            _FilterGrid(obj);

        }

  
        private void deletePersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u sure u want to perform this", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (DVLD_Logic.clsUserLogic.DeleteUser(Convert.ToInt16(dgvUsersList.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Deleted Successfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmUsers_Load(null, null);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            User.frmUserInfo frm = new frmUserInfo((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmUsers_Load(null, null);

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            frmUsers_Load(null, null);
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmUsers_Load(null, null);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmChangepassword frm = new frmChangepassword((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmUsers_Load(null, null);
        }
    }
}
