using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Controls;
using DVLD_Interface;
using DVLD_Interface.Screens;

namespace DVLD_Driving_and_Vehcles_Departments_.Screens
{
    public partial class frmPersonInfo : PerentForm
    {
        public int PersonID { get; set; }
        public frmPersonInfo(int ID)
        {
         
            InitializeComponent();
            PersonID = ID;
            ctrPersonDetails1.Initialize(ID);

        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
        }


        private void ctrPersonDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}
