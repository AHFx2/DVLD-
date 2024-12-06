using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD_Logic
{
    public class clsTestAppointmentLogic
    {
        public int ID { get; set; }
        public byte TestTypeID { get; set; }
        public int LDLappID { get; set; }
        public DateTime AppoinmentDate { get; set; }
        public double PaidFees { get; set; }
        public int CreateduserID { get; set; }
        public byte IsLock { get; set; }
        public int RetakeAppID { get; set; }

        enum enMode { Add, Update }

        enMode _mode;
        public clsTestAppointmentLogic(int iD, byte testTypeID, int lDLappID, DateTime appoinmentDate, double paidFees, int createduserID, byte isLock, int RetakeAppID = 0)
        {
            ID = iD;
            TestTypeID = testTypeID;
            LDLappID = lDLappID;
            AppoinmentDate = appoinmentDate;
            PaidFees = paidFees;
            CreateduserID = createduserID;
            IsLock = isLock;
            this.RetakeAppID = RetakeAppID;
            _mode = enMode.Update;

        }

        public clsTestAppointmentLogic()
        {

            this.ID = -1;
            this.TestTypeID = 0;
            this.LDLappID = -1;
            this.AppoinmentDate = DateTime.MinValue;
            this.PaidFees = 0;
            this.CreateduserID = 0;
            this.PaidFees = -1;
            this.RetakeAppID = 0;
            _mode = enMode.Add;
        }

        public bool IsTherePassedApointments()
        {
            return DVLD_DataAccess.clsTestAppointments.IsTherePassedApointments(this.LDLappID,  this.TestTypeID);
        }

        public bool IsThereFailedApointments()
        {
            return DVLD_DataAccess.clsTestAppointments.IsThereFailedApointments(this.LDLappID, this.TestTypeID);
        }

        public bool IsThereUnlockedAppointment()
        {
            return DVLD_DataAccess.clsTestAppointments.IsThereUnlockedAppointment(this.LDLappID, this.TestTypeID);
        }

        public bool IsAppointmentlocked()
        {
            return DVLD_DataAccess.clsTestAppointments.IsAppointmentlocked(this.ID, this.LDLappID, this.TestTypeID);
        }
        private bool _AddAppointment()
        {
            this.ID = DVLD_DataAccess.clsTestAppointments.AddAppointment(this.TestTypeID, this.LDLappID, this.AppoinmentDate, this.PaidFees, this.CreateduserID, this.IsLock, this.RetakeAppID);
            return this.ID != -1;
        }
        public static DataTable GetApointments()
        {
            return DVLD_DataAccess.clsTestAppointments.GetAppointments();
        }

        private bool _UpdateAppointment()
        {
            return DVLD_DataAccess.clsTestAppointments.UpdateAppointmentDate(this.ID, this.AppoinmentDate);
        }

        public static DataTable GetAppointmentInfo(int AppoiID)
        {
            return DVLD_DataAccess.clsTestAppointments.GetAppointmentInfo(AppoiID);
        }


        public static clsTestAppointmentLogic GetAppointmen(int AppointmentID)
        {
            byte testTypeID = 0;int lDLappID = 0; DateTime AppointmenDate = DateTime.MinValue; double paidFees = 0;  int createduserID = 0;  byte isLock = 0;
            if (DVLD_DataAccess.clsTestAppointments.GetAppointment(AppointmentID, ref testTypeID, ref lDLappID, ref AppointmenDate, ref paidFees, ref createduserID, ref isLock))
            {
                return new clsTestAppointmentLogic(AppointmentID, testTypeID, lDLappID, AppointmenDate, paidFees, createduserID, isLock);
            }
            else return null;
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.Add:
                    return _AddAppointment();

                case enMode.Update:
                    return _UpdateAppointment();
                default:
                    return false;
            }
        }
    }
}
