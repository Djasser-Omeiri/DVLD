using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class clsInternationalLicenseDetails
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public string FullName { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public int NationalityCountryID { get; set; }
        public bool Gendor { get; set; }
        public DateTime IssueDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DriverID { get; set; }
        public DateTime ExpirationDate { get; set; }

        public clsInternationalLicenseDetails()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.FullName = string.Empty;
            this.IssuedUsingLocalLicenseID= -1;
            this.NationalityCountryID = -1;
            this.Gendor = false;
            this.IssueDate = DateTime.MinValue;
            this.IsActive = false;
            this.DateOfBirth = DateTime.MinValue;
            this.DriverID = -1;
            this.ExpirationDate = DateTime.MinValue;
        }

        private clsInternationalLicenseDetails(int InternationalLicenseID, int ApplicationID, string FullName, int IssuedUsingLocalLicenseID, int NationalityCountryID, bool Gendor, DateTime IssueDate, bool IsActive, DateTime DateOfBirth, int DriverID, DateTime ExpirationDate)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.FullName = FullName;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.NationalityCountryID = NationalityCountryID;
            this.Gendor = Gendor;
            this.IssueDate = IssueDate;
            this.IsActive = IsActive;
            this.DateOfBirth = DateOfBirth;
            this.DriverID = DriverID;
            this.ExpirationDate = ExpirationDate;
        }

        public static clsInternationalLicenseDetails GetInternationalLicenseDetailsByID(int InternationalLicenseID)
        {
            int ApplicationID = -1, IssuedUsingLocalLicenseID = -1, NationalityCountryID = -1, DriverID=-1;
            string FullName = "";
            DateTime IssueDate=DateTime.MinValue, DateOfBirth=DateTime.MinValue, ExpirationDate=DateTime.MinValue;
            bool Gendor = false, IsActive = false;
            if (InternationalLicensesData.GetIDLAllInfosByID(InternationalLicenseID,ref ApplicationID,ref FullName,ref IssuedUsingLocalLicenseID,ref NationalityCountryID,ref Gendor,ref IssueDate,ref IsActive,ref DateOfBirth,ref DriverID,ref ExpirationDate))
            {
              return new clsInternationalLicenseDetails(InternationalLicenseID, ApplicationID, FullName, IssuedUsingLocalLicenseID, NationalityCountryID, Gendor, IssueDate, IsActive, DateOfBirth, DriverID, ExpirationDate);
            }
            else
            {
                return null;
            }

        }
    }
}
