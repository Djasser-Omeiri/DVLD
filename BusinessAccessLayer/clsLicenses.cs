using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    
    public class clsLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode = enMode.AddNew;
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicenses()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsLicenses(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate
            , DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }

        private bool _AddLicense()
        {
            this.LicenseID = LicensesData.AddLicense(this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate
                , this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
            return this.LicenseID != -1;
        }
        private bool _UpdateLicense()
        {
            return LicensesData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate
                , this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case (enMode.AddNew):
                    if (_AddLicense())
                    {
                        Mode = enMode.Update; return true;
                    }
                    else return false;
                case enMode.Update:
                    return _UpdateLicense();
            }
            return false;
        }
        public static bool DeleteLicense(int LicenseID)
        {
            return LicensesData.DeleteLicense(LicenseID);
        }
        public static DataTable GetAllLicenses()
        {
            return LicensesData.GetAllLicenses();
        }
        public static DataTable GetAllLicensesForHistory(int PersonID)
        {
            return LicensesData.GetAllLicensesForHistory(PersonID);
        }
        public static clsLicenses GetLicenseById(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            if (LicensesData.GetLicenseByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate
            , ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicenses(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
        public static bool isPersonHaveLicenseWithSameClass(int ApplicationID, int LicenseClassID)
        {
            return LicensesData.IsPersonHaveLicenseWithSameClass(ApplicationID, LicenseClassID);
        }
        public static clsLicenses RenewLicense(clsLicenses oldLicense, clsUser _CurrentUser, string Notes)
        {
            int PersonID = clsDrivers.GetDriverByID(oldLicense.DriverID).PersonID;
            clsApplications RenewApp = new clsApplications();
            RenewApp.ApplicantPersonID = PersonID;
            RenewApp.ApplicationDate = DateTime.Now;
            RenewApp.ApplicationTypeID = 2;
            RenewApp.ApplicationStatus = 3;
            RenewApp.LastStatutDate = DateTime.Now;
            RenewApp.PaidFees = clsApplicationTypes.GetApplicationTypeByID((int)eApplicationType.Renew).ApplicationFees;
            RenewApp.CreatedByUserID = _CurrentUser.UserID;
            if (!RenewApp.Save())
            {
                return null;
            }
            clsLicenses NewLicense = new clsLicenses();
            clsLicenseClasses LicenseCls = clsLicenseClasses.GetLicenseClsByID(oldLicense.LicenseClass);
            NewLicense.ApplicationID = RenewApp.ApplicationID;
            NewLicense.DriverID = oldLicense.DriverID;
            NewLicense.LicenseClass = oldLicense.LicenseClass;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(LicenseCls.DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = LicenseCls.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = 2;
            NewLicense.CreatedByUserID = _CurrentUser.UserID;
            if (NewLicense.Save())
            {
                oldLicense.IsActive = false;
                if (!oldLicense.Save())
                {
                    clsLicenses.DeleteLicense(NewLicense.LicenseID); 
                    clsApplications.DeleteApplication(RenewApp.ApplicationID);
                    return null;
                }
                return NewLicense;
            }
            else
            {
                clsApplications.DeleteApplication(RenewApp.ApplicationID);
                return null;
            }

        }

        public static clsLicenses ReplaceLicense(clsLicenses oldLicense, clsUser _CurrentUser, eApplicationType ReplacementFor)
        {
            int PersonID = clsDrivers.GetDriverByID(oldLicense.DriverID).PersonID;
            clsApplications ReplaceApp = new clsApplications();
            ReplaceApp.ApplicantPersonID = PersonID;
            ReplaceApp.ApplicationDate = DateTime.Now;
            ReplaceApp.ApplicationTypeID = (int)ReplacementFor;
            ReplaceApp.ApplicationStatus = 3;
            ReplaceApp.LastStatutDate = DateTime.Now;
            ReplaceApp.PaidFees = clsApplicationTypes.GetApplicationTypeByID((int)ReplacementFor).ApplicationFees;
            ReplaceApp.CreatedByUserID = _CurrentUser.UserID;
            if (!ReplaceApp.Save())
            {
                return null;
            }
            clsLicenses NewLicense = new clsLicenses();
            clsLicenseClasses LicenseCls = clsLicenseClasses.GetLicenseClsByID(oldLicense.LicenseClass);
            NewLicense.ApplicationID = ReplaceApp.ApplicationID;
            NewLicense.DriverID = oldLicense.DriverID;
            NewLicense.LicenseClass = oldLicense.LicenseClass;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(LicenseCls.DefaultValidityLength);
            NewLicense.Notes = oldLicense.Notes;
            NewLicense.PaidFees = LicenseCls.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = (byte)((ReplacementFor==eApplicationType.Damaged)?3:4);
            NewLicense.CreatedByUserID = _CurrentUser.UserID;
            if (NewLicense.Save())
            {
                oldLicense.IsActive = false;
                if (!oldLicense.Save())
                {
                    clsLicenses.DeleteLicense(NewLicense.LicenseID);
                    clsApplications.DeleteApplication(ReplaceApp.ApplicationID);
                    return null;
                }
                return NewLicense;
            }
            else
            {
                clsApplications.DeleteApplication(ReplaceApp.ApplicationID);
                return null;
            }

        }

    }
}
