using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.Screens.MISC
{
    public partial class frmDriversList : frmPerent2
    {
        public frmDriversList()
        {
            InitializeComponent();
        }


        DataTable DriversTable = DVLD_Logic.clsDriverLogic.GetDrivers();
        private void _RefreshDriversList(string Condition = "")
        {


            DataView dv = DriversTable.DefaultView;

            if (Condition != "")
                dv.RowFilter = Condition;


            dgvLDLApp.Rows.Clear();
            foreach (DataRowView row in dv)
            {
                dgvLDLApp.Rows.Add(row["DriverID"], row["PersonID"], row["NationalNo"], row["FullName"], Convert.ToDateTime(row["CreatedDate"]), row["NumberOfActiveLicenses"]);
            }
        }
        private void frmDriversList_Load(object sender, EventArgs e)
        {
            this.ctrFiltredList1.Items = new List<string> {
                                                            "Driver ID",
                                                            "Person ID",
                                                            "National No",
                                                            "Full Name",
                                                            "Created Date",
                                                            "Number Of Active Licenses"
                                                            };
        }

        private void frmDriversList_Shown(object sender, EventArgs e)
        {
            _RefreshDriversList();
        }

        private void ctrFiltredList1_onTextChanged(string obj)
        {
            _RefreshDriversList($"Convert({ctrFiltredList1.Item.Replace(" ", "")}, 'System.String') LIKE '%{obj}%'");
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
