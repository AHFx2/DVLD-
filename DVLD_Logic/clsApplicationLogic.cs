using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Logic
{
    public class clsApplicationLogic
    {
        enum enMode { Add, Update }
        public enum enApplicationTypes { NewLocalLicense = 1, RenewLicense, ReplaceLostLicense, ReplaceDamgedLicense, ReleaaseDetainedLicense, NewIntrnationlLicense, Reinspectionservice  = 8}
        public int ID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public byte ApplicationTypeID { get; set; }
        public DateTime LaststautDate { get; set; }
        public byte ApplicationStatus { get; set; }
        public double PaidFees { get; set; }
        public int UserCreatIt { get; set; }

        public static enApplicationTypes applicationtype;
        private enMode _mode;
        public clsApplicationLogic()
        {

            this.ID = -1;
            this.ApplicationDate = DateTime.Now;
            this.LaststautDate = DateTime.Now;
            this.ApplicationTypeID = 0;
            this.ApplicationStatus = 0;
            this.PaidFees = 0;
            this.UserCreatIt = 0;
            this.ApplicantPersonID = 0;
            _mode = enMode.Add;
        }


        public clsApplicationLogic(int iD, int applicantpersonID, DateTime applicationDate, byte applicationTypeID, DateTime laststautDate, byte applicationStatus, double paidFees, int userCreatIt)
        {
            ID = iD;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            LaststautDate = laststautDate;
            ApplicationStatus = applicationStatus;
            PaidFees = paidFees;
            UserCreatIt = userCreatIt;
            this.ApplicantPersonID = applicantpersonID;
            _mode = enMode.Update;
        }


        private bool _AddApplication()
        {
            this.ID = DVLD_DataAccess.clsApplication.AddApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LaststautDate, this.PaidFees, this.UserCreatIt); 
            return this.ID != -1;
        }

        public bool Save()
        {
            switch (this._mode)
            {

                case enMode.Add:
                    return _AddApplication();


                default:
                    return false;
            }
        }
    }
}
