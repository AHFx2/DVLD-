using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.Drivers
{
    public partial class frmDriversList : Form
    {
        public frmDriversList()
        {
            InitializeComponent();
        }

        private DataTable _dtDrivers;

        private void frmDriversList_Load(object sender, EventArgs e)
        {
            _dtDrivers = DVLD_Buisness.clsDriver.GetAllDrivers();

            this.ctrFiltredList1.Items = new List<string> {
                                                            "Driver ID",
                                                            "Person ID",
                                                            "National No",
                                                            "Full Name",
                                                            "Created Date",
                                                            "Number Of Active Licenses"
                                                            };

            _LoadGridData();
        }

        private void _LoadGridData()
        {
            dgvLDLApp.Rows.Clear();
            foreach (DataRowView row in _dtDrivers.DefaultView)
            {
                dgvLDLApp.Rows.Add(row["DriverID"], row["PersonID"], row["NationalNo"], row["FullName"], Convert.ToDateTime(row["CreatedDate"]), row["NumberOfActiveLicenses"]);
            }
        }

        private string _ColumnWithoutSpace()
        {
            // this function will remove the spaces from the items
            switch (ctrFiltredList1.Item)
            {
                case "Driver ID":
                    return "DriverID";

                case "Person ID":
                    return "PersonID";

                case "National No":
                    return "NationalNo";

                case "Full Name":
                    return "FullName";

              
                case "Number Of Active Licenses":
                    return "NumberOfActiveLicenses";

                case "Created Date":
                    return "CreatedDate";


                default:
                    return "None";

            }
        }

        private void _FilterGrid(string TextChanged)
        {
            if (TextChanged != "")
            {


                if (ctrFiltredList1.Item == "Person ID")
                {
                    _dtDrivers.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} = {TextChanged}";
                }
                else
                {
                    _dtDrivers.DefaultView.RowFilter = $"{_ColumnWithoutSpace()} Like '{TextChanged}%'";
                }

            }

            else
                _dtDrivers.DefaultView.RowFilter = "";

            _LoadGridData();
        }

        private void ctrFiltredList1_onTextChanged(string obj)
        {
            _FilterGrid(obj);
        }
    }
}
