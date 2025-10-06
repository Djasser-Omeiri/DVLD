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
                dgvLDLA.DataSource = clsLocalDrivingLicenseApplications.GetAllLDLAs(column,value);
            }
            lblCount.Text = (dgvLDLA.Rows.Count).ToString();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilters.SelectedIndex == 0) ? false : true;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                clsApplications.SetStatusToCancelled(clsLocalDrivingLicenseApplications.GetApplicationIDByLDLAppID(Convert.ToInt32(dgvLDLA.CurrentRow.Cells[0].Value)));
                _refreshLDLAList();
            }
            
        }
    }
}
