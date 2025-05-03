using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DVLD_Buisness;

namespace ConsoleApp1
{
    internal class Program
    {
        static string ComputeHash(string Input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        public static clsUser Map(DataRow row)
        {
            return new clsUser
            {
                Mode = clsUser.enMode.Update,
                UserID = Convert.ToInt16(row["UserID"]),
                PersonID = Convert.ToInt16(row["PersonID"]),
                UserName = row["UserName"].ToString(),
                Password = ComputeHash(row["Password"].ToString()),
                IsActive = Convert.ToBoolean(row["IsActive"])

            };
        }
        public static void HashUsers()
        {
            DataTable dt = clsUser.GetAllUsers();

            foreach (DataRow dr in dt.Rows) 
            {
                clsUser user = Map(dr);
                user.Save();
                Console.WriteLine($"Before Hashing: {dr["Password"].ToString()} | After Hashing {user.Password}");
            
            }
        }
        static void Main(string[] args)
        {
            HashUsers();
        }
    }
}
