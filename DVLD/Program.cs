using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DVLD_Driving_and_Vehcles_Departments_.Screens;
using DVLD_Interface.Applications.Local_Drinving_License_Application;
using DVLD_Interface.Applications.Renew_License;
using DVLD_Interface.Screens;
using DVLD_Interface.Screens.MISC;
using DVLD_Interface;
namespace DVLD_Interface
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the intro form
            //ShowIntroForm();

            // Run the main login screen
 
            Application.Run(new DVLD_Interface.Screens.frmLoginScreen());
        }
        static void ShowIntroForm()
        {
            using (frmIntro frm = new frmIntro())
            {
                frm.Show();
                Task.Delay(3000).Wait(); // Delay for 3 seconds
                frm.Close();
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetProcessDPIAware();

    }
}

