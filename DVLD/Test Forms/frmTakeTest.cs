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
    public partial class frmTakeTest : Form
    {
        private int _TestAppointmentID;
        private clsTestAppointments _clsTestAppointments;
        private clsApplicationDetails _clsApplicationDetails;
        private clsTest _clsTest;
        private eTest _Test;
        public frmTakeTest(int TestAppointmentID, clsApplicationDetails clsApplicationDetails, eTest test)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
            _clsApplicationDetails = clsApplicationDetails;
            _Test = test;
        }

        private void _load()
        {
            _clsTestAppointments = new clsTestAppointments();
            _clsTestAppointments = clsTestAppointments.FindTestAppointmentsByID(_TestAppointmentID);
            lblinputid.Text = _clsApplicationDetails.LocalDrivingLicenseApplicationID.ToString();
            lblinputClass.Text = _clsApplicationDetails.ClassName;
            lblinputName.Text = _clsApplicationDetails.FullName;
            lblinputTrial.Text = clsLocalDrivingLicenseApplications.TotalTrialsPerTest(_clsApplicationDetails.LocalDrivingLicenseApplicationID, _Test).ToString();
            lblinputFees.Text = clsTestTypes.GetTestTypeByID(_clsTestAppointments.TestTypeID).TestTypeFees.ToString();
            lblinputTestID.Text = "Not Taken";
            lblinputDate.Text = _clsTestAppointments.AppointmentDate.ToString();
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
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save the test result?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                this.Close();
            _clsTest = new clsTest();
            _clsTest.TestAppointmentID = _TestAppointmentID;
            _clsTest.TestResult = rbPass.Checked;
            _clsTest.Notes = tbNotes.Text == string.Empty ? "" : tbNotes.Text;
            _clsTest.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            MessageBox.Show(_clsTest.AddTest() ? "Test Result Saved Successfully." : "Failed to Save Test Result.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblinputTestID.Text = _clsTest.TestID.ToString();
        }
    }
}
