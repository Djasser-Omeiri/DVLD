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
    }


}
