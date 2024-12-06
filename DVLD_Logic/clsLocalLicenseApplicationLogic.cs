using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Logic
{
    public class clsLocalLicenseApplicationLogic
    {
        enum enMode { Add };

        enMode _mode;
        public int ID { get; set; }
        public clsApplicationLogic Application { get; set; }
        public byte LicenseClassID { get; set; }

        public clsLocalLicenseApplicationLogic()
        {
            this.ID = -1;
            this.Application = null;
            this.LicenseClassID = 0;
            _mode = enMode.Add;
        }

        public static DataTable GetLocalApplicationsApplications()
        {
            return DVLD_DataAccess.clsLocalApplicationLicense.GetLocalApplicationsApplications();
        }



        public static bool IsThereActiveApplication(int PersonID, int LicenseID)
        {
            return DVLD_DataAccess.clsLocalApplicationLicense.IsThereActiveApplication(PersonID, LicenseID);
        }

        private bool _IsThereActiveApplication()
        {
            return DVLD_DataAccess.clsLocalApplicationLicense.IsThereActiveApplication(Application.ApplicantPersonID, LicenseClassID);
        }

        private bool _AddLocalApplication()
        {
            if (!_IsThereActiveApplication())
            {
                if (Application.Save())
                {
                    this.ID = DVLD_DataAccess.clsLocalApplicationLicense.AddLocalApplicationsApplications(Application.ID, LicenseClassID);
                }
            }
            return this.ID != -1;
        }

        public static bool CancelApplication(int LDLAppID) { 
        
            return DVLD_DataAccess.clsLocalApplicationLicense.CancelApplication(LDLAppID);
        }

 
        public static DataTable GetLDLAppInfo(int LDLAppID)
        {
            return DVLD_DataAccess.clsLocalApplicationLicense.GetLocalAppInfo(LDLAppID);
        }


        public static sbyte DetermineTheTestTypeToTake(int LDLID)
        {
            return DVLD_DataAccess.clsLocalApplicationLicense.DetermineTheTestTypeToTake(LDLID);
        }

        public static bool IsApplicationCanceled(int LDLappID)
        {
            return DVLD_DataAccess.clsLocalApplicationLicense.IsApplicationCanceled(LDLappID);
        }

        public static bool IsApplicationCompleted(int LDLappID)
        {
            return DVLD_DataAccess.clsLocalApplicationLicense.IsApplicationCompleted(LDLappID);
        }

        public static bool DoseLocalLicenseIssuedLicsnse(int LDLappID)
        {
            return DVLD_DataAccess.clsLocalApplicationLicense.DoseLocalLicenseIssuedLicsnse(LDLappID);
        }

        public static bool DosePersonHaveThisLicense(int PersonID, int LicenseClassID)
        {
            return DVLD_DataAccess.clsLocalApplicationLicense.DosePersonHaveThisLicense(PersonID, LicenseClassID);
        }

        public static bool DeleteLocalDrivingApplication(int LDLappID)
        {
            return DVLD_DataAccess.clsLocalApplicationLicense.DeleteLocalDrivingApplication(LDLappID);
        }

        public bool Save()
        {
            switch (this._mode)
            {
                case enMode.Add:
                    return _AddLocalApplication();
                default:
                    return false;
            }
        }
    }
}
