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
        }
        public bool ScheduleTest()
        {
            TestAppointmentID=TestAppointmentsData.AddAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked
                , this.RetakeTestApplicationID);
            return TestAppointmentID!= -1;
        }
        public bool UpdateAppointment()
        {
            return TestAppointmentsData.UpdateAppointment(this.TestAppointmentID, this.AppointmentDate, this.PaidFees, this.IsLocked
                , this.RetakeTestApplicationID);
        }
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
        public static DataTable GetAllAppointmentsBy(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return TestAppointmentsData.GetAllAppointmentsBy(LocalDrivingLicenseApplicationID , TestTypeID);
        }
    }
}
