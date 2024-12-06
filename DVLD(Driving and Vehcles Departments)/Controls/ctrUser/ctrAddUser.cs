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
using Guna.UI2.WinForms;
using DVLD_Logic;
using DVLD_Interface.Properties;
using System.Windows.Forms.VisualStyles;
namespace DVLD_Interface.Controls.ctrUser
{
    public partial class ctrAddUser : ctrPerentGloble
    {
        public ctrAddUser() 
        {
            InitializeComponent();
        }


        protected void FindPerson(int PersonID)
        {
            this.ctrFindUser1.ctrPersonDetails1.person = DVLD_Logic.clsPersonLogic.GetPerson(PersonID);

        }

        private void ctrAddUser_Load(object sender, EventArgs e)
        {
            this.ctrFindUser1.Items = new List<string> { "PersonID", "NationalNo" };
            btnNext.BackColor = SeetingsColor.PrimaryColor;

            btnNext.FillColor = SeetingsColor.PrimaryColor;
        }

  

        private void txtConvirmedPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConvirmedPassword.Text != txtPassword.Text)
            {
                txtConvirmedPassword.Focus();
                e.Cancel = true;
                errorProvider1.SetError(txtConvirmedPassword, "Password Not Match");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConvirmedPassword, "");
            }
        }


        private void _FillUserObject(ref DVLD_Logic.clsUserLogic user)
        {
            user.IsActive = Convert.ToByte(chkIsActive.Checked);
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Person.ID = int.TryParse(ctrFindUser1.Text, out _) ? Convert.ToInt16(ctrFindUser1.Text) : clsPersonLogic.GetPerson(ctrFindUser1.Text).ID;

        }
     
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpLogininfo;
        }

       

  

        protected virtual void btnnSave_Click(object sender, EventArgs e)
        {

            if (CheckEmptyFiled(this.tpLogininfo))
            {
                DVLD_Logic.clsUserLogic user = new clsUserLogic();
                _FillUserObject(ref user);
                if (clsUserLogic.IsPersonUser(user.Person.ID))
                {
                    MessageBox.Show("This Person Is Already a User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (user.Save())
                    {
                        lblID.Text = user.ID.ToString();
                        MessageBox.Show("Data Added Succeufly", "Dnoe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Data Didn't Add Succeufly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }


            }

        }
    }
}
