using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DVLD_Interface.Controls
{
    public partial class ctrUpdate : ctrAdd
    {
        private static int PersonID { get; set; }
        DVLD_Logic.clsPersonLogic person;
        public ctrUpdate()
        {
            InitializeComponent();
            
        }
        
        public void Initialize(int ID)
        {
            PersonID = ID;
            person = DVLD_Logic.clsPersonLogic.GetPerson(PersonID);
            txtAddress.MaxLength = 250;
           btnDeleteImage.Enabled = true;

        }


        private void ctrUpdate_Load(object sender, EventArgs e)
        {
            if (person != null)
            {
                txtNatID.Text = person.NationalNo;
                txtFname.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtEmail.Text = person.Email;
                txtSecondName.Text = person.SecondName;
                txtThirdName.Text = person.ThirdName;
                txtAddress.Text = person.Address;
                pPersonPicture.Load(person.ImagePath);
                pPersonPicture.Tag = person.ImagePath.ToString();
                comCountries.SelectedItem = DVLD_Logic.clsCountryLogic.Find(Convert.ToByte(person.CountryID)).CountryName;
                txtPhoneNumber.Text += person.Phone;
            }
        }

        public  void _FillObject(ref DVLD_Logic.clsPersonLogic person)
        {
            person.NationalNo = txtNatID.Text;
            person.FirstName  = txtFname.Text;
            person.LastName   = txtLastName.Text;
            person.Email      = txtEmail.Text;
            person.SecondName = txtSecondName.Text;
            person.ThirdName  = txtThirdName.Text;
            person.Address    = txtAddress.Text;
            int CodeLength = Countries_PhoneCode[comCountries.SelectedItem.ToString()].Trim().Length + 1;
            person.Phone = txtPhoneNumber.Text.Substring(CodeLength, txtPhoneNumber.Text.Length - CodeLength);
            person.ImagePath = pPersonPicture.Tag.ToString();
            
        }

        protected override void pictureBox1_Click(object sender, EventArgs e)
        {
            _FillObject(ref person);
            if (person.Save())
            {
                MessageBox.Show("updated Succesfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something Went Wrong", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

      
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            pPersonPicture.Image = Properties.Resources._172628_user_male_icon;
        }
    }
}
