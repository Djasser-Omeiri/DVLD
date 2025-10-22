using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsTest
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTest()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = true;
            this.Notes = "";
            this.CreatedByUserID = -1;
        }
        private clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
        }
        public bool AddTest()
        {
            clsTestAppointments TestAppointments = new clsTestAppointments();
            TestAppointments=clsTestAppointments.FindTestAppointmentsByID(TestAppointmentID);
            TestAppointments.IsLocked = true;
            TestAppointments.UpdateAppointment();
            TestID = TestData.AddTest(this.TestAppointmentID, this.TestResult,this.Notes,this.CreatedByUserID);
            return TestID != -1;
        }
    }
}
