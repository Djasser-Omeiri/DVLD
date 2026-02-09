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
        private int _TestAppointmentID;
        private bool? _isLocked;
        private clsApplications _application;
        public enum enMode { AddNew = 0, Update = 1, Retake = 2 };
        private enMode _Mode;
        private eTest _Test;
        public frmScheduleTest(clsApplicationDetails ApplicationDetails, int testAppointmentID, eTest test ,bool isLocked = false, bool isRetake = false)
        {
            InitializeComponent();
            _applicationDetails = ApplicationDetails;
            _TestAppointmentID = testAppointmentID;
            _Test= test;
            if (isRetake)
            {
                _Mode = enMode.Retake;
            }
            else if (_TestAppointmentID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
            _isLocked = isLocked;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            switch (_Test)
            {
                case eTest.Vision:
                    MainPictureBox.Image = Properties.Resources.Vision_512;
                    gbTest.Text = "Vision Test";
                    break;
                case eTest.Written:
                    MainPictureBox.Image = Properties.Resources.Written_Test_512;
                    gbTest.Text = "Written Test";
                    break;
                case eTest.Street:
                    MainPictureBox.Image = Properties.Resources.driving_test_512;
                    gbTest.Text = "Street Test";
                    break;
            }
            lblinputid.Text = _applicationDetails.LocalDrivingLicenseApplicationID.ToString();
            lblinputClass.Text = _applicationDetails.ClassName;
            lblinputName.Text = _applicationDetails.FullName;
            lblinputTrial.Text = clsLocalDrivingLicenseApplications.TotalTrialsPerTest(_applicationDetails.LocalDrivingLicenseApplicationID, _Test).ToString();
            lblinputFees.Text = clsTestTypes.GetTestTypeByID((int)_Test).TestTypeFees.ToString();
            lblInputTfees.Text = lblinputFees.Text;
            lblinputRFees.Text = "0";
            lblinputRID.Text = "??";
            if (_Mode == enMode.AddNew || _Mode == enMode.Retake)
            {

                _testAppointment = new clsTestAppointments();
                if (_Mode == enMode.Retake)
                {
                    lblTitle.Text = "Schedule Retake Test";
                    gbRetakeTestInfo.Enabled = true;
                    lblinputRFees.Text =(clsApplicationTypes.GetApplicationTypeByID((int)eApplicationType.RetakeTest).ApplicationFees).ToString();
                    lblInputTfees.Text = (decimal.Parse(lblinputRFees.Text) + decimal.Parse(lblinputFees.Text)).ToString();
                }
                return;
            }
            else
            {
                _testAppointment = clsTestAppointments.FindTestAppointmentsByID(_TestAppointmentID);
                dtpDate.Value = _testAppointment.AppointmentDate;
                if (_isLocked == true)
                {
                    dtpDate.Enabled = false;
                    btnSave.Enabled = false;
                    lblTitle.Text = "Schedule Retake Test";
                    lblSubTitle.Text = "This Appointment is locked, you can only view the details.";
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (!ValidateForm())
            {
                MessageBox.Show("Please correct the errors on the form.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Mode != enMode.Update)
            {
                _testAppointment.LocalDrivingLicenseApplicationID = _applicationDetails.LocalDrivingLicenseApplicationID;
                _testAppointment.TestTypeID =(int)_Test;
                _testAppointment.PaidFees = decimal.Parse(lblInputTfees.Text);
                _testAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _testAppointment.IsLocked = false;
                _testAppointment.RetakeTestApplicationID = null;
            }
            _testAppointment.AppointmentDate = dtpDate.Value;
            _testAppointment.Save();
            if (_Mode== enMode.Retake)
            {
                _application = new clsApplications();
                _application.ApplicantPersonID = _applicationDetails.ApplicantPersonID;
                _application.ApplicationDate = DateTime.Now;
                _application.ApplicationTypeID = (int)eApplicationType.RetakeTest;
                _application.ApplicationStatus = 1;
                _application.LastStatutDate = DateTime.Now;
                _application.PaidFees = clsApplicationTypes.GetApplicationTypeByID((int)eApplicationType.RetakeTest).ApplicationFees;
                _application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                if (!_application.Save())
                {
                    MessageBox.Show("Failed to create retake application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblinputRID.Text = _application.ApplicationID.ToString();
                clsTestAppointments FirstApp = clsTestAppointments.FindTestAppointmentsByID(_TestAppointmentID);
                FirstApp.RetakeTestApplicationID = _application.ApplicationID;
                FirstApp.Save();
            }
            MessageBox.Show("Test Appointment Scheduled Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtpDate_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(dtpDate, (dtpDate.Value < DateTime.Now) ? "You cannot enter a previous date" : "");
        }
        private bool ValidateForm()
        {
            return string.IsNullOrEmpty(errorProvider1.GetError(dtpDate));
        }
    }
}
