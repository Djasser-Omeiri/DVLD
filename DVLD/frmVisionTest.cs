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
    public partial class frmVisionTest : Form
    {
        private int _LDLAID;
        private clsApplicationDetails _clsApplicationDetails;
        private int _UserID;
        public frmVisionTest(int LDLAID, int UserID)
        {
            InitializeComponent();
            _LDLAID = LDLAID;
            _UserID = UserID;
        }
        private void frmVisionTest_Load(object sender, EventArgs e)
        {
           
            _refresh();
        }
        private void _refresh()
        {
            _clsApplicationDetails = clsApplicationDetails.GetAllAppInfosByID(_LDLAID);
            ucApplicationDetails.LoadPerson(_clsApplicationDetails);
            dgvAppointments.DataSource = clsTestAppointments.GetAllAppointmentsBy(_LDLAID, 1);
            lblinputRecords.Text = dgvAppointments.RowCount.ToString();
        }
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.Rows.Count != 0 && !clsTestAppointments.CheckAddAccess(Convert.ToInt32(dgvAppointments.CurrentRow.Cells["TestAppointmentID"].Value), _LDLAID, 1))
            {
                MessageBox.Show("Person already has an Active Vision Test appointment.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dgvAppointments.Rows.Count== 0)
            {
                new frmScheduleTest(_clsApplicationDetails, _UserID, -1).ShowDialog();
            }
            else if (!clsTest.FindTestByAppointmentID(Convert.ToInt32(dgvAppointments.Rows[dgvAppointments.Rows.Count-1].Cells["TestAppointmentID"].Value)).TestResult)
            {
                new frmScheduleTest(_clsApplicationDetails, _UserID, Convert.ToInt32(dgvAppointments.Rows[dgvAppointments.Rows.Count - 1].Cells["TestAppointmentID"].Value),false,true).ShowDialog(); 
            }
            else if (clsTest.FindTestByAppointmentID(Convert.ToInt32(dgvAppointments.Rows[dgvAppointments.Rows.Count - 1].Cells["TestAppointmentID"].Value)).TestResult)
            {
                MessageBox.Show("This person already passed this test before,you can only retake failed tests", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _refresh();

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTakeTest(Convert.ToInt32(dgvAppointments.CurrentRow.Cells["TestAppointmentID"].Value), _clsApplicationDetails, _UserID).ShowDialog();
            _refresh();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmScheduleTest(_clsApplicationDetails, _UserID, Convert.ToInt32(dgvAppointments.CurrentRow.Cells["TestAppointmentID"].Value), Convert.ToBoolean(dgvAppointments.CurrentRow.Cells["IsLocked"].Value)).ShowDialog();
            _refresh();
        }
    }
}
