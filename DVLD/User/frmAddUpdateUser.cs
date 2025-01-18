using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DVLD_Interface.GlobalClasses;
using DVLD_Logic;
using Microsoft.VisualBasic.ApplicationServices;

namespace DVLD_Interface.User
{
    public partial class frmAddUpdateUser : Form
    {
        private enum enMode { Add, Update };
        private enMode _Mode;

        int _UserID = -1;
        private clsUserLogic _User;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            this._UserID = UserID;
        }

    

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update) { 
                _LoadData();
            }
        }


        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.Add)
            {
                this.Text = "Add New User";
                _User = new clsUserLogic();

                tpLoginInfo.Enabled = false;
                btnNext.Enabled = false;
                ctrFindPerson1.FilterFocus();
            }
            else
            {
                this.Text = "Update User";

                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
               

            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;
            this.Text = "Add User";

        }


        private void _LoadData()
        {

            _User = clsUserLogic.GetUser(_UserID);
            ctrFindPerson1.FilterEnabled = false;
            ctrFindPerson1.VisbleFilter = true;
            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            //the following code will not be executed if the person was not found
            lblID.Text = _User.ID.ToString();
            txtUserName.Text = _User.Username;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            ctrFindPerson1.LoadPersonInfo(_User.PersonID);
            this.Text = "Update User";

        }

        private void ctrFindPerson1_OnPersonSelected(int obj)
        {
            if (clsUserLogic.IsUserExsitByID(obj)) { 
                btnNext.Enabled = false;
                tpLoginInfo.Enabled = false;
                MessageBox.Show("Selected Person Is Already User Plz Select Another One", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                btnNext.Enabled = true;
                tpLoginInfo.Enabled = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) { 
                MessageBox.Show("The Field(s) With The Red Icon(s) Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _User.PersonID = ctrFindPerson1.PersonID;
            _User.Username = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = chkIsActive.Checked;

            if (_User.Save())
            {
                this.Text = "Update User";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lblID.Text = _User.ID.ToString();
                _Mode = enMode.Update;
            }

            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpLoginInfo;
            
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);
            ErrorProvider erro = new ErrorProvider();

            if (clsUserLogic.IsUserExsitByUserName(txtUserName.Text))
            {
                e.Cancel = true;
                erro.SetError(txtUserName, "Username Used Chose Another One");
            }

            else
                e.Cancel = false;
                erro.SetError(txtUserName, null);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);
            ErrorProvider erro = new ErrorProvider();

            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                erro.SetError(txtConfirmPassword, "The Password Not Match");
            }

            else
            {
                e.Cancel= false;
                erro.SetError(txtConfirmPassword, null);
            }
        }

        private void ctrFindPerson1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);

        }
    }
}
