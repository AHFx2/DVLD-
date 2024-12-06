using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Driving_and_Vehcles_Departments_.Screens;
using DVLD_Interface;

namespace DVLD_Interface.Controls
{
    public partial class ctrPersonDetails : ctrParent
    {
        protected internal DVLD_Logic.clsPersonLogic person { get; set; }
        public int PersonID { get; set; }
        public string NatID { get; set; }
        public ctrPersonDetails(int ID)
        {
            InitializeComponent();

            PersonID = ID;
            person = DVLD_Logic.clsPersonLogic.GetPerson(PersonID);

        }


        public ctrPersonDetails(string NatID)
        {
            InitializeComponent();
            this.NatID = NatID;
            person = DVLD_Logic.clsPersonLogic.GetPerson(NatID);


        }
        public ctrPersonDetails() 
        {
            InitializeComponent();
            person = null;
        }

   
        public void Initialize(int PersonID)
        {
            this.PersonID = PersonID;
            person = DVLD_Logic.clsPersonLogic.GetPerson(PersonID);

        }


        public void Initialize(string NatID)
        {
            this.NatID = NatID;
            person = DVLD_Logic.clsPersonLogic.GetPerson(NatID);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        public void FillContent(DVLD_Logic.clsPersonLogic person, ctrPersonDetails ctrdetails = null)
        {

            if (person != null && ctrdetails == null)
            {
                lblID.Text = person.ID.ToString();
                lblNatID.Text = person.NationalNo;
                lblName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " +  person.LastName;
                lblEmail.Text = person.Email;
                lblAddress.Text = person.Address;
                lblPhone.Text = person.Phone;
                lblDateBirth.Text = person.DateOfBirth.ToShortDateString().ToString(); 
                pPersonPicture.Tag = person.ImagePath;
                lblGendor.Text = (person.Gendor == 0) ? "Male" : "Female";
                lblCountry.Text = DVLD_Logic.clsCountryLogic.Find(person.CountryID).CountryName;
                pPersonPicture.Load(person.ImagePath);
            }

            else if (ctrdetails != null) 
            {
              ctrdetails.lblID.Text = person.ID.ToString();
              ctrdetails.lblNatID.Text = person.NationalNo;
              ctrdetails.lblName.Text = person.FirstName + person.LastName;
              ctrdetails.lblEmail.Text = person.Email;
              ctrdetails.lblAddress.Text = person.Address;
              ctrdetails.lblPhone.Text = person.Phone;
              ctrdetails.lblDateBirth.Text = person.DateOfBirth.ToShortDateString().ToString();
              ctrdetails.pPersonPicture.Tag = person.ImagePath;
              ctrdetails.lblCountry.Text = (person.Gendor == 0) ? "Male" : "Female";
              ctrdetails.lblCountry.Text = DVLD_Logic.clsCountryLogic.Find(person.CountryID).CountryName;
              ctrdetails.pPersonPicture.Load(person.ImagePath);
            }

            btnUpdate.Enabled = true;
        }

        private void ctrPersonDetails_Load(object sender, EventArgs e)
        {
            if (person != null)
                FillContent(person);

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdatePerosn frm = new frmUpdatePerosn(person.ID);
            frm.ShowDialog();
        }
    }
}
