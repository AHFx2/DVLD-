using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    internal class DataSettings
    {
        public static string ConnectionString = "server=.;database=DVLD;user id=sa;password=sa123456;";

        public static string HandleNUllStrings(object obj)
        {
            if (obj == DBNull.Value)
            {

                return string.Empty;
            }
            else
            {
                return obj.ToString();
            }
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
