using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace DVLD_Interface.GlobalClasses
{
    public static class clsValidation
    {
        private static bool _ValidateDomain(string email)
        {
            // this function check if the email with valid domain or not 
            try
            {
                string domain = email.Split('@')[1]; // Get the domain
                //var domainEntry = System.Net.Dns.GetHostEntry(domain); // Check if domain exists
                return true;
            }
            catch
            {
                return false; // Domain doesn't exist
            }
        }

        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress) && _ValidateDomain(emailAddress);
        }

        public static void SetErroToTextBoxes(object sender, CancelEventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            Guna2TextBox txt = (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(txt.Text))
            {
                error.SetError(txt, "This Field is required");
            }
            else
            {
                
                error.SetError(txt, null);
            }
            e.Cancel = false;

        }

        public static bool ValidateInteger(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsNumber(string Number)
        {
            return (ValidateInteger(Number) || ValidateFloat(Number));
        }

        public static void SetErrorToNumberFeilds(object sender, CancelEventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            Guna2TextBox txt = (Guna2TextBox)sender;
            if (clsValidation.IsNumber(txt.Text))
            {
                txt.Focus();
                e.Cancel = true;
                error.SetError(txt, "This Field Most Be Number");
            }
            else
            {
                e.Cancel = false;
                error.SetError(txt, null);
            }
        }


    }
}
