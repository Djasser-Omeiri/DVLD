using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class clsInternationalLicenses
    {
        public int InternationalLicenseID { get; set; }
        public clsApplications Application { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public static clsInternationalLicenses GetIDLAByID(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;
            if (InternationalLicensesData.GetIDLAByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                clsApplications app =clsApplications.GetApplicationByID(ApplicationID);
                return new clsInternationalLicenses(InternationalLicenseID, app, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            
            }
            else return null;
        }
        public clsInternationalLicenses()
        {
            this.InternationalLicenseID = -1;
            this.Application= new clsApplications();
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID= -1;
            this.CreatedByUserID = -1; 
            this.IsActive = false;
            this.IssueDate= DateTime.MinValue;
            this.ExpirationDate= DateTime.MinValue;
        }

        private clsInternationalLicenses(int InternationalLicenseID, clsApplications Application, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.Application = Application;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
        }

        private bool _AddIDLA()
        {
            if (Application != null && Application.ApplicationID == -1)
            {
                if (!Application.Save())
                    return false;
            }
            this.InternationalLicenseID = InternationalLicensesData.AddIDLA(Application.ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            return InternationalLicenseID != -1;
        }
        public bool Save()
        {
            if (_AddIDLA())
            {
                return true;
            }
            else
            {
                clsApplications.DeleteApplication(Application.ApplicationID);
                return false;
            }
        }
        public static DataTable GetAllIDLA(string columnName=null,string value=null)
        {
            return InternationalLicensesData.GetAllIDLAs(columnName,value);
        }
        public static DataTable GetAllIDLAsForHistory(int PersonID)
        {
            return InternationalLicensesData.GettAllIDLAsForHistory(PersonID);
        }
        public static bool IsInternationalLicenseExists(int LicenseID)
        {
            return InternationalLicensesData.isInternationalLicenseExists(LicenseID);   
        }

    }
}
