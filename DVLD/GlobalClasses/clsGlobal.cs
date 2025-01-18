using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DVLD_Interface
{
    public static class clsGlobal
    {
        public static DVLD_Logic.clsUserLogic User { get; set; }

        public static bool GetStoredCardintls(ref string Username, ref string Password)
        {
            try
            {
                string KeyPath = "HKEY_CURRENT_USER\\Software\\DVLD";
                string KeyValue;
                string KeyName = "Config";


                KeyValue = Registry.GetValue(KeyPath, KeyName, null) as string;

                if (KeyValue != null)
                {
                    string[] result = KeyValue.Split(new string[] { "#//#" }, StringSplitOptions.None);
                    Username = result[0];
                    Password = result[1];
                }

                else
                {

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occure " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }
            return true;

        }

        public static bool RememberPasswordAndUserName(string Username, string password)
        {

            try
            {
                // get the current dirctory path
                string KeyPath = "HKEY_CURRENT_USER\\Software\\DVLD";

                // define the file in the project path
                string FilePath = KeyPath + "\\data.txt";
                string KeyName = "Config";

                string KeyValue = Username + "#//#" + password;
                if (Username == "" && File.Exists(KeyPath))
                {
                    // Open the registry key in read/write mode with explicit registry view
                    using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    {
                        using (RegistryKey key = baseKey.OpenSubKey(KeyPath, true))
                        {
                            key.DeleteValue(KeyValue);
                        }
                        return true;
                    }
                }


                else
                    Registry.SetValue(KeyPath, KeyName, KeyValue, RegistryValueKind.String);
            }

            catch (Exception ex) { MessageBox.Show("An Error Occure " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            return true;
        }
    }
}          
