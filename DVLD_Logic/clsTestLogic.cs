using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Logic
{
    public class clsTestLogic
    {
        enum enMode { Add };
        public int ID { get; set; }
        public int ApoitmetnID { get; set; }
        public string Notes { get; set; }
        public int UserID { get; set; }
        public byte TestResult { get; set; }
        private enMode _Mode;


        public clsTestLogic()
        {
            this.ID = -1;
            this.ApoitmetnID = -1;
            this.Notes = string.Empty;
            this.UserID = -1;
            this.TestResult = 0;
            _Mode = enMode.Add;
        }


        public static bool DosePassTest(int LDLAppID, byte TestTypeID)
        {
            return DVLD_DataAccess.clsTest.DosePassTheTest(LDLAppID, TestTypeID);
        }

        private bool _AddTest()
        {
            this.ID = DVLD_DataAccess.clsTest.AddTest(this.ApoitmetnID, this.TestResult, this.Notes, this.UserID);
            return this.ID != -1;
        }


        public bool Save()
        {
            switch (this._Mode)
            {

                case enMode.Add:
                    return _AddTest();


                default:
                    return false;
            }
        }
    }
}
