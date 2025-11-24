using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsLocalDrivingLicenseApplications
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public clsApplications ApplicationInfo { get; set; }

        public clsLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;
            ApplicationInfo = new clsApplications();
            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, clsApplications ApplicationInfo, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationInfo = ApplicationInfo;
            this.LicenseClassID = LicenseClassID;
            Mode = enMode.Update;
        }

        private bool _AddLDLA()
        {
            if (ApplicationInfo != null && ApplicationInfo.ApplicationID == -1)
            {
                if (!ApplicationInfo.Save())
                    return false;
            }

            this.LocalDrivingLicenseApplicationID =
                LocalDrivingLicenseApplicationsData.AddLDLA(ApplicationInfo.ApplicationID, this.LicenseClassID);

            return this.LocalDrivingLicenseApplicationID != -1;
        }

        private bool _UpdateLDLA()
        {
            if (ApplicationInfo != null && !ApplicationInfo.Save())
                return false;

            return LocalDrivingLicenseApplicationsData.UpdateLDLA(this.LocalDrivingLicenseApplicationID,
                                                                  this.ApplicationInfo.ApplicationID,
                                                                  this.LicenseClassID);
        }

        public static bool DeleteLDLA(int LocalDrivingLicenseApplicationID)
        {
            clsLocalDrivingLicenseApplications LDLA=clsLocalDrivingLicenseApplications.GetLDLAByID(LocalDrivingLicenseApplicationID);
            clsTestAppointments testAppointments = clsTestAppointments.FindTestAppointmentsByID(LDLA.ApplicationInfo.ApplicationID);
            TestData.DeleteTestByTestAppointmentID(LocalDrivingLicenseApplicationID.);
            return LocalDrivingLicenseApplicationsData.DeleteLDLA(LocalDrivingLicenseApplicationID);
        }

        public static DataTable GetAllLDLAs(string columnName=null,string value=null)
        {
            return LocalDrivingLicenseApplicationsData.GetAllLDLAs(columnName,value);
        }
        public static int GetApplicationIDByLDLAppID(int LocalDrivingLicenseApplicationID)
        {
            return LocalDrivingLicenseApplicationsData.GetApplicationIDByLDLAppID(LocalDrivingLicenseApplicationID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddLDLA())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        clsApplications.DeleteApplication(ApplicationInfo.ApplicationID);
                        return false;
                    }
                        

                case enMode.Update:
                    return _UpdateLDLA();
            }
            return false;
        }

        public static clsLocalDrivingLicenseApplications GetLDLAByID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            if (LocalDrivingLicenseApplicationsData.GetLDLAByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {

                clsApplications app = clsApplications.GetApplicationByID(ApplicationID);
                return new clsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID, app, LicenseClassID);
            }
            else
            {
                return null;
            }
        }
        public static bool IsPersonLinkedWithSameClass(int PersonID, int LicenseClassID)
        {
            return LocalDrivingLicenseApplicationsData.IsPersonLinkedWithSameClass(PersonID, LicenseClassID);
        }
    }

}
