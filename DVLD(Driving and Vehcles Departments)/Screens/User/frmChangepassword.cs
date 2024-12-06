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
    public partial class frmChangepassword : PerentForm
    {

        public int UserId { get; set; }
        public frmChangepassword(int UserId)
        {
            InitializeComponent();
            this.UserId = UserId;
     
            this.ctrChangePassword1.Initialize(this.UserId);
        }

        private void frmChangepassword_Load(object sender, EventArgs e)
        {

        }
    }
}
