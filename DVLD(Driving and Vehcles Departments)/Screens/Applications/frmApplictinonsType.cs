using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Screens.User;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmApplictinonsType : PerentForm
    {
        public frmApplictinonsType()
        {
            InitializeComponent();
        }
        DataTable ApplicationsTable;

        private void _RefreshApplictionsTypes(string Condition = "")
        {

            ApplicationsTable = DVLD_Logic.clsApplicationTyesLogic.GetApplicationsTypes();

            DataView dv = ApplicationsTable.DefaultView;

            if (Condition != "")
                dv.RowFilter = Condition;


            dgvApplicatioinsTypes.Rows.Clear();
            foreach (DataRowView row in dv)
            {


                dgvApplicatioinsTypes.Rows.Add(row["ApplicationTypeID"], row["ApplicationTypeTitle"], row["ApplicationFees"]);
            }
        }

        private void frmApplictinons_Load(object sender, EventArgs e)
        {

        }

        private void frmApplictinons_Shown(object sender, EventArgs e)
        {
            _RefreshApplictionsTypes();
        }

        private void ediitTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType UpdateApplicationType = new frmUpdateApplicationType(Convert.ToByte(dgvApplicatioinsTypes.CurrentRow.Cells[0].Value));
            UpdateApplicationType.ShowDialog();
            _RefreshApplictionsTypes() ;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvApplicationTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgvApplicatioinsTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
