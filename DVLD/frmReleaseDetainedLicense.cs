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
    public partial class frmReleaseDetainedLicense : Form
    {
        private clsUser _CurrentUser;
        private clsDetainedLicenses _DetainedLicenses;
        private clsApplications _RelApp;
        private clsLicenses _license;
        private Decimal _AppFees= clsApplicationTypes.GetApplicationTypeByID((int)eApplicationType.ReleaseDetained).ApplicationFees;
        public frmReleaseDetainedLicense(clsUser User)
        {
            InitializeComponent();
            _CurrentUser = User;
        }

        private void txtLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseID.Text))
            {
                errorProvider1.SetError(txtLicenseID, "License ID is required.");
            }
            else
            {
                errorProvider1.SetError(txtLicenseID, "");
            }
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            btnRelease.Enabled = false;
            linklblShowLicenseHistory.Enabled = false;
            linklblShowLicenseInfo.Enabled = false;
            lblInputApplicationFees.Text = _AppFees.ToString();
        }
        private bool HasValidationErrors()
        {
            return !string.IsNullOrEmpty(errorProvider1.GetError(txtLicenseID));
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
                if (!clsDetainedLicenses.IsDetainedLicenseExists(_license.LicenseID))
                {
                    MessageBox.Show("Selected License is not Detained,choose another one.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _DetainedLicenses = clsDetainedLicenses.GetDetainedLicenseByID(_license.LicenseID);
                lblinputDetainID.Text = _DetainedLicenses.DetainID.ToString();
                lblInputLicenseID.Text=_DetainedLicenses.LicenseID.ToString();
                lblinputDetainDate.Text = _DetainedLicenses.DetainDate.ToString();
                lblinputCreatedBy.Text = clsUser.GetUserByID(_DetainedLicenses.CreatedByUserID).UserName;
                lblInputFineFees.Text = _DetainedLicenses.FineFees.ToString();
                lblInputTotalFees.Text = (_DetainedLicenses.FineFees+_AppFees).ToString();
                btnRelease.Enabled = true;
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

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained Driving License?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            _RelApp = clsDetainedLicenses.ReleaseLicense(_license, _CurrentUser);
            if (_RelApp != null)
            {
                MessageBox.Show($"Detained License Released Successfully With ID={_RelApp.ApplicationID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                linklblShowLicenseInfo.Enabled = true;
                btnRelease.Enabled = false;
                gbFilter.Enabled = false;
                lblInputRApplicationID.Text = _RelApp.ApplicationID.ToString();
                uclicenseInfoDetails.LoadLicenseInfo(clsLicenseDetails.getAllLicenseDetails(_license.ApplicationID));
            }
            else
            {
                MessageBox.Show("Error Releasing Detained License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLicenseInfo(_license.ApplicationID).ShowDialog();
        }

        private void linklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLicenseHistory(clsDrivers.GetDriverByID(_license.DriverID).PersonID).ShowDialog();
        }
    }
}
