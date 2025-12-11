using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsDetainedLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public Decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleasedApplicationID { get; set; }

        public clsDetainedLicenses()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.MinValue;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MinValue;
            this.ReleasedByUserID = -1;
            this.ReleasedApplicationID = -1;
            Mode = enMode.AddNew;
        }

        private clsDetainedLicenses(int DetainID, int LicenseID, DateTime DetainDate, Decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleaseByUserID, int? ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleaseByUserID;
            this.ReleasedApplicationID = ReleaseApplicationID;
            Mode = enMode.Update;
        }

        private bool _AddDetained()
        {
            this.DetainID = DetainedLicensesData.AddDetainedLicense(LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleasedApplicationID);
            return this.DetainID != -1;
        }
        private bool _UpdateDetained()
        {
            return DetainedLicensesData.UpdateDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleasedApplicationID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddDetained())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateDetained();
            }
            return false;
        }

        public static bool IsDetainedLicenseExists(int LicenseID)
        {
            return DetainedLicensesData.IsDetainedLicenseExists(LicenseID);
        }

        public static clsDetainedLicenses CreateDetainedLicense(clsLicenses _license,clsUser _CurrentUser,string FineFees)
        {
            clsDetainedLicenses _DetainedLicenses = new clsDetainedLicenses(); 
            _DetainedLicenses.LicenseID = _license.LicenseID;
            _DetainedLicenses.DetainDate = DateTime.Now;
            _DetainedLicenses.FineFees = Decimal.Parse(FineFees);
            _DetainedLicenses.CreatedByUserID = _CurrentUser.UserID;
            _DetainedLicenses.IsReleased = false;
            _DetainedLicenses.ReleaseDate = null;
            _DetainedLicenses.ReleasedByUserID = null;
            _DetainedLicenses.ReleasedApplicationID = null;
            if (_DetainedLicenses.Save())
            {
                return _DetainedLicenses;
            }
            else
            {
                return null;
            }
        }

        public static clsDetainedLicenses GetDetainedLicenseByID(int LicenseID)
        {
            int DetainID = -1, CreatedByUserID = -1;
            int? ReleaseApplicationID = -1, ReleasedByUserID = -1;
            DateTime DetainDate=DateTime.MinValue, ReleaseDate=DateTime.MinValue;
            Decimal FineFees = 0;
            bool IsReleased = false;
            if (DetainedLicensesData.GetDetainedLicenseByID(ref DetainID, LicenseID,ref DetainDate,ref FineFees,ref CreatedByUserID,ref IsReleased,ref ReleaseDate,ref ReleasedByUserID,ref ReleaseApplicationID))
            {
                return new clsDetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static clsApplications ReleaseLicense(clsLicenses License,clsUser _CurrentUser)
        {
            int PersonID=clsDrivers.GetDriverByID(License.DriverID).PersonID;
            clsApplications RelApp=new clsApplications();
            RelApp.ApplicantPersonID = PersonID;
            RelApp.ApplicationDate = DateTime.Now;
            RelApp.ApplicationTypeID = (int)eApplicationType.ReleaseDetained;
            RelApp.ApplicationStatus = 3;
            RelApp.LastStatutDate = DateTime.Now;
            RelApp.PaidFees = clsApplicationTypes.GetApplicationTypeByID((int)eApplicationType.ReleaseDetained).ApplicationFees;
            RelApp.CreatedByUserID = _CurrentUser.UserID;
            if (!RelApp.Save())
            {
                return null;
            }
            clsDetainedLicenses DetainedLicense = clsDetainedLicenses.GetDetainedLicenseByID(License.LicenseID);
            DetainedLicense.IsReleased = true;
            DetainedLicense.ReleaseDate = DateTime.Now;
            DetainedLicense.ReleasedByUserID= _CurrentUser.UserID;
            DetainedLicense.ReleasedApplicationID= RelApp.ApplicationID;
            if (DetainedLicense.Save())
            {
                return RelApp;
            }
            else
            {
                clsApplications.DeleteApplication(RelApp.ApplicationID);
                return null;
            }

        }
    }


}
