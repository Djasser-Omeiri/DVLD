using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public  class clsDetainedLicenses
    {
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
        }

        private clsDetainedLicenses(int DetainID,int LicenseID,DateTime DetainDate,Decimal FineFees,int CreatedByUserID,bool IsReleased,DateTime? ReleaseDate,int? ReleaseByUserID,int? ReleaseApplicationID)
        {
            this.DetainID= DetainID;
            this.LicenseID= LicenseID;
            this.DetainDate=DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased= IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleaseByUserID;
            this.ReleasedApplicationID= ReleaseApplicationID;
        }
    }

    
}
