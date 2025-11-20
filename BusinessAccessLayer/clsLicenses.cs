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
        public DateTime ExpiraionDate { get; set; }
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
            this.ExpiraionDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsLicenses(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate
            , DateTime ExpiraionDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpiraionDate = ExpiraionDate;
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
                , this.ExpiraionDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
            return this.LicenseID != -1;
        }
        private bool _UpdateLicense()
        {
            return LicensesData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate
                , this.ExpiraionDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
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
        public static clsLicenses GetLicenseById(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpiraionDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            if (LicensesData.GetLicenseByID(LicenseID,ref  ApplicationID,ref  DriverID, ref  LicenseClass, ref  IssueDate
            , ref  ExpiraionDate, ref  Notes, ref  PaidFees, ref  IsActive, ref  IssueReason, ref  CreatedByUserID))
            {
                return new clsLicenses(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpiraionDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

    }
}
