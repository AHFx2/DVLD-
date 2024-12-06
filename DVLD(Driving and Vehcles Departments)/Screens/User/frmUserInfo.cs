using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Controls.ctrUser;

namespace DVLD_Interface.Screens.User
{
    public partial class frmUserInfo : PerentForm
    {
        public int UserID { get; set; }
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            ctrUserInfo1.Initialize(UserID);
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void ctrUserInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
