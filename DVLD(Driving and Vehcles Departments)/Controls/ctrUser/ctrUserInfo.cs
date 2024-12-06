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

namespace DVLD_Interface.Controls.ctrUser
{
    public partial class ctrUserInfo : UserControl
    {
        public int UserID { get; set; }
        clsUserLogic user;



        public ctrUserInfo()
        {
            InitializeComponent();
        }

        public ctrUserInfo(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            user = clsUserLogic.GetUser(UserID);
            ctrPersonDetails1.Initialize(user.Person.ID);
        }

        public void Initialize(int UserID) {

            this.UserID = UserID;
            user = clsUserLogic.GetUser(UserID);
            ctrPersonDetails1.Initialize(user.Person.ID);

            lblUsername.Text = user.Username;
            lblID.Text = user.ID.ToString();
            lblActive.Text = (user.IsActive == 1) ? "Yes" : "No";
        }




        private void ctrUserInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void ctrPersonDetails1_Load(object sender, EventArgs e)
        {

        }

        private void ctrPersonDetails1_Load_1(object sender, EventArgs e)
        {
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ctrPersonDetails1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
