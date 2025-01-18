using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.People.Controls;
using DVLD_Logic;
using Microsoft.VisualBasic.ApplicationServices;

namespace DVLD_Interface.Controls.ctrUser
{
    public partial class ctrUserInfo : UserControl
    {
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }

        private clsUserLogic _User;
        public ctrUserInfo()
        {
           
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;
            _User = clsUserLogic.GetUser(UserID);
            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();
        }

        private void _FillUserInfo()
        {

            ctrPersonCard1.LoadPersonData(_User.PersonID);
            lblID.Text = _User.ID.ToString();
            lblUsername.Text = _User.Username.ToString();

            if (_User.IsActive)
                lblIsAtive.Text = "Yes";
            else
                lblIsAtive.Text = "No";
        }

        private void _ResetPersonInfo()
        {

            ctrPersonCard1.ResetPersonInfo();
            lblID.Text = "[???]";
            lblUsername.Text = "[???]";
            lblIsAtive.Text = "[???]";
        }


    

      
    }
}
