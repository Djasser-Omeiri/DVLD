using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsTestAppointments
    {
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode = enMode.AddNew;
        public int TestAppointmentID { set; get; }
        public int TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public Decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public int? RetakeTestApplicationID { set; get; }
        public clsTestAppointments()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.MinValue;
            PaidFees = 0;
            CreatedByUserID = -1;
            IsLocked = false;
            RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;
        }
        private clsTestAppointments(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, Decimal PaidFees, int CreatedByUserID, bool IsLocked
            , int? RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            Mode = enMode.Update;
        }
        private bool _ScheduleTest()
        {
            TestAppointmentID=TestAppointmentsData.AddAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked
                , this.RetakeTestApplicationID);
            return TestAppointmentID!= -1;
        }
        private bool _UpdateAppointment()
        {
            return TestAppointmentsData.UpdateAppointment(this.TestAppointmentID, this.AppointmentDate, this.PaidFees, this.IsLocked
                , this.RetakeTestApplicationID);
        }
        /*public bool UpdateRetakeTestApplicationID()
        {
            return TestAppointmentsData.UpdateRetakeAppointment(this.TestAppointmentID, this.RetakeTestApplicationID);
        }*/
        public static clsTestAppointments FindTestAppointmentsByID(int TestAppointmentID)
        {
            int TestTypeID = -1; int LocalDrivingLicenseApplicationID = -1; DateTime AppointmentDate=DateTime.Now;decimal PaidFees = 0;int CreatedByUserID = -1;bool IsLocked = false;
            int? RetakeTestApplicationID = -1;

            if (TestAppointmentsData.GetAppointmentByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID
                , ref IsLocked, ref RetakeTestApplicationID))

                return new clsTestAppointments(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID
                , IsLocked, RetakeTestApplicationID);
            else
                return null;
        }
        public static bool CheckAddAccess(int TestAppointmentID, int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            if(TestAppointmentsData.isAppointmentExist(LocalDrivingLicenseApplicationID, TestTypeID))
            {
                return TestAppointmentsData.GetAppointmentLockStatus(TestAppointmentID);
            }
            return true;
        }
        public static DataTable GetAllAppointmentsBy(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return TestAppointmentsData.GetAllAppointmentsBy(LocalDrivingLicenseApplicationID , TestTypeID);
        }
        public static bool isLocked(int TestAppointmentID)
        {
            return TestAppointmentsData.GetAppointmentLockStatus(TestAppointmentID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case (enMode.AddNew):
                    if (_ScheduleTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case (enMode.Update):
                    return _UpdateAppointment();
            }
            return false;
        }
    }
}
