using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Controls.ctrUser;
using DVLD_Interface.GlobalClasses;
using DVLD_Logic;
using Guna.UI2.WinForms;

namespace DVLD_Interface.User
{
    public partial class frmChangepassword : Form
    {

        public int UserId { get; set; }

        private clsUserLogic _User;
        public frmChangepassword(int UserId)
        {
            InitializeComponent();
            this.UserId = UserId;
     
        }


        private void frmChangepassword_Load_1(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            _User = clsUserLogic.GetUser(this.UserId);


            if (_User == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Could not Find User with id = " + this.UserId,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;

            }
            this.ctrUserInfo1.LoadUserInfo(this.UserId);

        }

        private void _ResetDefualtValues()
        {
            txtCurrntPassword.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrntPassword.Focus();
        }

        private void txtCurrntPassword_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);

            ErrorProvider error = new ErrorProvider();
            if (txtCurrntPassword.Text != _User.Password)
            {

                txtCurrntPassword.Focus();
                e.Cancel = true;
                error.SetError(txtCurrntPassword, "Password Most Match");
            }

            else
            {
                e.Cancel = false;
                error.SetError(txtCurrntPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);

            ErrorProvider error = new ErrorProvider();
            if (txtConfirmPassword.Text != txtPassword.Text) {

                txtConfirmPassword.Focus();
                e.Cancel = true;
                error.SetError(txtConfirmPassword, "Passwords Most Matchs");
            }

            else
            {
                e.Cancel = false;
                error.SetError(txtConfirmPassword, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);

            ErrorProvider error = new ErrorProvider();
            if (txtPassword.Text == txtCurrntPassword.Text)
            {

                txtPassword.Focus();
                e.Cancel = true;
                error.SetError(txtPassword, "Passwords Most Be Diffrint");
            }

            else
            {
                e.Cancel = false;
                error.SetError(txtPassword, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = txtPassword.Text;

            if (_User.UpdateUserPassword())
            {
                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
