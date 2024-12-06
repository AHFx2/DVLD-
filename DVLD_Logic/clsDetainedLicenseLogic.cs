using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Logic
{
    public class clsDetainedLicenseLogic
    {

    

  
        public static bool IsDetainedLicense(int  licenseId)
        {
            return DVLD_DataAccess.clsDetainedLicense.IsLicenseDetained(licenseId);
        }

        public static int DetaineLicense(int licenseId, double Fees, int usercreateIt, string notes)
        {
            return DVLD_DataAccess.clsDetainedLicense.DetaineLicense(licenseId, Fees, usercreateIt, notes);
        } 

        public static int GetLicenseFine(int LicenseID)
        {
            return DVLD_DataAccess.clsDetainedLicense.GetLicenseFine(LicenseID);
        }

        public static DataTable GetDetainedInfo(int LicenseeID)
        {
            return DVLD_DataAccess.clsDetainedLicense.GetDetainedInfo(LicenseeID);
        }

        public static bool ReleaseDetainedLicense(int DetainID, int usercreateIt, int ReleaseAppID)
        {
            return DVLD_DataAccess.clsDetainedLicense.ReleaseDetainedLicense(DetainID, usercreateIt, ReleaseAppID);
        }
        
        public static DataTable GetDetainedLicenses()
        {
            return DVLD_DataAccess.clsDetainedLicense.GetDetainedLicenses();
        }
    }
}
