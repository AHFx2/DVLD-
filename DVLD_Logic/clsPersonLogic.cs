using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;
namespace DVLD_Logic
{
    public class clsPersonLogic
    {
        enum enMode { Add, Update }
        public int ID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte CountryID { get; set; }
        public string ImagePath { get; set; }
        
        private enMode Mode { get; set; }
        public clsPersonLogic() {
            ID = -1;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Gendor = 0;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            CountryID = 0;
            ImagePath = string.Empty;

            Mode = enMode.Add;
        }


        private clsPersonLogic(int ID,string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, byte CountryID, string ImagePath
            )
        {
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
            this.ID = ID;

            Mode = enMode.Update;
        }

        private bool _AddPerson()
        {
            this.ID = DVLD_DataAccess.clsPersonData.AddPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth
                , this.Gendor, this.Address, this.Phone, this.Email, this.CountryID, this.ImagePath);
           
            return this.ID != -1;
        }

        private bool _UpdatePerson()
        {
            return DVLD_DataAccess.clsPersonData.UpdatePerson(this.ID,this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth
                , this.Gendor, this.Address, this.Phone, this.Email, this.CountryID, this.ImagePath);
        }

        public static clsPersonLogic GetPerson(int ID)
        {
            string NationalNo = string.Empty; string FirstName = string.Empty;  string SecondName = string.Empty; string ThirdName = string.Empty;
            string LastName = string.Empty;  DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0; string Address = string.Empty; string Phone = string.Empty; string Email = string.Empty; byte CountryID = 0;string ImagePath = string.Empty;
            if (DVLD_DataAccess.clsPersonData.GetPersonByID(ID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth
                , ref Gendor, ref Address, ref Phone, ref Email, ref CountryID, ref ImagePath))
            {
                return new clsPersonLogic(ID, NationalNo, FirstName, SecondName, ThirdName, LastName,  DateOfBirth,  Gendor,  Address,  Phone,  Email,  CountryID,  ImagePath);
            }

            else return null;
        }

        public static clsPersonLogic GetPerson(string NatID)
        {
            string FirstName = string.Empty; string SecondName = string.Empty; string ThirdName = string.Empty;
            string LastName = string.Empty; DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0; string Address = string.Empty; string Phone = string.Empty; string Email = string.Empty; byte CountryID = 0; string ImagePath = string.Empty;
            int ID = 0;
            if (DVLD_DataAccess.clsPersonData.GetPersonByNatID(ref ID,  NatID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth
                , ref Gendor, ref Address, ref Phone, ref Email, ref CountryID, ref ImagePath))
            {
                return new clsPersonLogic(ID, NatID, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryID, ImagePath);
            }

            else return null;
        }


        public static DataTable GePeople()
        {
            return DVLD_DataAccess.clsPersonData.GetPeople();
        }

        public static bool DeletePerson(int ID)
        {
            return DVLD_DataAccess.clsPersonData.DeletePerson(ID);
        }

        public static bool IsPersonExsit(int ID) { 
            return DVLD_DataAccess.clsPersonData.IsPersonExsits(ID);
        }

        public static bool IsPersonExsit(string NatID)
        {
            return DVLD_DataAccess.clsPersonData.IsPersonNatID(NatID);
        }

        public bool Save()
        {
            switch (this.Mode) {

                case enMode.Add:
                    return _AddPerson();

                case enMode.Update:
                    return _UpdatePerson();

                default:
                    return false;
            }


        }

    }
}
