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
    public class clsApplicationTyesLogic
    {
        enum enMode { Update };

        public int ID { get; set; }
        public  string Title { get; set; }

        public double Fees { get; set; }

        private enMode _mode;
        public clsApplicationTyesLogic(int ID, string Title, double Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;

            _mode = enMode.Update;
        }

        public clsApplicationTyesLogic()
        {

            this.ID = -1;
            this.Title = string.Empty;
            this.Fees = 0;


        }
        public static DataTable GetApplicationsTypes()
        {
            return DVLD_DataAccess.clsApplictionsTypes.GetApplictionTypes();
        }

        public static clsApplicationTyesLogic GetApplicationType(byte ID)
        {
            string Title = string.Empty;
            double Fee = 0;
            if (DVLD_DataAccess.clsApplictionsTypes.GetApplicationTypeByID(ID, ref Title, ref Fee))
            {
                return new clsApplicationTyesLogic(ID, Title, Fee); 
            }

            else 
                return null;    
        }


        private bool _UpdateApplication()
        {
            return DVLD_DataAccess.clsApplictionsTypes.UpdateApplictionType(this.ID, this.Title, this.Fees);
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
