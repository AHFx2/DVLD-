using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Logic
{
    public class clsApplicationTypeLogic
    {
        enum enMode { Update, Add };
        private enMode _mode;

        public int ID { get; set; }
        public  string Title { get; set; }
        public float Fees { get; set; }

        public clsApplicationTypeLogic(int ID, string Title, float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;

            _mode = enMode.Update;
        }

        public clsApplicationTypeLogic()
        {

            this.ID = -1;
            this.Title = string.Empty;
            this.Fees = 0;
            _mode = enMode.Add;

        }
        public static DataTable GetApplicationsTypes()
        {
            return DVLD_DataAccess.clsApplictionsTypeData.GetApplictionTypes();
        }

        public static clsApplicationTypeLogic GetApplicationType(byte ID)
        {
            string Title = string.Empty;
            float Fee = 0;
            if (DVLD_DataAccess.clsApplictionsTypeData.GetApplicationTypeByID(ID, ref Title, ref Fee))
            {
                return new clsApplicationTypeLogic(ID, Title, Fee); 
            }

            else 
                return null;    
        }


        private bool _UpdateApplication()
        {
            return DVLD_DataAccess.clsApplictionsTypeData.UpdateApplictionType(this.ID, this.Title, this.Fees);
        }

        public bool Save()
        {
            switch (_mode)
            {

                case enMode.Update:
                    return _UpdateApplication();
            }

            return false;
        }
    }
}
