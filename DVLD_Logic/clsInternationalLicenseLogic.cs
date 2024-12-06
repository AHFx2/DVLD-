using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DVLD_Logic
{
    public class clsInternationalLicenseLogic
    {


        enum enMode { Add }
        enMode _Mode;
        public int InterNationalLicenseID { get; set; }
        public int ApplicaitonID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }  
        public DateTime EpirationDate { get; set; }  
        public byte IsActive { get; set; }
        public int UserCreateItID { get; set; }

        public clsInternationalLicenseLogic(int ID, int ApplicationID, int DriverID, int LicenseID, DateTime IssueDate, DateTime EpirationDate, byte IsActive, int UserCreateItID)
        {
            this.InterNationalLicenseID = ID;
            this.ApplicaitonID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = LicenseID;
            this.IssueDate = IssueDate;
            this.EpirationDate = EpirationDate;
            this.IsActive = IsActive;
            this.UserCreateItID = UserCreateItID;

            // mode gona be update
        }

        public clsInternationalLicenseLogic()
        {
            this.InterNationalLicenseID = -1;
            this.ApplicaitonID = -1;
            this.DriverID = DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.MinValue;
            this.EpirationDate = DateTime.MinValue;
            this.IsActive = 0;
            this.UserCreateItID = -1;

            _Mode = enMode.Add;
        }
        
        public static bool DoseHaveInternationalLicense(int PersonID)
        {
            return DVLD_DataAccess.clsInternationalLicense.DoseHaveInternationalLicense(PersonID);
        }
        public static bool DoseDriverHaveDemandedLicense(int DriverID)
        {
            return DVLD_DataAccess.clsInternationalLicense.DoseDriverHaveDemandedLicense(DriverID);
        }
        private bool _AddInternationalLicense()
        {
            this.InterNationalLicenseID = DVLD_DataAccess.clsInternationalLicense.AddInternationalLicenseID(this.ApplicaitonID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.EpirationDate, this.IsActive, this.UserCreateItID);
            return this.InterNationalLicenseID != -1;
        }

        public static DataTable GetLicenseByInterNationalLicenseID(int ILID)
        {
            return DVLD_DataAccess.clsInternationalLicense.GetLicenseByInterNationalLicenseID(ILID);
        }

        public static DataTable GetInternationalLicenseHistoryByNatID(string NatID)
        {
            return DVLD_DataAccess.clsInternationalLicense.GetInternationalLicenseHistoryByNatID(NatID);
        }
                public static DataTable GetInternationalLicenseHistoryByPersonID(int PersonID)
        {
            return DVLD_DataAccess.clsInternationalLicense.GetInternationalLicenseHistoryByPersonID(PersonID);
        }

        public static DataTable GetInternationalLicenses()
        {
            return DVLD_DataAccess.clsInternationalLicense.GetInternationalLicenses();
        }

        public static int GetPersonIDByInternationalID(int InterntionalLicenseID)
        {
            return DVLD_DataAccess.clsInternationalLicense.GetPersonIDByInternationalID(InterntionalLicenseID);
        }
        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.Add:
                    return this._AddInternationalLicense();


                default:
                    return false;

            }
        }

    }
}
