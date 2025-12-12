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
    public partial class frmManageDetainedLicenses : Form
    {
        private clsUser _CurrrentUser;
        public frmManageDetainedLicenses(clsUser CurrentUser)
        {
            InitializeComponent();
            _CurrrentUser = CurrentUser;
        }
        private void _refreshDetainedList()
        {
            cbFilters.SelectedIndex = 0;
            dgvDetained.DataSource = clsDetainedLicenses.GetAllDetainedLicenses();
            lblCount.Text = (dgvDetained.Rows.Count).ToString();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            _refreshDetainedList();
        }

        private string GetColumnName(string selected)
        {
            switch (selected)
            {
                case "None": return "None";
                case "Detain ID": return "DetainID";
                case "National No": return "NationalNo";
                case "Full Name": return "FullName";
                case "Is Released": return "IsReleased";
                case "Release Application ID": return "ReleaseApplicationID";
                default: return null;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string column = GetColumnName(cbFilters.SelectedItem?.ToString());
            string value = tbFilter.Text.Trim();

            if (column == "None")
            {
                dgvDetained.DataSource = clsDetainedLicenses.GetAllDetainedLicenses();
            }
            else
            {
                dgvDetained.DataSource = clsDetainedLicenses.GetAllDetainedLicenses(column, value);
            }
            lblCount.Text = (dgvDetained.Rows.Count).ToString();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilters.SelectedIndex == 0) ? false : true;
            tbFilter.Text = "";
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPersonDetails(clsPerson.FindPersonByID(clsDrivers.GetDriverByID(clsLicenses.GetLicenseById(Convert.ToInt32(dgvDetained.CurrentRow.Cells["L.ID"].Value)).DriverID).PersonID)).ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLicenseInfo(clsLicenses.GetLicenseById(Convert.ToInt32(dgvDetained.CurrentRow.Cells["L.ID"].Value)).ApplicationID).ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLicenseHistory(clsDrivers.GetDriverByID(clsLicenses.GetLicenseById(Convert.ToInt32(dgvDetained.CurrentRow.Cells["L.ID"].Value)).DriverID).PersonID).ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReleaseDetainedLicense(_CurrrentUser, Convert.ToInt32(dgvDetained.CurrentRow.Cells["L.ID"].Value)).ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(clsDetainedLicenses.IsDetainedLicenseExists(Convert.ToInt32(dgvDetained.CurrentRow.Cells["L.ID"].Value)))
            {
                releaseDetainedLicenseToolStripMenuItem.Enabled = true;
            }
            else
            {
                releaseDetainedLicenseToolStripMenuItem.Enabled = false;
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            new frmDetainLicense(_CurrrentUser).ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            new frmReleaseDetainedLicense(_CurrrentUser).ShowDialog();
        }
    }
}
