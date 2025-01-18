using System;
using System.Data;
using System.Xml.Linq;
using DVLD_DataAccess;
using System.ComponentModel.DataAnnotations;
using System.Reflection;


namespace DVLD_Buisness
{
    /// <summary>
    /// this is a class for person 
    /// </summary>
    public class clsPerson
    {
        /// <summary>
        /// Defines the modes of operation: AddNew or Update.
        /// </summary>
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        /// <summary>
        /// Properties representing a person's details.
        /// </summary>
        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            /// <summary>
            /// Gets the full name by combining all name fields.
            /// </summary>
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public string NationalNo { set; get; }

        /// <summary>
        /// Validates age using a custom attribute.
        /// </summary>
        [Validation.ValidateAge(18, 99)]
        public DateTime DateOfBirth { set; get; }

        public short Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }

        /// <summary>
        /// Holds detailed information about the person's country.
        /// </summary>
        public clsCountry CountryInfo;

        private string _ImagePath;

        /// <summary>
        /// Gets or sets the path to the person's image.
        /// </summary>
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        /// <summary>
        /// Default constructor that initializes default values for the person.
        /// </summary>
        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            Mode = enMode.AddNew;
        }

        /// <summary>
        /// Parameterized constructor for initializing a person's details.
        /// </summary>
        private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName,
            string LastName, string NationalNo, DateTime DateOfBirth, short Gendor,
             string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);
            Mode = enMode.Update;
        }

        /// <summary>
        /// Adds a new person to the data source.
        /// </summary>
        private bool _AddNewPerson()
        {
            // Call DataAccess Layer 
            this.PersonID = clsPersonData.AddNewPerson(
                this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.NationalNo,
                this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email,
                this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);
        }

        /// <summary>
        /// Updates an existing person's information in the data source.
        /// </summary>
        private bool _UpdatePerson()
        {
            // Call DataAccess Layer 
            return clsPersonData.UpdatePerson(
                this.PersonID, this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.NationalNo, this.DateOfBirth, this.Gendor,
                this.Address, this.Phone, this.Email,
                this.NationalityCountryID, this.ImagePath);
        }

        /// <summary>
        /// Finds a person by their ID and returns their details.
        /// </summary>
        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            short Gendor = 0;

            bool IsFound = clsPersonData.GetPersonInfoByID
                                (
                                    PersonID, ref FirstName, ref SecondName,
                                    ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth,
                                    ref Gendor, ref Address, ref Phone, ref Email,
                                    ref NationalityCountryID, ref ImagePath
                                );

            if (IsFound)
                // Return new object of that person with the right data
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
                          NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        /// <summary>
        /// Finds a person by their National Number and returns their details.
        /// </summary>
        public static clsPerson Find(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int PersonID = -1, NationalityCountryID = -1;
            short Gendor = 0;

            bool IsFound = clsPersonData.GetPersonInfoByNationalNo
                                (
                                    NationalNo, ref PersonID, ref FirstName, ref SecondName,
                                    ref ThirdName, ref LastName, ref DateOfBirth,
                                    ref Gendor, ref Address, ref Phone, ref Email,
                                    ref NationalityCountryID, ref ImagePath
                                );

            if (IsFound)
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
                          NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        /// <summary>
        /// Saves the person's details by adding or updating based on the mode.
        /// </summary>
        public bool Save()
        {
            if (this._ValidatePerson())
            {
                switch (this.Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewPerson())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case enMode.Update:
                        return _UpdatePerson();
                }
            }
            return false;
        }

        /// <summary>
        /// Retrieves all people from the data source.
        /// </summary>
        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        /// <summary>
        /// Deletes a person by their ID.
        /// </summary>
        public static bool DeletePerson(int ID)
        {
            return clsPersonData.DeletePerson(ID);
        }

        /// <summary>
        /// Checks if a person exists by their ID.
        /// </summary>
        public static bool isPersonExist(int ID)
        {
            return clsPersonData.IsPersonExist(ID);
        }

        /// <summary>
        /// Checks if a person exists by their National Number.
        /// </summary>
        public static bool isPersonExist(string NationlNo)
        {
            return clsPersonData.IsPersonExist(NationlNo);
        }

        /// <summary>
        /// Validates the person's data based on custom attributes.
        /// </summary>
        private bool _ValidatePerson()
        {
            Type type = typeof(clsPerson);

            foreach (var proparty in type.GetProperties())
            {
                if (Attribute.IsDefined(proparty, typeof(Validation.ValidateAgeAttribute)))
                {
                    Validation.ValidateAgeAttribute ragneattrbuite = (Validation.ValidateAgeAttribute)Attribute.GetCustomAttribute(proparty, typeof(Validation.ValidateAgeAttribute));
                    var varr = proparty.GetValue(this);

                    if (varr is int value)
                    {
                        if ((value < ragneattrbuite.minAge || value > ragneattrbuite.maxAge))
                        {
                            return false;
                        }
                    }
                    else return false;
                }
            }

            return true;
        }
    }

}
