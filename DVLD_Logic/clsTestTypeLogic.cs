using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Logic
{
    public class clsTestTypeLogic
    {

        public enum enTestType { VisionTest = 1, WrittenTest, PracticalTest };
        enum enMode { Update };

        public enTestType IDD { get; set; }
        public byte ID { get; set; }
        public string Title { get; set; }
        public string Descritpion { get; set; }

        public double Fees { get; set; }

        private enMode _Mode;

        public clsTestTypeLogic() { 
        
            this.ID = 0;
            this.Title = string.Empty;
            this.Descritpion = string.Empty;
            this.Fees = 0;

            _Mode = enMode.Update;
        }

        public clsTestTypeLogic(byte ID, string Title, double Fees, string Description)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
            this.Descritpion= Description;

            _Mode = enMode.Update;
        }
        
        public clsTestTypeLogic(clsTestTypeLogic.enTestType ID, string Title, double Fees, string Description)
        {
            this.IDD = ID;
            this.Title = Title;
            this.Fees = Fees;
            this.Descritpion= Description;

            _Mode = enMode.Update;
        }

        public static DataTable GetTestsTypes()
        {
            return DVLD_DataAccess.clsTestsTypes.GetAllTestTypes();
        }

        public static clsTestTypeLogic GetTestTypeByID(byte ID)
        {
            string Title = string.Empty;
            string Description = string.Empty;
            double Fee = 0;
            if (DVLD_DataAccess.clsTestsTypes.GetTestTypeByID(ID, ref Title, ref Description , ref Fee))
            {
                return new clsTestTypeLogic(ID, Title, Fee, Description);
            }

            else
                return null;
        }
    
        public static clsTestTypeLogic GetTestTypeByID(clsTestTypeLogic.enTestType ID)
        {
            string Title = string.Empty;
            string Description = string.Empty;
            double Fee = 0;
            if (DVLD_DataAccess.clsTestsTypes.GetTestTypeByID((byte)ID, ref Title, ref Description , ref Fee))
            {
                return new clsTestTypeLogic(ID, Title, Fee, Description);
            }

            else
                return null;
        }
    
        private bool _UpdatetestType()
        {
            return DVLD_DataAccess.clsTestsTypes.UpdateTestType (this.ID, this.Title,this.Descritpion, this.Fees);
        }

        public bool Save()
        {
            switch (_Mode)
            {

                case enMode.Update:
                    return _UpdatetestType();
            }

            return false;
        }
    }
}
