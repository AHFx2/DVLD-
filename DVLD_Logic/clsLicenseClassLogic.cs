using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Logic
{
    public class clsLicenseClassLogic
    {

        public int ID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinmumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public int Fees { get; set; }
        public clsLicenseClassLogic(int id , string ClassName, string ClassDescription, byte MinAge, byte Length, int Fees)
        {
            this.ID = id;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinmumAllowedAge = MinAge;
            this.DefaultValidityLength = Length;
            this.Fees = Fees;

        }

        public static DataTable GetLicenesClass()
        {
            return DVLD_DataAccess.clsLicenseClass.GetLicenseClasses();
        }

        public static clsLicenseClassLogic GetLicenseByID(int id)
        {
            string ClassName = string.Empty;
            string ClassDescription = string.Empty;
            byte MinAge = 0;
            byte Length = 0;
            int Fees = 0;
            if (DVLD_DataAccess.clsLicenseClass.GetLicenseByID(id, ref ClassName, ref ClassDescription, ref MinAge, ref Length, ref Fees))
            {
                return new clsLicenseClassLogic(id, ClassName, ClassDescription, MinAge, Length, Fees);
            }

            else 
                return null;
        }

        public static clsLicenseClassLogic GetLicenseByName(string ClassName)
        {
            int ID = 0;
            string ClassDescription = string.Empty;
            byte MinAge = 0;
            byte Length = 0;
            int Fees = 0;
            if (DVLD_DataAccess.clsLicenseClass.GetLicenseByName(ref ID, ClassName, ref ClassDescription, ref MinAge, ref Length, ref Fees))
            {
                return new clsLicenseClassLogic(ID, ClassName, ClassDescription, MinAge, Length, Fees);
            }

            else
                return null;
        }
    }
}
