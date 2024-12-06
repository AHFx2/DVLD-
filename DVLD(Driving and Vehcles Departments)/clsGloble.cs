using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface
{
    public static class clsGloble
    {
        public static DVLD_Logic.clsUserLogic User { get; set; }

        public static bool GetStoredCardintls(ref string Username, ref string Password)
        {
            try
            {
                string CurrentPath = System.IO.Directory.GetCurrentDirectory();

                string FilePath = CurrentPath + "\\data.txt";

                if (File.Exists(FilePath))
                {
                    // the reader will get the whole file lines "it's a collection of lines"
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        string line = string.Empty;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);
                            Username = result[0];
                            Password = result[1];
                        }
                    }
                    return true;
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


        }

        public static bool RememberPasswordAndUserName(string Username, string password)
        {

            try
            {
                // get the current dirctory path
                string DirectoryPath = System.IO.Directory.GetCurrentDirectory();

                // define the file in the project path
                string FilePath = DirectoryPath + "\\data.txt";

                if (Username == "" && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;
                }

                string DataToSave = Username + "#//#" + password;

                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    writer.WriteLine(DataToSave);
                    writer.Close();
                    return true;
                }

            }
            catch (Exception ex) { MessageBox.Show("An Error Occure " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
        }
    }
}
