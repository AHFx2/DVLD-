using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;
using Microsoft.SqlServer.Server;

namespace DVLD_Logic
{
    public class clsUserLogic
    {
        enum enMode { Add, Update }
        public int ID { get; set; }
        public string Username { get; set; }
        public int PersonID { get; set; }
        public clsPersonLogic Person {  get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        private enMode Mode { get; set; }
        public clsUserLogic()
        {
            ID = -1;

            Username = string.Empty;
            Password = string.Empty;
            IsActive = false;
            this.Person = null;
            Mode = enMode.Add;
        }


        private clsUserLogic(int ID, string UserName, string Password, bool IsActive, int PersonID)
        {
            this.ID = ID;
            this.Username = UserName;
            this.Password = Password;
            this.PersonID = PersonID;
            this.Person = clsPersonLogic.GetPerson(this.PersonID);
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }

        private bool _AddUser()
        {
            this.ID = DVLD_DataAccess.clsUserData.AddUser(this.Person.ID, this.Username, this.Password, this.IsActive);

            return this.ID != -1;
        }

        private bool _UpdateUser()
        {
            return DVLD_DataAccess.clsUserData.UpdateUser(this.ID, this.Person.ID, this.Username, this.Password,this.IsActive);
        }


        public bool UpdateUserPassword()
        {
            if (DVLD_DataAccess.clsUserData.UpdateUserPassword(this.ID, this.Password))
            {
                return true;    
            }

            return false;
        }


        public static clsUserLogic GetUser(int ID)
        {
            int PersonID = 0; 
            string Username = string.Empty; string PassWord = string.Empty; bool IsActive = false;
            if (DVLD_DataAccess.clsUserData.GetUserByID(ID, ref PersonID, ref Username, ref PassWord, ref IsActive))
            {
                return new clsUserLogic(ID, Username, PassWord, IsActive, PersonID);
            }

            else return null;
        }



        public static clsUserLogic GetUser(string Username)
        {
            int PersonID = 0;
            int ID = 0; string PassWord = string.Empty; bool IsActive = false; 
            if (DVLD_DataAccess.clsUserData.GetUserByUsername(ref ID, ref PersonID, Username, ref PassWord, ref IsActive))
            {
                return new clsUserLogic(ID, Username, PassWord, IsActive, PersonID);
            }

            else return null;
        }



        public static DataTable GetUsers()
        {
            return DVLD_DataAccess.clsUserData.GetUsers();
        }

        public static bool DeleteUser(int ID)
        {
            return DVLD_DataAccess.clsUserData.DeleteUser(ID);
        }

        public static bool IsUserExsitByID(int ID)
        {
            return DVLD_DataAccess.clsUserData.IsUserExsitsByID(ID);
        }

        public static bool IsUserExsitByUserName(string username)
        {
            return DVLD_DataAccess.clsUserData.IsUserExsitsByUserName(username);
        }

        public static bool IsPersonUser(int PersonID)
        {
            return DVLD_DataAccess.clsUserData.IsPersonUser(PersonID);
        }

        public bool Save()
        {
            switch (this.Mode)
            {

                case enMode.Add:
                    return _AddUser();

                case enMode.Update:
                    return _UpdateUser();

                default:
                    return false;
            }


        }
    }
}
