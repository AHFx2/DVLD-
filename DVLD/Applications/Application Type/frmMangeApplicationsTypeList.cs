using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.User;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmMangeApplicationsTypeList : Form
    {
        public frmMangeApplicationsTypeList()
        {
            InitializeComponent();
        }
        DataTable ApplicationsTable;

        
        private void frmApplictinons_Load(object sender, EventArgs e)
        {
            ApplicationsTable = DVLD_Logic.clsApplicationTypeLogic.GetApplicationsTypes();


            dgvApplicatioinsTypes.Rows.Clear();
            foreach (DataRow row in ApplicationsTable.Rows)
            {
                dgvApplicatioinsTypes.Rows.Add(row["ApplicationTypeID"], row["ApplicationTypeTitle"], row["ApplicationFees"]);
            }
        }

        
        private void ediitTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType UpdateApplicationType = new frmUpdateApplicationType(Convert.ToByte(dgvApplicatioinsTypes.CurrentRow.Cells[0].Value));
            UpdateApplicationType.ShowDialog();
            frmApplictinons_Load(null, null);
        }

        
    }
}
