using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Logic;

namespace DVLD_Interface.Controls.ctrUser
{
    public partial class ctrUpdateUser : ctrAddUser
    {
        clsUserLogic user;
        public ctrUpdateUser()
        {
            InitializeComponent();
        }

        public ctrUpdateUser(int PersonID)
        {
            InitializeComponent();
        }

        public void Initialize(int UserID)
        {

            user = clsUserLogic.GetUser(UserID);
            FindPerson(user.Person.ID);

            this.lblID.Text = user.ID.ToString();
            this.txtPassword.Text = user.Password;
            txtUsername.Text = user.Username;
            txtConvirmedPassword.Text = txtPassword.Text;
        }

   


     


        private void _FillUserInfo()
        {
            user.Password = txtPassword.Text;
            user.IsActive = Convert.ToByte(chkIsActive.Checked);
            user.Username = txtUsername.Text;
           
        }

        protected override void btnnSave_Click(object sender, EventArgs e)
        {
            _FillUserInfo();
            user.Person = this.ctrFindUser1.ctrPersonDetails1.person;
            
            if (user.Save())
            {

                MessageBox.Show("Data Saved Succesfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Didn't Save Succesfully", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



    }
    
}
