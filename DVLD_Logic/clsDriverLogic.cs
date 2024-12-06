using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Logic
{
    public class clsDriverLogic
    {
        enum enMode { Add, Update }

        enMode _Mode;
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int CreatedUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDriverLogic(int ID, int PersonID, int CreatdUserID, DateTime CreatedDate)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.CreatedUserID = CreatdUserID;
            this.CreatedDate = CreatedDate;

            _Mode = enMode.Update;
        }


        public clsDriverLogic()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.CreatedUserID = -1;
            this.CreatedDate = DateTime.MinValue;

            _Mode = enMode.Add;
        }


        private bool _AddDriver()
        {
            this.ID = DVLD_DataAccess.clsDriver.AddDriver(this.PersonID, this.CreatedUserID, this.CreatedDate);
            return this.ID != -1;
        }

        public static bool IsPersonDriver(int PersonID)
        {
            return DVLD_DataAccess.clsDriver.IsPersonDriver(PersonID);
        }

        public static clsDriverLogic GetDriverByPersonID(int PersonID)
        {
            int DriverID = 0, UserCreateIT = 0; 
            DateTime CreatedDate  = DateTime.MinValue;

            if (DVLD_DataAccess.clsDriver.GetDriverByPersonID(ref DriverID, PersonID, ref UserCreateIT, ref CreatedDate))
            {
                return new clsDriverLogic(DriverID, PersonID, UserCreateIT, CreatedDate);
            }

            else
                return null;
        }

        public static DataTable GetDrivers()
        {
            return DVLD_DataAccess.clsDriver.GetDrivers();
        }
        public bool Save()
        {
            switch (_Mode) {

                case enMode.Add:
                    return _AddDriver();

                default:
                    return false;
            }
        } 
    }
}
