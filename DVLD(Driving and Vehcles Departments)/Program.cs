using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Interface.Screens;

namespace DVLD_Interface
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the intro form
            ShowIntroForm();

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
    }
}

