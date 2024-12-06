using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Logic;
using Guna.UI2.WinForms;

namespace DVLD_Interface.Controls.ctrUser
{
    public partial class ctrChangePassword : UserControl
    {
        public ctrChangePassword()
        {
            InitializeComponent();
        }
        public int UserID { get; set; }
        clsUserLogic user;
        


        public void Initialize(int UserID) { 
        
              this.UserID = UserID;
            ctrUserInfo1.Initialize(UserID);

            user = clsUserLogic.GetUser(UserID);

        }

        private void ctrChangePassword_Load(object sender, EventArgs e)
        {

        }


        private void guna2TextBox1_Validating(object sender, CancelEventArgs e)
        {

            if (txtCurrntPassword.Text != user.Password)
            {
                e.Cancel = true;
                txtCurrntPassword.Focus();
                errorProvider1.SetError(txtCurrntPassword, "Not Match");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrntPassword, "");
            }

        }

        private void txtConfirmedPassord_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmedPassord.Text != user.Password)
            {
                e.Cancel = true;
                txtConfirmedPassord.Focus();
                errorProvider1.SetError(txtConfirmedPassord, "Not Match");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmedPassord, "");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (user.UpdateUserPassword(txtPassword.Text))
            {
                MessageBox.Show("Changed", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show("Wrong not changed", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ctrUserInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
