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
    public enum eTest { Vision=1, Written=2, Street=3 };
    public partial class frmTest : Form
    {
        private int _LDLAID;
        private clsApplicationDetails _clsApplicationDetails;
        private eTest _Test;
        
        public frmTest(int LDLAID, eTest test)
        {
            InitializeComponent();
            _LDLAID = LDLAID;
            _Test = test;
        }
        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            switch (_Test)
            {
                case eTest.Vision:
                    lblTitle.Text = "Vision Test Appointments";
                    MainPictureBox.Image = Properties.Resources.Vision_512;
                    this.Text = "Vision Test";
                    break;
                case eTest.Written:
                    lblTitle.Text = "Written Test Appointments";
                    MainPictureBox.Image= Properties.Resources.Written_Test_512;
                    this.Text = "Written Test";
                    break ;
                case eTest.Street:
                    lblTitle.Text = "Street Test Appointments";
                    MainPictureBox.Image= Properties.Resources.driving_test_512;
                    this.Text = "Street Test";
                    break ;
            }
            _refresh();
        }
        private void _refresh()
        {
            _clsApplicationDetails = clsApplicationDetails.GetAllAppInfosByID(_LDLAID);
            ucApplicationDetails.LoadPerson(_clsApplicationDetails);
            dgvAppointments.DataSource = clsTestAppointments.GetAllAppointmentsBy(_LDLAID, (int)_Test);
            lblinputRecords.Text = dgvAppointments.RowCount.ToString();
        }
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.Rows.Count != 0 && !clsTestAppointments.CheckAddAccess(Convert.ToInt32(dgvAppointments.CurrentRow.Cells["TestAppointmentID"].Value), _LDLAID, (int)_Test))
            {
                MessageBox.Show("Person already has an Active Test appointment.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dgvAppointments.Rows.Count== 0)
            {
                new frmScheduleTest(_clsApplicationDetails, -1, _Test).ShowDialog();
            }
            else if (!clsTest.FindTestByAppointmentID(Convert.ToInt32(dgvAppointments.Rows[dgvAppointments.Rows.Count-1].Cells["TestAppointmentID"].Value)).TestResult)
            {
                new frmScheduleTest(_clsApplicationDetails, Convert.ToInt32(dgvAppointments.Rows[dgvAppointments.Rows.Count - 1].Cells["TestAppointmentID"].Value), _Test, false,true).ShowDialog(); 
            }
            else if (clsTest.FindTestByAppointmentID(Convert.ToInt32(dgvAppointments.Rows[dgvAppointments.Rows.Count - 1].Cells["TestAppointmentID"].Value)).TestResult)
            {
                MessageBox.Show("This person already passed this test before,you can only retake failed tests", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _refresh();

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTakeTest(Convert.ToInt32(dgvAppointments.CurrentRow.Cells["TestAppointmentID"].Value), _clsApplicationDetails,_Test).ShowDialog();
            _refresh();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmScheduleTest(_clsApplicationDetails, Convert.ToInt32(dgvAppointments.CurrentRow.Cells["TestAppointmentID"].Value), _Test, Convert.ToBoolean(dgvAppointments.CurrentRow.Cells["IsLocked"].Value)).ShowDialog();
            _refresh();
        }
    }
}
