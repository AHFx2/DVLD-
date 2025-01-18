using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Controls.ctrUser;
using DVLD_Logic;

namespace DVLD_Interface.User
{
    public partial class frmUserInfo : Form
    {
        public int UserID { get; set; }
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
           
        }


        private void frmUserInfo_Load_1(object sender, EventArgs e)
        {
            ctrUserInfo2.LoadUserInfo(UserID);
        }
    }
}
