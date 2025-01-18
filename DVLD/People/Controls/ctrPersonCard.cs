using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Properties;
using DVLD_Buisness;
using System.IO;
using DVLD_Interface.GlobalClasses;


namespace DVLD_Interface.People.Controls
{
    public partial class ctrPersonCard : UserControl
    {
        private int _PersonID = -1;

        private clsPerson _Person;

        public clsPerson Person
        {
            get { return _Person; }
        }


        public int PersonID
        {
            get { return _PersonID; }
        }
        public ctrPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonData(int PersonID)
        {
            _PersonID = PersonID;
            _Person = clsPerson.Find(PersonID);

            if (_Person == null) {
                
                MessageBox.Show($"Could Not Find Person With ID {PersonID}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        public void LoadPersonData(string NatID)
        {
            _Person = clsPerson.Find(NatID);

            if (_Person == null)
            {

                MessageBox.Show($"Could Not Find Person With National ID {NatID}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {
            btnUpdate.Enabled = true;
            _PersonID = _Person.PersonID;
            lblID.Text = _Person.PersonID.ToString();
            lblNatID.Text = _Person.NationalNo;
            lblName.Text = _Person.FullName;
            lblGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = _Person.CountryInfo.CountryName;
            lblAddress.Text = _Person.Address;
            clsUtil.LoadPersonImage(Person, pbPersonImage);




        }



        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblID.Text = "[????]";
            lblNatID.Text = "[????]";
            lblName.Text = "[????]";
            pbPersonImage.Image = Resources.male;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.Male_512;

        }

        private void ctrPersonCard_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson updatePerson = new frmAddUpdatePerson(PersonID);
            
            updatePerson.ShowDialog();

            //refrsh
            LoadPersonData(PersonID);
        }
    }
}
