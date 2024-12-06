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
    public partial class frmUpdateUser : PerentForm
    {
        public frmUpdateUser(int UserID)
        {
            InitializeComponent();
            this.ctrUpdateUser1.Initialize(UserID);
        }
        public frmUpdateUser()
        {
            InitializeComponent();

        }
        private void frmUpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
