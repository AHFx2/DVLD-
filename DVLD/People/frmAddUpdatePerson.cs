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
using DVLD_Interface.GlobalClasses;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace DVLD_Interface.People
{
    public partial class frmAddUpdatePerson : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        enum enMode { Add = 0, Update = 1 }
        enMode _Mode;

        clsPerson _Person;
        

        public int _PersonID;
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.Update;
        }



        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update) 
                _LoadData();
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesCombox();

            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            //set default image for the person.
            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            cbCountries.SelectedIndex = cbCountries.FindString("Jordan");

            txtFname.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNatID.Text = "";
            rbMale.Checked = true;
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            this.Text = lblTitle.Text;


        }
        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   

                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //if he reach here that's mean the image and the control have the same thing 
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        protected void _FillCountriesCombox()
        {
            cbCountries.Items.Clear();
            DataTable dt = DVLD_Logic.clsCountryLogic.GetCountries();
            dt.DefaultView.Sort = "CountryName asc";
            foreach (DataRowView row in dt.DefaultView)
            {
                cbCountries.Items.Add(row["CountryName"]);
                //Countries_PhoneCode.Add(row["CountryName"].ToString(), row["PhoneCode"].ToString());
            }
        }
        private void _LoadData()
        {

            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found
            lblPersonID.Text = _PersonID.ToString();
            txtFname.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNatID.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtAddress.Text = _Person.Address;
            txtPhoneNumber.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            cbCountries.SelectedIndex = cbCountries.FindString(_Person.CountryInfo.CountryName);


            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (_Person.ImagePath != "");

        }

        private void _FillObject()
        {
            byte NationalityCountryID = (byte)clsCountry.Find(cbCountries.Text).ID;

            if (!_HandlePersonImage())
                return;

            _Person.FirstName = txtFname.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNatID.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhoneNumber.Text;
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            _Person.Gendor = Convert.ToByte(!Convert.ToBoolean(rbMale.Checked));
           
            _Person.NationalityCountryID = NationalityCountryID;

            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            //change the defualt image to male incase there is no image set.
            if (rbFemale.Checked)
            {
                if (pbPersonImage.ImageLocation == null)
                    pbPersonImage.Image = Resources.Male_512;
            }
        }

        private void txtFname_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);
        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);
        }

        private void txtNatID_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);

            if (txtNatID.Text != _Person.NationalNo && DVLD_Buisness.clsPerson.isPersonExist(txtNatID.Text.Trim()))
            {
                e.Cancel = true;
                txtNatID.Focus();
                errorProvider2.SetError(txtNatID, "NatID Already Exsit Try Another One");
            }

            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtNatID, null);
            }
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                if (!clsValidation.ValidateEmail(txtEmail.Text)) {
                    errorProvider2.SetError(txtEmail, "Invalid Email Syantax");
                    this.Focus();
                    e.Cancel = true;
                }

                else
                {
                    e.Cancel = false;
                    errorProvider2.SetError(txtEmail, null);    
                }
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            clsValidation.SetErroToTextBoxes(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("The Field With Red Icon(s) Are Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                _FillObject();


                if (_Person.Save())
                {
                    lblPersonID.Text = _Person.PersonID.ToString();
                    //change form mode to update.
                    _Mode = enMode.Update;
                    lblTitle.Text = "Update Person";

                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // Trigger the event to send data back to the caller form.
                    DataBack?.Invoke(this, _Person.PersonID);
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.ImageLocation = (selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            llRemoveImage.Visible = false;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                //change thedefualt image to male incase there is no image set.
                if (pbPersonImage.ImageLocation == null)
                    pbPersonImage.Image = Resources.Female_512;
            }
        }
    }
}
