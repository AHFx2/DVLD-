using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using DVLD_DataAccess;

namespace DVLD_Logic
{
    public class clsLicenseLogic
    {
        public int ID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public byte LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public int PaidFees { get; set; }
        public byte IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        enum enMode { Add}
        enMode _Mode;

        public clsLicenseLogic( int ID ,int ApplicationID, int DriverID, byte LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, int PaidFees, byte IsActive, byte IssueReason, int CreatdByUserID)
        {
            this.ID = ID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

        }

        public clsLicenseLogic()
        {
            this.ID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = 0;
            this.IssueDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.Notes = string.Empty;
            this.PaidFees = 0;
            this.IsActive = 0;
            this.IssueReason = 0;
            this.CreatedByUserID = 0;
            _Mode = enMode.Add;
        }


        private bool _AddLicense()
        {
            this.ID = DVLD_DataAccess.clsLicense.AddLicense(this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
            return this.ID != -1;
        }


        public static DataTable GetLicenseByLDLappID(int LDLappID)
        {
            return DVLD_DataAccess.clsLicense.GetLicenseByLDLappID(LDLappID);
        }


        public static DataTable GetLicenseByLicenseID(int LDLappID)
        {
            return DVLD_DataAccess.clsLicense.GetLicenseByLicenseID(LDLappID);
        }


        public static DataTable GetLicenseHistoryByPersonID(int PersonID)
        {
            return DVLD_DataAccess.clsLicense.GetLicenseHistoryByPersonID(PersonID);
        }

        public static DataTable GetLicenseHistoryByNatID(string NatID)
        {
            return DVLD_DataAccess.clsLicense.GetLicenseHistoryByNatID(NatID);
        }

        public static bool IsLicenseActive(int LicenseID)
        {
            return DVLD_DataAccess.clsLicense.IsLicenseActive(LicenseID);
        }

        public static bool IsEpiredLicense(int LicenseID)
        {
            return DVLD_DataAccess.clsLicense.IsEpiredLicense(LicenseID);
        }

        public static bool DEactiveLicensedlg(int LicenseID)
        {
            return DVLD_DataAccess.clsLicense.DEactiveLicense(LicenseID);
        }

        public static int RenewLicense(int LicenseID,int ApplicitonID, string Notes, int PaidFees, int UserCreateITID)
        {
            return DVLD_DataAccess.clsLicense.RenewLicense(LicenseID,ApplicitonID, Notes, PaidFees, UserCreateITID);
        }

        public static int ReplaceLicense(int LicenseID, int ApplicaionID, byte IssueReason, int UserCreateITID)
        {
            return DVLD_DataAccess.clsLicense.ReplaceLicense(LicenseID, ApplicaionID, IssueReason, UserCreateITID);
        }
        public bool Save()
        {
            switch (this._Mode) { 
            
                case enMode.Add:
                    return _AddLicense();

                default:
                    return false;
            }
        }
    }
}
