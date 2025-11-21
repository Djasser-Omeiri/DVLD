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

namespace DVLD.LocalLicense_Forms
{
    public partial class frmManageLDLA : Form
    {
        private clsUser _CurrentUser;
        public frmManageLDLA(clsUser currentUser)
        {
            InitializeComponent();
            _CurrentUser = currentUser;
        }
        private void _refreshLDLAList()
        {
            cbFilters.SelectedIndex = 0;
            dgvLDLA.DataSource = clsLocalDrivingLicenseApplications.GetAllLDLAs();
            lblCount.Text = (dgvLDLA.Rows.Count).ToString();

        }

        private void frmManageLDLA_Load(object sender, EventArgs e)
        {
            _refreshLDLAList();
        }

        private void btnAddLDLA_Click(object sender, EventArgs e)
        {
            new frmLocalLicenseInfo(_CurrentUser).ShowDialog();
            _refreshLDLAList();
        }
        private string GetColumnName(string selected)
        {
            switch (selected)
            {
                case "None": return "None";
                case "L.D.L.AppID": return "LocalDrivingLicenseApplicationID";
                case "NationalNo": return "NationalNo";
                case "FullName": return "FullName";
                case "Status": return "Status";
                default: return null;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string column = GetColumnName(cbFilters.SelectedItem?.ToString());
            string value = tbFilter.Text.Trim();

            if (column == "None")
            {
                dgvLDLA.DataSource = clsLocalDrivingLicenseApplications.GetAllLDLAs();
            }
            else
            {
                dgvLDLA.DataSource = clsLocalDrivingLicenseApplications.GetAllLDLAs(column, value);
            }
            lblCount.Text = (dgvLDLA.Rows.Count).ToString();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilters.SelectedIndex == 0) ? false : true;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsApplications.SetStatusToCancelled(clsLocalDrivingLicenseApplications.GetApplicationIDByLDLAppID(Convert.ToInt32(dgvLDLA.CurrentRow.Cells[0].Value)));
                _refreshLDLAList();
            }

        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTest(Convert.ToInt32(dgvLDLA.CurrentRow.Cells["L.D.L.AppID"].Value), _CurrentUser.UserID, eTest.Vision).ShowDialog();
            _refreshLDLAList();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTest(Convert.ToInt32(dgvLDLA.CurrentRow.Cells["L.D.L.AppID"].Value), _CurrentUser.UserID, eTest.Written).ShowDialog();
            _refreshLDLAList();
        }

        private void ScheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTest(Convert.ToInt32(dgvLDLA.CurrentRow.Cells["L.D.L.AppID"].Value), _CurrentUser.UserID, eTest.Street).ShowDialog();
            _refreshLDLAList();
        }

        private void menu_Opening(object sender, CancelEventArgs e)
        {
            if (dgvLDLA.CurrentRow.Cells["Status"].Value.ToString() == "Completed")
            {
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                cancelToolStripMenuItem.Enabled = false;
                return;
            }
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
            showLicenseToolStripMenuItem.Enabled = false;
            editApplicationToolStripMenuItem.Enabled = true;
            deleteApplicationToolStripMenuItem.Enabled = true;
            cancelToolStripMenuItem.Enabled = true;
            switch (Convert.ToInt32(dgvLDLA.CurrentRow.Cells["Passed Tests"].Value))
            {
                case 0:
                    ScheduleVisionTestToolStripMenuItem.Enabled = true;
                    ScheduleWrittenTestToolStripMenuItem.Enabled = false;
                    ScheduleStreetTestToolStripMenuItem.Enabled = false;
                    break;
                case 1:
                    ScheduleVisionTestToolStripMenuItem.Enabled = false;
                    ScheduleWrittenTestToolStripMenuItem.Enabled = true;
                    ScheduleStreetTestToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    ScheduleVisionTestToolStripMenuItem.Enabled = false;
                    ScheduleWrittenTestToolStripMenuItem.Enabled = false;
                    ScheduleStreetTestToolStripMenuItem.Enabled = true;
                    break;
                default:
                    ScheduleTestsToolStripMenuItem.Enabled = false;
                    break;
            }
            
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDrivingLicense(Convert.ToInt32(dgvLDLA.CurrentRow.Cells["L.D.L.AppID"].Value), _CurrentUser).ShowDialog();
            _refreshLDLAList();
        }
    }
}
