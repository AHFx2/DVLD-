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
using DVLD_Logic;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmTestTypesList : Form
    {
        public frmTestTypesList()
        {
            InitializeComponent();
        }

        private DataTable _dtTestTyps;

        private void _LoadGridData()
        {

            _dtTestTyps = DVLD_Logic.clsTestTypeLogic.GetTestsTypes();

            dgvTestTypes.Rows.Clear();
            foreach (DataRow row in _dtTestTyps.Rows)
            {
                dgvTestTypes.Rows.Add(row["TestTypeID"], row["TestTypeTitle"], row["TestTypeDescription"], row["TestTypeFees"]);
            }
        }
        private void frmTestTypesList_Load(object sender, EventArgs e)
        {
            _LoadGridData();
        }

        
        private void ediitTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestType frm = new frmUpdateTestType((clsTestTypeLogic.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadGridData();
        }
    }
}
