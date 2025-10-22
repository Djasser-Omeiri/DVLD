using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmScheduleTest : Form
    {
        private clsApplicationDetails _applicationDetails;
        private clsTestAppointments _testAppointment;
        private int _UserID;
        public frmScheduleTest(clsApplicationDetails ApplicationDetails,int UserID)
        {
            InitializeComponent();
            _applicationDetails = ApplicationDetails;
            _UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            lblinputid.Text = _applicationDetails.LocalDrivingLicenseApplicationID.ToString();
            lblinputClass.Text = _applicationDetails.ClassName;
            lblinputName.Text = _applicationDetails.FullName;
            lblinputTrial.Text = "0";
            lblinputFees.Text = clsTestTypes.GetTestTypeByID(1).TestTypeFees.ToString();
            lblInputTfees.Text = lblinputFees.Text;
            lblRFees.Text = "0";
            lblinputRID.Text = "?";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _testAppointment = new clsTestAppointments();
            _testAppointment.LocalDrivingLicenseApplicationID = _applicationDetails.LocalDrivingLicenseApplicationID;
            _testAppointment.TestTypeID = 1;
            _testAppointment.AppointmentDate = dtpDate.Value;
            _testAppointment.PaidFees = decimal.Parse(lblInputTfees.Text);
            _testAppointment.CreatedByUserID = _UserID;
            _testAppointment.IsLocked = false;
            _testAppointment.RetakeTestApplicationID = null;
            _testAppointment.ScheduleTest();
            MessageBox.Show("Test Appointment Scheduled Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
