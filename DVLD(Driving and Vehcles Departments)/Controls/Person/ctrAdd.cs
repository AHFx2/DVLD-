using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface;
using Guna.UI2.WinForms;
using DVLD_Logic;
using DVLD_Interface.Screens;

namespace DVLD_Interface.Controls
{
    public partial class ctrAdd : ctrParent
    {
        public ctrAdd()
        {
            InitializeComponent();

            dtpDate.MaxDate = DateTime.Now.AddYears(-18);

            txtFname.Focus();


            txtAddress.MaxLength = 250;
            lblLength.BackColor = Color.Transparent;
            lblLength.Text = txtAddress.Text.Length + "/" + txtAddress.MaxLength.ToString();
            lblLength.ForeColor = Color.White;
            lblLength.BackColor = SeetingsColor.PrimaryColor;
            lblTitle.ForeColor = Color.White;
            lblTitle.BackColor = Color.Transparent;
        }

        public byte Gendor { get; set; }

        protected Dictionary<string, string> Countries_PhoneCode = new Dictionary<string, string>();

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Gendor == 1)
          
            { 
                if (pPersonPicture.Tag.ToString().Length == 0)
                    pPersonPicture.Image = DVLD_Interface.Properties.Resources.male;
                Gendor = 0;
                gbGednor.Text = "Male";
            }
        }

        private void guna2ImageRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Gendor == 0)
            {
                if (pPersonPicture.Tag.ToString().Length == 0)

                    pPersonPicture.Image = DVLD_Interface.Properties.Resources.female;
                Gendor = 1;
                gbGednor.Text = "Female";
            }
        }

        private void guna2TextBox7_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                string format = string.Empty;
                try
                {

                    format = txtEmail.Text.Substring(txtEmail.Text.IndexOf('@'), txtEmail.Text.Length - txtEmail.Text.IndexOf('@'));
                }

                catch
                {

                    txtEmail.Focus();
                    e.Cancel = true;
                    errorProvider1.SetError(txtEmail, "Invalid Email");
                }
                if (format.ToLower() != "@gmail.com")
                {
                    txtEmail.Focus();
                    e.Cancel = true;
                    errorProvider1.SetError(txtEmail, "Invalid Email");
                }
                else
                    errorProvider1.SetError(txtEmail, "");
            }

          
        }

  
        
        private void ctrAdd_Load(object sender, EventArgs e)
        {
            _FillCountriesCombox();
            comCountries.SelectedIndex = 0;

        
        }

     
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            frmAddPerson frmAddPerson= new frmAddPerson();
            frmAddPerson.Close();
        }

        protected void _FillCountriesCombox()
        {
            comCountries.Items.Clear();
            DataTable dt = DVLD_Logic.clsCountryLogic.GetCountries();
            dt.DefaultView.Sort = "CountryName asc";
            foreach (DataRowView row in dt.DefaultView)
            {
                comCountries.Items.Add(row["CountryName"]);
                Countries_PhoneCode.Add(row["CountryName"].ToString(), row["PhoneCode"].ToString());
            }
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = Countries_PhoneCode[comCountries.SelectedItem.ToString()].Trim() + " ";
        }

        protected void _FillOject(ref DVLD_Logic.clsPersonLogic person)
        {
            person.NationalNo = txtNatID.Text;
            person.DateOfBirth = dtpDate.Value;
            int CodeLength = Countries_PhoneCode[comCountries.SelectedItem.ToString()].Trim().Length + 1;
            person.Phone =  txtPhoneNumber.Text.Substring(CodeLength, txtPhoneNumber.Text.Length - CodeLength);
            person.Email = txtEmail.Text;
            person.Address = txtAddress.Text;
            person.FirstName = txtFname.Text;
            person.LastName = txtLastName.Text;
            person.SecondName = txtSecondName.Text;
            person.ThirdName = txtThirdName.Text;
            person.Gendor = this.Gendor;
            person.ImagePath = pPersonPicture.Tag.ToString();
            person.CountryID = DVLD_Logic.clsCountryLogic.Find(comCountries.SelectedItem.ToString()).CountryID;
        }

        protected virtual void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFiled())
            {
                DVLD_Logic.clsPersonLogic person = new DVLD_Logic.clsPersonLogic();
                _FillOject(ref person);
                if (person.Save())
                {

                    MessageBox.Show("Data Saved Succesfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Didn't Save Succesfully", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           
        }

        private void _CheckFiled()
        {
            
        }

        private void pPersonPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pPersonPicture.Load(openFileDialog1.FileName);
            pPersonPicture.Tag = openFileDialog1.FileName;
        }


        private void txtSecondName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThirdName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.MaxLength = 250;
            lblLength.Text = txtAddress.Text.Length + "/" + txtAddress.MaxLength.ToString();
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            
        }

     
        private void txtNatID_Validating(object sender, CancelEventArgs e)
        {
            if (DVLD_Logic.clsPersonLogic.IsPersonExsit(txtNatID.Text.Trim()))
            {
                e.Cancel = true;
                txtNatID.Focus();
                errorProvider1.SetError(txtNatID, "NatID Already Exsit Try Another One");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNatID, "");
            }
        }

        private void pPersonPicture_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
