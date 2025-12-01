using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsLicenseDetails
    {
        public string ClassName { get; set; }
        public string FullName { get; set; }
        public int LicenseID { get; set; }
        public int NationalityCountryID { get; set; }
        public bool Gendor { get; set; }
        public DateTime IssueDate { get; set; }
        public int IssueReason { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DriverID { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsDetained { get; set; }

        public clsLicenseDetails()
        {
            this.ClassName = "";
            this.FullName = "";
            this.LicenseID = -1;
            this.NationalityCountryID = -1;
            this.Gendor = false;
            this.IssueDate = DateTime.MinValue;
            this.IssueReason = 0;
            this.Notes = "";
            this.IsActive = false;
            this.DateOfBirth = DateTime.MinValue;
            this.DriverID = -1;
            this.ExpirationDate = DateTime.MinValue;
            this.IsDetained = false;
        }
        public clsLicenseDetails(
            string className,
            string fullName,
            int licenseID,
            int nationalityCountryID,
            bool gendor,
            DateTime issueDate,
            int issueReason,
            string notes,
            bool isActive,
            DateTime dateOfBirth,
            int driverID,
            DateTime expirationDate,
            bool isDetained)
        {
            this.ClassName = className;
            this.FullName = fullName;
            this.LicenseID = licenseID;
            this.NationalityCountryID = nationalityCountryID;
            this.Gendor = gendor;
            this.IssueDate = issueDate;
            this.IssueReason = issueReason;
            this.Notes = notes;
            this.IsActive = isActive;
            this.DateOfBirth = dateOfBirth;
            this.DriverID = driverID;
            this.ExpirationDate = expirationDate;
            this.IsDetained = isDetained;
        }
        public static clsLicenseDetails getAllLicenseDetails(int ApplicationID)
        {
            string ClassName = "";
            string FullName = "";
            int LicenseID = -1;
            int NationalityCountryID = -1;
            bool Gendor = false;
            DateTime IssueDate = DateTime.MinValue;
            int IssueReason = 0;
            string Notes = "";
            bool IsActive = false;
            DateTime DateOfBirth = DateTime.MinValue;
            int DriverID = -1;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsDetained = false;
            if (LicensesData.GetLicenseAllInfosByID(ApplicationID,ref ClassName,ref FullName,ref LicenseID,ref NationalityCountryID,ref Gendor,ref IssueDate,ref IssueReason,ref Notes,ref IsActive,ref DateOfBirth,ref DriverID,ref ExpirationDate,ref IsDetained))
            {
                return new clsLicenseDetails(ClassName, FullName, LicenseID, NationalityCountryID, Gendor, IssueDate, IssueReason, Notes, IsActive, DateOfBirth, DriverID, ExpirationDate, IsDetained); 
            }
            else
            {
                return null;
            }
        }

    }
}
