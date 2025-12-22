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
    public partial class frmDetainLicense : Form
    {
        private clsDetainedLicenses _DetainedLicenses;
        private clsLicenses _license;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lblinputDetainDate.Text = DateTime.Now.ToString();
            lblinputCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            btnDetain.Enabled = false;
            linklblShowLicenseHistory.Enabled = false;
            linklblShowLicenseInfo.Enabled = false;
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseID.Text))
            {
                errorProvider1.SetError(txtLicenseID, "License ID is required");
            }
            else
            {
                errorProvider1.SetError(txtLicenseID, "");
            }
        }

        private bool HasValidationErrors()
        {
            return !string.IsNullOrEmpty(errorProvider1.GetError(txtLicenseID))
                && !string.IsNullOrEmpty(errorProvider1.GetError(tbFineFees));
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (HasValidationErrors()) return;
            _license = clsLicenses.GetLicenseById(Int32.Parse(txtLicenseID.Text));

            if (_license != null)
            {
                uclicenseInfoDetails.LoadLicenseInfo(clsLicenseDetails.getAllLicenseDetails(_license.ApplicationID));
                lblInputLicenseID.Text = txtLicenseID.Text;
                linklblShowLicenseHistory.Enabled = true;
                if (clsDetainedLicenses.IsDetainedLicenseExists(_license.LicenseID))
                {
                    MessageBox.Show("Selected License is already Detained,choose another one.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbFineFees.Enabled = false;
                    return;
                }
                tbFineFees.Enabled = true;
                btnDetain.Enabled = true;
            }
            else
            {
                MessageBox.Show($"There is no license with id={txtLicenseID.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this Driving License?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            _DetainedLicenses = clsDetainedLicenses.CreateDetainedLicense(_license, clsGlobal.CurrentUser, tbFineFees.Text);
            if (_DetainedLicenses != null)
            {
                MessageBox.Show($"License Detained Successfully With ID={_DetainedLicenses.DetainID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                linklblShowLicenseInfo.Enabled = true;
                btnDetain.Enabled = false;
                gbFilter.Enabled = false;
                lblinputDetainID.Text = _DetainedLicenses.DetainID.ToString();
                tbFineFees.Enabled = false;
                uclicenseInfoDetails.LoadLicenseInfo(clsLicenseDetails.getAllLicenseDetails(_license.ApplicationID));
            }
            else
            {
                MessageBox.Show("Error Detaining License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void linklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLicenseHistory(clsDrivers.GetDriverByID(_license.DriverID).PersonID).ShowDialog();
        }

        private void linklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLicenseInfo(_license.ApplicationID).ShowDialog();
        }

        private void tbFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFineFees.Text))
            {
                errorProvider1.SetError(tbFineFees, "Fine Fees is required");
            }
            else
            {
                errorProvider1.SetError(tbFineFees, "");
            }
        }
    }
}
