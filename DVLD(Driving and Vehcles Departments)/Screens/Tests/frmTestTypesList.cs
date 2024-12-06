using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Screens.Tests;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmTestTypesList : PerentForm
    {
        public frmTestTypesList()
        {
            InitializeComponent();
        }

        DataTable testsTypeTalbe;

        private void _RefreshTestsTypes(string Condition = "")
        {

            testsTypeTalbe = DVLD_Logic.clsTestTypesLogic.GetTestsTypes();

            DataView dv = testsTypeTalbe.DefaultView;

            if (Condition != "")
                dv.RowFilter = Condition;


            dgvTestTypes.Rows.Clear();
            foreach (DataRowView row in dv)
            {


                dgvTestTypes.Rows.Add(row["TestTypeID"], row["TestTypeTitle"], row["TestTypeDescription"], row["TestTypeFees"]);
            }
        }
        private void frmTestTypesList_Load(object sender, EventArgs e)
        {

        }

        private void frmTestTypesList_Shown(object sender, EventArgs e)
        {
            _RefreshTestsTypes();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgvTestTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ediitTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestType frm = new frmUpdateTestType(Convert.ToByte(dgvTestTypes.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            _RefreshTestsTypes();
        }
    }
}
