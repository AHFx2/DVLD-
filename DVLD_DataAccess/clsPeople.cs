using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace DVLD_DataAccess
{
    static public class clsPeopleData
    {

        // making the crud
        /*
            create
            read
            update 
            delete
         */

        static int AddPerson(int NationalNo, string Firstname, string Lastname, string Thirdname, string Fourthname,
                                DateTime BirthDate, char Gender, string Address, string Phone, string Email, byte NationlityCountryID, string ImagePath)
        {
           
          
            return 1;
        }

    }
}
