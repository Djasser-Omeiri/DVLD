using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsApplicationDetails
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public string ClassName { get; set; }
        public int PassedTestCount { get; set; }
        public int ApplicationID { get; set; }
        public string Status { get; set; }

        public decimal PaidFees { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public string FullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastStatusDate { get; set; }

        public string UserName { get; set; }
        public int ApplicantPersonID { get; set; }

        public clsApplicationDetails()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ClassName = string.Empty;
            this.PassedTestCount = 0;
            this.ApplicationID = -1;
            this.Status = string.Empty;
            this.PaidFees = 0;
            this.ApplicationTypeTitle = string.Empty;
            this.FullName = "";
            this.ApplicationDate = DateTime.MinValue;
            this.LastStatusDate = DateTime.MinValue;
            this.UserName = string.Empty;
            this.ApplicantPersonID = -1;
        }
        private clsApplicationDetails(int LocalDrivingLicenseApplicationID,
        string ClassName,
        int PassedTestCount,
        int ApplicationID,
        string Status,
        decimal PaidFees,
        string ApplicationTypeTitle,
        string FullName,
        DateTime ApplicationDate,
        DateTime LastStatusDate,
        string UserName,int ApplicantPersonID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ClassName = ClassName;
            this.PassedTestCount = PassedTestCount;
            this.ApplicationID = ApplicationID;
            this.Status = Status;
            this.PaidFees = PaidFees;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.FullName = FullName;
            this.ApplicationDate = ApplicationDate;
            this.LastStatusDate = LastStatusDate;
            this.UserName = UserName;
            this.ApplicantPersonID = ApplicantPersonID;
        }

        public static clsApplicationDetails GetAllAppInfosByID(int LocalDrivingLicenseApplicationID)
        {
            string ClassName = string.Empty;
            int PassedTestCount = 0;
            int ApplicationID = -1;
            string Status = string.Empty;
            decimal PaidFees = 0;
            string ApplicationTypeTitle = string.Empty;
            string FullName = "";
            DateTime ApplicationDate = DateTime.MinValue;
            DateTime LastStatusDate = DateTime.MinValue;
            string UserName = string.Empty;
            int ApplicantPersonID = -1;

            if (LocalDrivingLicenseApplicationsData.getAllInfos(LocalDrivingLicenseApplicationID, ref ClassName, ref PassedTestCount, ref ApplicationID, ref Status, ref PaidFees, ref ApplicationTypeTitle, ref FullName, ref ApplicationDate, ref LastStatusDate, ref UserName,ref ApplicantPersonID))
            {
                return new clsApplicationDetails(LocalDrivingLicenseApplicationID, ClassName, PassedTestCount, ApplicationID, Status, PaidFees, ApplicationTypeTitle, FullName, ApplicationDate, LastStatusDate, UserName, ApplicantPersonID);
            }
            else
            {
                return null;
            }
        }
    }
}
