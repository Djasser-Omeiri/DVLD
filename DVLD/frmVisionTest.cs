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
        private int _LDLAID ;
        private clsApplicationDetails _clsApplicationDetails ;
        private int _UserID;
        public frmVisionTest(int LDLAID,int UserID)
        {
            InitializeComponent();
            _LDLAID = LDLAID;
            _UserID = UserID;
        }
        private void loaddgv()
        {
            dgvAppointments.DataSource = clsTestAppointments.GetAllAppointmentsBy(_LDLAID, 1);
            lblinputRecords.Text=dgvAppointments.RowCount.ToString();
        }
        
        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            _clsApplicationDetails = clsApplicationDetails.GetAllAppInfosByID(_LDLAID);
            ucApplicationDetails.LoadPerson(_clsApplicationDetails);
           loaddgv();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            new frmScheduleTest(_clsApplicationDetails,_UserID).ShowDialog();
            loaddgv();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTakeTest(Convert.ToInt32(dgvAppointments.CurrentRow.Cells["TestAppointmentID"].Value), _clsApplicationDetails,_UserID).ShowDialog();
            loaddgv();
        }
    }
}
