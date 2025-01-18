using System;

namespace DVLD_DataAccess
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = "server=.;database=DVLD;user id=sa;password=sa123456;";

        public static string HandleNUllStrings(object obj)
        {
            
            return (obj == DBNull.Value) ? string.Empty : obj.ToString();
        }

        public static object HandleEmptyStrings(string obj)
        {
            if (obj == string.Empty)
            {
                return DBNull.Value;
            }
            else
            {
                return obj.ToString();
            }
        }
   

    }
}
