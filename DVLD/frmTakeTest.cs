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
        private int _UserID;
        public frmTakeTest(int TestAppointmentID, clsApplicationDetails clsApplicationDetails,int UserID)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
            _clsApplicationDetails = clsApplicationDetails;
            _UserID = UserID;
        }

        private void _load()
        {
            _clsTestAppointments=new clsTestAppointments();
            _clsTestAppointments=clsTestAppointments.FindTestAppointmentsByID(_TestAppointmentID);
            lblinputid.Text=_clsApplicationDetails.LocalDrivingLicenseApplicationID.ToString();
            lblinputClass.Text=_clsApplicationDetails.ClassName;
            lblinputName.Text=_clsApplicationDetails.FullName;
            lblinputTrial.Text="0";//////Create method to get trial count
            lblinputFees.Text=clsTestTypes.GetTestTypeByID(_clsTestAppointments.TestTypeID).TestTypeFees.ToString();
            lblinputTestID.Text="Not Taken";
            lblinputDate.Text=_clsTestAppointments.AppointmentDate.ToString();
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
            if(MessageBox.Show("Are you sure you want to save the test result?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            this.Close();
            _clsTest =new clsTest();
            _clsTest.TestAppointmentID = _TestAppointmentID;
            _clsTest.TestResult = rbPass.Checked;
            _clsTest.Notes = tbNotes.Text==string.Empty?"":tbNotes.Text;
            _clsTest.CreatedByUserID = _UserID;
            MessageBox.Show(_clsTest.AddTest()?"Test Result Saved Successfully.":"Failed to Save Test Result.","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
            lblinputTestID.Text=_clsTest.TestID.ToString();
        }
    }
}
