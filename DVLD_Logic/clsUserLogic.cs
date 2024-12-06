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
        public string Password { get; set; }
        public byte IsActive { get; set; }

        public clsPersonLogic Person {  get; set; }
        private enMode Mode { get; set; }
        public clsUserLogic()
        {
            ID = -1;

            Username = string.Empty;
            Password = string.Empty;
            IsActive = 0;
            this.Person = null;
            Mode = enMode.Add;
        }


        private clsUserLogic(int ID, string UserName, string Password, byte IsActive, clsPersonLogic person)
        {
            this.ID = ID;
            this.Username = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Person = person;
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


        public bool UpdateUserPassword(string Password)
        {
            if (DVLD_DataAccess.clsUserData.UpdateUserPassword(this.ID, Password))
            {
                this.Password = Password;
                return true;    
            }

            return false;
        }


        public static clsUserLogic GetUser(int ID)
        {
            int TempPersonID = 0; // -> due the propartyes are not varibles and u can't pass them by ref
            string Username = string.Empty; string PassWord = string.Empty; byte IsActive = 0;
            if (DVLD_DataAccess.clsUserData.GetUserByID(ID, ref TempPersonID, ref Username, ref PassWord, ref IsActive))
            {
                clsPersonLogic person = clsPersonLogic.GetPerson(TempPersonID);
                return new clsUserLogic(ID, Username, PassWord, IsActive, person);
            }

            else return null;
        }

        public static clsUserLogic GetUser(string Username)
        {
            clsPersonLogic person = new clsPersonLogic();
            int TempPersonID = 0; // -> due the propartyes are not varibles and u can't pass them by ref
            int ID = 0; string PassWord = string.Empty; byte IsActive = 0; 
            if (DVLD_DataAccess.clsUserData.GetUserByUsername(ref ID, ref TempPersonID, Username, ref PassWord, ref IsActive))
            {
                person = clsPersonLogic.GetPerson(TempPersonID);
                return new clsUserLogic(ID, Username, PassWord, IsActive, person);
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
            return DVLD_DataAccess.clsUserData.IsUserExsits(ID);
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
