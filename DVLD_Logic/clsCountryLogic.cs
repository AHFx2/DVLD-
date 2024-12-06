using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Logic
{
    public class clsCountryLogic
    {
        public static DataTable GetCountries()
        {
            return DVLD_DataAccess.clsCountryData.GetCountries();
        }

        public byte CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryPhoneCode { get; set; }

        public clsCountryLogic(byte countryID, string countryName, string CountryPhoneCode)
        {
            CountryID = countryID;
            CountryName = countryName;
            this.CountryPhoneCode = CountryPhoneCode;
        }

        public static clsCountryLogic Find(string Name)
        {
            byte ID = 0;
            string PhoneCode = string.Empty;
            if (DVLD_DataAccess.clsCountryData.GetCountryByName(Name, ref ID,  ref PhoneCode))
            {
                return new clsCountryLogic(ID, Name, PhoneCode);
            }

            else { return null; }
        }

        public static clsCountryLogic Find(byte Id)
        {
            string Name = "";

            string PhoneCode = "";
            if (DVLD_DataAccess.clsCountryData.GetCountryByID(ref Name, Id, ref PhoneCode))
            {
                return new clsCountryLogic(Id, Name, PhoneCode);
            }

            else { return null; }
        }

    }
}
