
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = true;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            Mode = enMode.AddNew;
        }
        private clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName
            , DateTime DateOfBirth, bool Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
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
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
        }
        private  bool _AddNewPerson()
        {
            this.PersonID = PersonData.AddPerson(NationalNo, FirstName, SecondName, ThirdName, LastName
                , Convert.ToDateTime(DateOfBirth), Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            return this.PersonID != -1;
        }
        public static bool IsNationalExists(string NationalNo)
        {
            return PersonData.IsPersonExistsWithNationalNo(NationalNo);
        }
        private bool _UpdatePerson()
        {
            return PersonData.UpdatePerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName
                , Convert.ToDateTime(DateOfBirth), Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
        }
        public static bool DeletePerson(int ID)
        {
            return PersonData.DeletePerson(ID);
        }
        public static DataTable GetAllPersons()
        {
            return PersonData.GetAllPersons();
        }
        public static DataTable GetAllPersonsCustom(string columnName=null,string value=null)
        {
            return PersonData.GetAllPersonsCustom(columnName,value);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case (enMode.AddNew):
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case (enMode.Update):
                    return _UpdatePerson();
            }
            return false;
        }
        public static clsPerson FindPersonByID(int ID) {
          string NationalNo = "",FirstName= "", SecondName= "" , ThirdName="",LastName="",Address="",Phone=""
                ,Email="", ImagePath ="";
          DateTime DateOfBirth = DateTime.Now;
            bool Gendor = true;
            int NationalityCountryID = -1;
            if (PersonData.GetPersonByID(ID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName
                , ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            
                return new clsPerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName
                , DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindPersonBy(string columnName, string value)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = ""
                , Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            bool Gendor = true;
            int NationalityCountryID = -1;
            int PersonID = -1;
            if (PersonData.GetPersonCustom(columnName,value, ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName
                , ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName
                , DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
    }
}
